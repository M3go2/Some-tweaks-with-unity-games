using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class MouseClick : MonoBehaviour
{
    // public CameraShake cameraShake;

    void Update(){
        if (Input.GetMouseButtonDown(0)) {
            // StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
            CameraShaker.Instance.ShakeOnce(4.0f, 4.0f, 0.1f, 1.0f);
        }
    }
}
