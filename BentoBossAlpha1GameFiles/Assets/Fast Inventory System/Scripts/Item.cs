using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int id;
    public Sprite Image;
    public int amount;

    public enum type { NormalItem, Weapon, Armor, Potion, Bag }
    public type selectedType;
    internal string description;
    internal string title;
    internal Dictionary<string, int> stats;
    private string v1;
    private string v2;
    private Dictionary<string, int> dictionary;

    /*int count; //lifePotion?
      int attack;
      int defense;
      *
      *
      //public Transform prefab;

    */

    public Item(int v)
    {
        id = -1;
        selectedType = type.NormalItem;
    }

    public Item(int v, string v1, string v2, Dictionary<string, int> dictionary) : this(v)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.dictionary = dictionary;
    }
}
