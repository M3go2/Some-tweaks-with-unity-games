using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{

  // Know what objects are clickable
  public LayerMask clickableLayer;

  // Swap curser per object
  public Texture2D normalCursor; // Normal cursor
  public Texture2D targetCursor; // Cursor for clickable objects like the world
  public Texture2D doorwayCursor; // Cursor for doorways
  public Texture2D combatCursor; // Cursor for combat actions

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
        Cursor.SetCursor(doorwayCursor, new Vector2(16, 16), CursorMode.Auto);
        isDoor = true;
      }
      else if (hit.collider.gameObject.tag == "Item")
      {
        Cursor.SetCursor(combatCursor, new Vector2(16, 16), CursorMode.Auto);
        isItem = true;
      }
      else
      {
        Cursor.SetCursor(targetCursor, new Vector2(16, 16), CursorMode.Auto);
      }

      if (Input.GetMouseButtonDown(0))
      {
        if (isDoor)
        {
          Debug.Log("Moving towards the Door");
          OnClickEnvironment.Invoke(hit.point);
        }
        else if (isItem)
        {
          Debug.Log("Moving towards the Item");
          Transform item = hit.collider.gameObject.transform;
          OnClickEnvironment.Invoke(item.position);
        }
        else
        {
          OnClickEnvironment.Invoke(hit.point);
        }
      }
    }
    else
    {
      Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.Auto);
    }
  }
}

[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }
