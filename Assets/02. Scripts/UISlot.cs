using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VInspector.Libs;

public class UISlot : MonoBehaviour
{
    public int slot_Count = -1;
    public bool isEquipped = false;
    public Item item;
    [SerializeField] private Image Image_Equipped;
    [SerializeField] private Image Image_Icon;


    /// <summary>
    /// ������ ĭ�� �������� ����ִ� �޼���
    /// </summary>
    /// <param name="_item">���� ������</param>
    public void SetItem(Item _item)
    {
        item = _item;
        isEquipped = true;
        Image_Icon.color = item.Data.colorItem;
    }


    private void RefreshUI()
    {

    }
}
