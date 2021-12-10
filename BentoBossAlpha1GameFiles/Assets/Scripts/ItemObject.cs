using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject
{
    public string title;
    public string description;
    public int id;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    private int v1;
    private string v2;
    private string v3;
    private Dictionary<string, int> dictionary;

    public ItemObject(int id, string title, string description, Sprite icon, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Resources/UnityStoreAssets/FREEFoodPack/Prefabs/" + title);
        this.stats = stats;
    }

    public ItemObject(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Resources/UnityStoreAssets/FREEFoodPack/Prefabs/" + item.title);
        this.stats = item.stats;
    }

    public ItemObject(int v1, string v2, string v3, Dictionary<string, int> dictionary)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.dictionary = dictionary;
    }
}
