using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerUpHandler,IPointerEnterHandler,IPointerExitHandler

{
    public List<DragAndDrop3D> foodItems = new List<DragAndDrop3D>();

    public DragAndDrop3D TakeItem(int index)
    {
        var foodItem = foodItems[index];
        foodItems.RemoveAt(index);

        return foodItem;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (DragAndDrop3D.currentlyHeld)
        {
            foodItems.Add(DragAndDrop3D.currentlyHeld);
            Debug.Log(DragAndDrop3D.currentlyHeld);

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (DragAndDrop3D.currentlyHeld)
        {
            DragAndDrop3D.currentlyHeld.inventory = this;
          

        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (DragAndDrop3D.currentlyHeld)
        {
            DragAndDrop3D.currentlyHeld.inventory = null;
        }
      

    }
}
