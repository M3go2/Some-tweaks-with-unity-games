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
        body2D = GetComponent<Rigidbody>();

        if (body2D == null) {
            Debug.error("Rigidbody2D required for MovableObject script");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
