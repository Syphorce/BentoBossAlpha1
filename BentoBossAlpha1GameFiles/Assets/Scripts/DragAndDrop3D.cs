using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragAndDrop3D : MonoBehaviour
{
    public static DragAndDrop3D currentlyHeld;
  float dist;
    Vector3 startPos;
    public GameObject dragCollider;
    /*
    private Vector3 mOffset;
    private float mZCoord;
    float posX;
    float posZ;
    float posY;
    */

    /*private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            //store offset = gameobject world ps - mouse world pos
            mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
           
        }
        if (Input.GetMouseButton(0))
        {
            transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, transform.position.z);
            //transform.position = GetMOuseAsWorldPoint + mOffset;

        }
    }
    */

    private void Start()
    {
        dragCollider.SetActive(false);
        print(dragCollider + "is inactive");
    }


    void OnMouseDown()

    {
        currentlyHeld = this;
        dragCollider.SetActive(true);
        print(dragCollider + "is active");
        /*
        mZCoord = Camera.main.WorldToScreenPoint(
        gameObject.transform.position).z;
        // Store offset = gameobject world pos - mouse world pos

        startPos = transform.position;
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
        posZ = Input.mousePosition.z - dist.z;
        */
        startPos = Camera.main.WorldToScreenPoint(transform.position);
        dist = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, startPos.y, Input.mousePosition.y));




    }

    /* private Vector3 GetMouseAsWorldPoint()

    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
    */

    void OnMouseDrag()
    {
        /*
        float disX = Input.mousePosition.x - posX;
        float disY = Input.mousePosition.y - posY;
        float disZ = Input.mousePosition.z - posZ;
        Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, disY, disZ));
        transform.position = new Vector3(lastPos.x, startPos.y, lastPos.z);

        transform.position = GetMouseAsWorldPoint() + mOffset;
        transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, transform.position.y, transform.position.z);
        */

        Vector3 lastPos = new Vector3(Input.mousePosition.x, startPos.y, Input.mousePosition.y);
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(lastPos) + dist;
        Vector3 dir = targetPos - transform.position;
        dist = dir.magnitude;
        Vector3.Normalize(dir);
        transform.position += new Vector3(dir.x * dist * 1.0f, dir.y * dist * 1.0f, dir.z * dist * 1.0f);
        
        /*dragCollider.SetActive(false);
        print(dragCollider + "is inactive");
        */
    }

    
   private void OnMouseUp()
  {
       currentlyHeld = null;

   }
    
}
