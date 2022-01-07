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


        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

        accelx = Input.acceleration.x;
        accely = Input.acceleration.y;
        accelz = Input.acceleration.z;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
    }

}

