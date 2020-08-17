using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
  int score = 0;

  void Update()
  {
    float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 10;
    float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * 10;
    transform.Translate(h, v, 0);
  }

  private void OnTriggerEnter(Collider other)
  {
    score++;
    Debug.Log("New score is: "+ score);
  }
}
