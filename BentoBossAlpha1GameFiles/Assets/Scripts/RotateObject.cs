using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateObject : MonoBehaviour
{

    private void Start()
    {
        FixedUpdate();
    }


    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, 0, 15);
        }

    }



}
