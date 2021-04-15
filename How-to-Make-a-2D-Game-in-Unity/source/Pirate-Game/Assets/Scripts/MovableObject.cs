using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public float movementSpeed = 125F;

    Rigidbody2D body2D;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();

        if (body2D == null) {
            Debug.LogError("Rigidbody2D required for MovableObject script");
        }
    }

    private void OnMouseDrag()
    {
        // This turns our mouse point into usable 2D coordinates
        Vector3 touchPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 shipPosition = transform.position;

        Vector2 directionToMove = new Vector2(0, 0);

        if (shipPosition.y < touchPoint.y) {
            // Need to move up, set the direction to move to be
            // the distance between cursor and ship
            directionToMove.y += touchPoint.y - shipPosition.y;
        } else if (shipPosition.y > touchPoint.y) {
            directionToMove.y -= shipPosition.y - touchPoint.y;
        }

        body2D.AddForce(directionToMove * movementSpeed, ForceMode2D.Force);
    }

}
