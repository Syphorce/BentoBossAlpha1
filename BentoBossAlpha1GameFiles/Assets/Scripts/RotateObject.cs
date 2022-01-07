using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour
{
    public GameObject foodItem;
    private bool pickedUp;
    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    float accelx, accely, accelz = 0;
    bool currentlyHeld;
    /*
        private void Start()
        {
            FixedUpdate();
            pickedUp = false;

        }


        private void FixedUpdate()
        {
            if (Input.GetMouseButtonDown(1))
            {
                pickedUp = true;
                foodItem.SetActive(true);
                transform.Rotate(0, 0, 15);
            }

        }

        private void droppedItem()
        {
            pickedUp = false;
            if(pickedUp == false)
            {
                foodItem.SetActive(false);
            }
        }

        */

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.

        if (currentlyHeld)
        {


            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle * Time.deltaTime;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle * Time.deltaTime;

            // Rotate the cube by converting the angles into a quaternion.
            transform.rotation = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ) * transform.rotation;

            // Dampen towards the target rotation
            //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
    }

    private void OnMouseDown()
    {
       
        currentlyHeld = true;
    }

    private void OnMouseUp()
    {
        currentlyHeld = false;

    }

}

