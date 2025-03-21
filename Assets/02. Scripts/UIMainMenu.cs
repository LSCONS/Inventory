using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{

    private void Start()
    {
        
    }


    //���� �޴��� Ȱ��ȭ�� �� ����ϴ� �޼���
    private void OpenMainMenu()
    {
        UIManager.Instance.Menu.gameObject.SetActive(true);
    }


    //�������ͽ��� Ȱ��ȭ�� �� ����ϴ� �޼���
    private void OpenStatus()
    {
        UIManager.Instance.Status.gameObject.SetActive(true);
    }


    //�κ��丮�� Ȱ��ȭ�� �� ����ϴ� �޼���
    private void OpenInventory()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }
}
