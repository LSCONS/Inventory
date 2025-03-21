using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{

    private void Start()
    {
        
    }


    //메인 메뉴를 활성화할 때 사용하는 메서드
    private void OpenMainMenu()
    {
        UIManager.Instance.Menu.gameObject.SetActive(true);
    }


    //스테이터스를 활성화할 때 사용하는 메서드
    private void OpenStatus()
    {
        UIManager.Instance.Status.gameObject.SetActive(true);
    }


    //인벤토리를 활성화할 때 사용하는 메서드
    private void OpenInventory()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }
}
