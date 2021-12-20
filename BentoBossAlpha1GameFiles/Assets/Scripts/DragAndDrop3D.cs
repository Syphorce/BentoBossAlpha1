using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragAndDrop3D : MonoBehaviour
{
    public static DragAndDrop3D currentlyHeld;
    private Vector3 mOffset;
    private float mZCoord;

    void OnMouseDown()

    {
        currentlyHeld = this;
        mZCoord = Camera.main.WorldToScreenPoint(
        gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }

    private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
       transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    private void OnMouseUp()
    {
        currentlyHeld = null;
        /* 
         if(inventory)
        {
            inventory.foodItems.Add(this);
            //Debug.Log(inventory.foodItems);
        }
        */
    }
}
