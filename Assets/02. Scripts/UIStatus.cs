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
    /// 플레이어의 Status에 UI Text를 업데이트하는 메서드
    /// </summary>
    /// <param name="player">업데이트할 플레이어의 정보</param>
    public void TextUpdate(Character player)
    {
        text_attack.text = player.Attack.ToString();
        text_defence.text = player.Defence.ToString();
        text_health.text = player.Health.ToString();
        text_critical.text = player.Critical.ToString();
    }


    // 뒤로가기 버튼을 눌러서 메인 메뉴로 돌아가는 메서드
    private void ReturnMainMenu()
    {
        UIManager.Instance.Menu.OpenMainMenu();
    }
}
