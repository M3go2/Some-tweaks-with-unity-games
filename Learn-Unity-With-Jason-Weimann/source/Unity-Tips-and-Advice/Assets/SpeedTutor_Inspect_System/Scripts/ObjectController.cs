using UnityEngine;

namespace SpeedTutorInspectSystem
{
    public class ObjectController : MonoBehaviour
    {
        [Space(10)] [SerializeField] private string objectName;

        [Space(10)] [TextArea] [SerializeField] private string extraInfo;

        [Space(10)] [SerializeField] private InspectionController inspectionController;

        public void ShowObjectName()
        {
            inspectionController.ShowName(objectName);
        }

        public void HideObjectName()
        {
            inspectionController.HideName();
        }

        public void ShowExtraInfo()
        {
            inspectionController.ShowAdditionalInfo(extraInfo);
        }
    }
}
