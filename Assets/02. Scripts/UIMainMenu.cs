using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button button_Status;
    [SerializeField] private Button button_Inventory;

    [SerializeField] private TextMeshProUGUI text_PlayerName;
    [SerializeField] private TextMeshProUGUI text_Level; 
    [SerializeField] private TextMeshProUGUI text_Exp;
    [SerializeField] private TextMeshProUGUI text_PlayerInfo;

    [SerializeField] private Image image_FillAmount;

    [SerializeField] private RectTransform rect_HorizontalLayout;

    private void Start()
    {
        button_Status.onClick.AddListener(OpenStatus);
        button_Inventory.onClick.AddListener(OpenInventory);
        OpenMainMenu();
    }


    //메인 메뉴를 활성화할 때 사용하는 메서드
    public void OpenMainMenu()
    {
        button_Status.gameObject.SetActive(true);
        button_Inventory.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }


    //스테이터스를 활성화할 때 사용하는 메서드
    private void OpenStatus()
    {
        UIManager.Instance.Status.gameObject.SetActive(true);
        button_Status.gameObject.SetActive(false);
        button_Inventory.gameObject.SetActive(false);
    }


    //인벤토리를 활성화할 때 사용하는 메서드
    private void OpenInventory()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        button_Status.gameObject.SetActive(false);
        button_Inventory.gameObject.SetActive(false);
    }


    public void TextUpdate(Character player)
    {
        text_PlayerName.text = player.PlayerName;
        text_PlayerInfo.text = player.PlayerInfo;
        text_Level.text = player.Level.ToString();
        text_Exp.text = $"{player.ExpCurrnet} / {player.ExpMax}";
        image_FillAmount.fillAmount = (float)player.ExpCurrnet / player.ExpMax;
    }
}
