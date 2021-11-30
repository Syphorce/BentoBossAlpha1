using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickDrag : MonoBehaviour {
    private Vector3 _dragoffset;
    void OnMouseDown() {
        _dragoffset = transform.position - GetMousePos();



    }





    void OnMouseDrag() {
        transform.position = GetMousePos() + _dragoffset;
    }

    Vector3 GetMousePos() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

}