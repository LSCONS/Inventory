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

    private void Start()
    {
        button_Status.onClick.AddListener(OpenStatus);
        button_Inventory.onClick.AddListener(OpenInventory);
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


    public void TextUpdate(Character player)
    {
        text_PlayerName.text = player.PlayerName;
        text_PlayerInfo.text = player.PlayerInfo;
        text_Level.text = player.Level.ToString();
        text_Exp.text = $"{player.ExpCurrnet} / {player.ExpMax}";
        image_FillAmount.fillAmount = (float)player.ExpCurrnet / player.ExpMax;
    }
}
