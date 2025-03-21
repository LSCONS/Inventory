using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private Character player;
    public Character Player { get =>  player; }

    public GameManager() 
    {
        player = new Character();
    }

    protected override void Awake()
    {
        base.Awake();
        SetData();
    }


    private void SetData()
    {
        player.SettingPlayerInfo
        (
            "Chad",
            "코딩의 노예가 된지 2개월이 되는 송제우... 오늘도 잠을 줄이며 열심히 코딩을 하는 모습이 안타깝네요.",
            10,
            9,
            12,
            35,
            40,
            100,
            25
        );
        UIManager.Instance.Menu.TextUpdate(Player);
        UIManager.Instance.Status.TextUpdate(Player);
    }
}
