using UnityEngine;
using UnityEngine.UI;

namespace SpeedTutorInspectSystem
{
    public class InspectionRaycast : MonoBehaviour
    {
        [Header("Raycast Length/Layer")]
        [SerializeField] private int rayLength = 5;
        [SerializeField] private LayerMask layerMaskInteract;
        [SerializeField] private LayerMask layerMaskExclude;
        private ObjectController raycastedObj;

        [Header("Crosshair Reference")]
        [SerializeField] private Image crosshair;
        private bool isCrosshairActive;
        private bool doOnce;

        void Update()
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int Mask = 1 << layerMaskExclude | layerMaskInteract.value;

            if (Physics.Raycast(transform.position, fwd, out hit, rayLength, Mask))
            {
                if (hit.collider.CompareTag("InteractObject"))
                {
                    if (!doOnce)
                    {
                        raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                        raycastedObj.ShowObjectName();
                        CrosshairChange(true);
                    }

                    isCrosshairActive = true;
                    doOnce = true;

                    if (Input.GetMouseButtonDown(0))
                    {
                        raycastedObj.ShowExtraInfo();
                    }
                }
            }

            else
            {
                if (isCrosshairActive)
                {
                    raycastedObj.HideObjectName();
                    CrosshairChange(false);
                    doOnce = false;
                }
            }
        }

        void CrosshairChange(bool on)
        {
            if (on && !doOnce)
            {
                crosshair.color = Color.red;
            }

            else
            {
                crosshair.color = Color.white;
                isCrosshairActive = false;
            }
        }
    }
}
