using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
	public float upForce;					//Upward force of the "flap".
	private bool isDead = false;	//Has the player collided with a wall?

	private Animator anim;				//Reference to the Animator component.
	private Rigidbody2D rb2d;			//Holds a reference to the Rigidbody2D component of the bird.

	// Reference to the Main camera's animator component.
	private Animator camAnim;

	private AudioSource audioSource;
	private ParticleSystem particles;

	//If flapDuration is greater than or equal to this value, the bird won't fly higher.
	private float maxDuration = 0.7f;
	
	//Duration of the flap.
  private float flapDuration = 0.0f;

	void Start()
	{
		// Get reference to the Animator component attached to this GameObject.
		anim = GetComponent<Animator> ();
		// Get and store a reference to the Rigidbody2D attached to this GameObject.
		rb2d = GetComponent<Rigidbody2D>();

		// Get reference to the Animator component attached to main camera.
		camAnim = Camera.main.GetComponent<Animator>();
		
		audioSource = GetComponent<AudioSource>();
		particles = GetComponentInChildren<ParticleSystem>();
	}

	void Update()
	{
		// Don't allow control if the bird has died.
		if (isDead == false) {
			// Look for input to trigger a "flap".
			if (Input.GetMouseButtonDown(0)) {
				//...tell the animator about it and then...
				anim.SetTrigger("Flap");
				
				//...zero out the birds current y velocity before...
				rb2d.velocity = Vector2.zero;
				//	new Vector2(rb2d.velocity.x, 0);
				//..giving the bird some upward force.
				rb2d.AddForce(new Vector2(0, upForce));

				// Tell the animator about it
				camAnim.SetTrigger("Flap");
				
				// This plays the audioClip attached to the AudioSource component.
				audioSource.Play();

				particles.Play();

				flapDuration = 0.0f;
			}

			if (Input.GetMouseButton(0)) {
				if(flapDuration < maxDuration) {
					flapDuration += Time.deltaTime;
					rb2d.velocity = Vector2.up * upForce;
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		// Zero out the bird's velocity
		rb2d.velocity = Vector2.zero;
		// If the bird collides with something set it to dead...
		isDead = true;
		//...tell the Animator about it...
		anim.SetTrigger ("Die");
		//...and tell the game control about it.
		GameControl.instance.BirdDied ();
	}
}
