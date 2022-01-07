using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour
{
    public GameObject foodItem;
    private bool pickedUp;

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
        

}
