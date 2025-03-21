using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button button_Back;
    [SerializeField] private GameObject uiSlot;
    [SerializeField] private Transform uiSlot_Content;

    private int count_Inventory = 24;

    private void Start()
    {
        button_Back.onClick.AddListener(ReturnMainMenu);
        for(int i = 0; i < count_Inventory; i++)
        {
            GameObject temp = Instantiate(uiSlot, uiSlot_Content);
            temp.GetComponent<UISlot>().slot_Count = i;
        }
    }


    //메인 메뉴로 돌아가는 메서드
    private void ReturnMainMenu()
    {
        UIManager.Instance.Menu.OpenMainMenu();
    }
}
