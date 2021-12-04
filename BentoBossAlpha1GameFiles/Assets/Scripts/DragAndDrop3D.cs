using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragAndDrop3D : MonoBehaviour
{
    // // private Vector3 mOffset;
    // private float mZCoord;

    
    void OnMouseDown()

    {
        GameObject.Find("Drag Collider").GetComponent<Collider>().enabled = true;
        gameObject.GetComponent<Rigidbody>().freezeRotation = true;
        // mZCoord = Camera.main.WorldToScreenPoint(
        // gameObject.transform.position).z;
        // // Store offset = gameobject world pos - mouse world pos
        // mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }

    private Vector3 GetMouseAsWorldPoint()

    {
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100,~1))
            {
                Debug.Log(hit.transform.name);
                // 1 << 3
                // Debug.Log(hit.transform.name);
                // Debug.Log("hit");

                return hit.point;
            }

                 return Vector3.zero;


        // // Pixel coordinates of mouse (x,y)
        // Vector3 mousePoint = Input.mousePosition;
        // // z coordRay ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          
        // mousePoint.z = mZCoord;
        // // Convert it to world points
        // return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseDrag()
    {
       transform.position = GetMouseAsWorldPoint();
    }

    void OnMouseUp() {

   GameObject.Find("Drag Collider").GetComponent<Collider>().enabled = false;
   gameObject.GetComponent<Rigidbody>().freezeRotation = false;

    }
}
