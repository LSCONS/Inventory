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
        SetData();
    }


    private void SetData()
    {
        player.SettingPlayerInfo
        (
            "Chad",
            "�ڵ��� �뿹�� ���� 2������ �Ǵ� ������... ���õ� ���� ���̸� ������ �ڵ��� �ϴ� ����� ��Ÿ���׿�.",
            10,
            9,
            12,
            35,
            40,
            100,
            25
        );
    }
}
