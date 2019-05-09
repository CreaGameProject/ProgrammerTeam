using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [HideInInspector] public Item item;
    void Start()
    {
        item = new Item();
        item.name = gameObject.name;
        item.cost = Random.Range(0, 100);
        item.pos = transform.position;
    }

    void Update()
    {
        
    }

}

[System.Serializable]
public class Root
{
    [HideInInspector] public List<Item> items;
    public Root()
    {
        items = new List<Item>();
    }
}

[System.Serializable]
public class Item
{
    [HideInInspector] public string name;
    [HideInInspector] public int cost;
    [HideInInspector] public Vector3 pos;
    
}
