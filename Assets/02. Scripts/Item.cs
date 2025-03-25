using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private ItemData data;
    public ItemData Data { get => data; }
     
    public Item(ItemData _data)
    {
        data = _data;
    }
}
