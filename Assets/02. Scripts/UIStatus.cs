using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text_attack;
    [SerializeField] private TextMeshProUGUI text_defence;
    [SerializeField] private TextMeshProUGUI text_health;
    [SerializeField] private TextMeshProUGUI text_critical;

    [SerializeField] private Button button_Back;

    private void Start()
    {
        button_Back.onClick.AddListener(ReturnMainMenu);
    }


    /// <summary>
    /// �÷��̾��� Status�� UI Text�� ������Ʈ�ϴ� �޼���
    /// </summary>
    /// <param name="player">������Ʈ�� �÷��̾��� ����</param>
    public void TextUpdate(Character player)
    {
        text_attack.text = player.Attack.ToString();
        text_defence.text = player.Defence.ToString();
        text_health.text = player.Health.ToString();
        text_critical.text = player.Critical.ToString();
    }


    // �ڷΰ��� ��ư�� ������ ���� �޴��� ���ư��� �޼���
    private void ReturnMainMenu()
    {
        UIManager.Instance.Menu.OpenMainMenu();
    }
}
