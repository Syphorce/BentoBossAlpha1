using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodItem : MonoBehaviour
{
    public Sprite foodImage;
    public Transform drop;
    public GameObject item;

     public void Awake()
    {
        
    }
    public void BuildItem()
    {
        Instantiate(item, new Vector3(drop.position.x,drop.position.y,drop.position.z), drop.rotation);
            
    }
}
