using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{
    // Know what objects are clickable
    public LayerMask clickableLayer;

    // Swap cursor per object
    public Texture2D pointer; // Normal pointer
    public Texture2D target; // Cursor for clickable objects like the world
    public Texture2D doorway; // Cursor for doorways
    public Texture2D combat; // Cursor for combat actions

    public EventVector3 OnClickEnvironment;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            bool isDoor = false;
            bool isItem = false;

            if (hit.collider.gameObject.tag == "Doorway")
            {
                Cursor.SetCursor(doorway, new Vector2(16, 16), CursorMode.Auto);
                isDoor = true;
            } 
            else if (hit.collider.gameObject.tag == "Item")
            {
                Cursor.SetCursor(combat, new Vector2(16, 16), CursorMode.Auto);
                isItem = true;
            } 
            else
            {
                Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (isDoor) 
                {
                    Debug.Log("Opening door");
                    Transform doorLocation = hit.collider.gameObject.transform;
                    OnClickEnvironment.Invoke(doorLocation.position);
                }
                else if (isItem)
                {
                    Debug.Log("Collecting item");
                    Transform itemLocation = hit.collider.gameObject.transform;
                    OnClickEnvironment.Invoke(itemLocation.position);
                }
                else 
                {
                    OnClickEnvironment.Invoke(hit.point);
                }
            }
        } else
        {
            Cursor.SetCursor(pointer, Vector2.zero, CursorMode.Auto);
        }
    }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> {}
