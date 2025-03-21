using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : Singleton<ResourceManager>
{
    private ItemData[] datas = Resources.LoadAll<ItemData>("");


    /// <summary>
    /// 아이템을 데이터에서 새로 하나 생성해서 가져올 메서드
    /// </summary>
    /// <returns></returns>
    public Item CreateNewItem()
    {
        int rand = Random.Range(0, datas.Length);
        ItemData itemData = datas[rand];

        return new Item(itemData);
    }
}
