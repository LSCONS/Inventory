using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string playerName;
    private string playerInfo;
    private int level;
    private int expCurrent;
    private int expMax;
    private int attack;
    private int defence;
    private int health;
    private int critical;

    private List<Item> inventory;

    public string PlayerName { get => playerName; }
    public string PlayerInfo { get => playerInfo; }
    public int Level { get => level; }
    public int ExpCurrnet { get => expCurrent; }
    public int ExpMax { get => expMax; }
    public int Attack { get => attack; }
    public int Defence { get => defence; }
    public int Health { get => health; }
    public int Critical { get => critical; }
    public List<Item> Inventory { get => inventory; }


    //플레이어의 정보를 초기화하는 메서드
    public void SettingPlayerInfo
        (
            string _playerName, 
            string _playerInfo, 
            int _level, 
            int _expCurrnet, 
            int _expMax,  
            int _attack,
            int _defence,
            int _health,
            int _critical
        )
    {
        playerName = _playerName;
        playerInfo = _playerInfo;
        level = _level;
        expCurrent = _expCurrnet;
        expMax = _expMax;
        attack = _attack;
        defence = _defence;
        health = _health;
        critical = _critical;
    }


    public void AddItem(Item item)
    {
        inventory.Add(item);
    }


    /// <summary>
    /// 장비를 입거나 벗을 경우 능력치를 더하거나 빼는 메서드
    /// </summary>
    /// <param name="item"></param>
    /// <param name="isEquiiped"></param>
    public void TryEquipped(Item item, bool isEquiiped)
    {
        if (isEquiiped)
        {
            attack += item.Data.attack;
            defence += item.Data.defence;
            health += item.Data.health;
            critical += item.Data.critical;
        }
        else
        {
            attack -= item.Data.attack;
            defence -= item.Data.defence;
            health -= item.Data.health;
            critical -= item.Data.critical;
        }

        UIManager.Instance.Status.TextUpdate(this);
    }
}
