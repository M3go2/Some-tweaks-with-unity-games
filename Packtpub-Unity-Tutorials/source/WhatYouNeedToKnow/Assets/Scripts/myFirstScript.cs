using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time), transform.position.z);
    }
}
