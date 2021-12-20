using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "ScriptableObjects/ItemDatabase", order = 1)]
public class ItemDatabase : ScriptableObject
{
    [SerializeField] private List<Item> itemList;

    public List<Item> ItemList {
        get {
            return itemList;
        }

        set {
            itemList = value;
        }
    }

    public Item Get { get; internal set; }

    /*public Item CopyItem(int value)
    {
        return new Item { id = ItemList[value].id, amount = ItemList[value].amount, Image = ItemList[value].Image, selectedType = ItemList[value].selectedType };
    }
    */
}
