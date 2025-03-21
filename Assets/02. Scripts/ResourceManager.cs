using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : Singleton<ResourceManager>
{
    private ItemData[] datas = Resources.LoadAll<ItemData>("");


    /// <summary>
    /// �������� �����Ϳ��� ���� �ϳ� �����ؼ� ������ �޼���
    /// </summary>
    /// <returns></returns>
    public Item CreateNewItem()
    {
        int rand = Random.Range(0, datas.Length);
        ItemData itemData = datas[rand];

        return new Item(itemData);
    }
}
