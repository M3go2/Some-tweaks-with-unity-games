using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorThing : MonoBehaviour
{
    void OnDrawGizmos() {
        Vector2 point = transform.position;
        float length = point.magnitude;

        // Vector2.Distance(a, b);
        // (a-b).magnitude
        // sqrt((a.x-b.x)^2+(b.y-b.y)^2)
        
        Vector2 directionToPoint = point.normalized;

        Gizmos.DrawLine(Vector2.zero, directionToPoint);
    }
}
