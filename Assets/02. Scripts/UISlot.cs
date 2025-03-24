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

    [SerializeField] private Button button_UIslot;

    private void Awake()
    {
        button_UIslot.onClick.AddListener(TryEquippedItem);
        Image_Equipped.gameObject.SetActive(isEquipped);
    }


    //�������� ��� �԰� ���� �� ����ϴ� �޼���
    private void TryEquippedItem()
    {
        if (item != null)
        {
            isEquipped = !isEquipped;
            Image_Equipped.gameObject.SetActive(isEquipped);
            GameManager.Instance.Player.TryEquipped(item, isEquipped);
        }
    }


    /// <summary>
    /// ������ ĭ�� �������� ����ִ� �޼���
    /// </summary>
    /// <param name="_item">���� ������</param>
    public void SetItem(Item _item)
    {
        item = _item;
        Image_Icon.color = item.Data.colorItem;
    }


    private void RefreshUI()
    {

    }
}
