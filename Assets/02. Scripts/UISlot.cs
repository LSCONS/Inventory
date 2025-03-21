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
    /// 아이템 칸에 아이템을 집어넣는 메서드
    /// </summary>
    /// <param name="_item">넣을 아이템</param>
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
