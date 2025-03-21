using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]private Button button_Back;

    private void Start()
    {
        button_Back.onClick.AddListener(ReturnMainMenu);
    }


    //���� �޴��� ���ư��� �޼���
    private void ReturnMainMenu()
    {
        UIManager.Instance.Menu.OpenMainMenu();
    }
}
