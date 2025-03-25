using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button button_Back;
    [SerializeField] private UISlot uiSlot;
    [SerializeField] private Transform uiSlot_Content;

    public List<UISlot> slots = new List<UISlot>();

    private int count_Inventory = 24;

    private void Awake()
    {
        button_Back.onClick.AddListener(ReturnMainMenu);
        for(int i = 0; i < count_Inventory; i++)
        {
            UISlot temp = Instantiate(uiSlot, uiSlot_Content);
            temp.slot_Count = i;
            slots.Add(temp);
        }
    }


    //���� �޴��� ���ư��� �޼���
    private void ReturnMainMenu()
    {
        UIManager.Instance.Menu.OpenMainMenu();
    }


    /// <summary>
    /// �������� ������ ���Կ� �߰��ϴ� �޼���
    /// </summary>
    /// <param name="_item">���� ���� ������</param>
    public void InputItem(Item _item)
    {
        for(int i = 0;i < slots.Count;i++)
        {
            if (slots[i].item == null)
            {
                slots[i].SetItem(_item);
                return;
            }
        }
    }
}
