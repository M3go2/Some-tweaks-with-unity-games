using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMover : MonoBehaviour
{
    public float moveSpeed = 0;
    public int distance = 10;

    private Vector3 startPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed;
        if (transform.position.y > (startPosition.y + distance) || transform.position.y < (startPosition.y - distance)) {
            moveSpeed *= -1;
        }
    }
}
