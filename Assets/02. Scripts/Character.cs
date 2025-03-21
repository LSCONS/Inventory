using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
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

    public string PlayerName { get => playerName; }
    public string PlayerInfo { get => playerInfo; }
    public int ExpCurrnet { get => expCurrent; }
    public int ExpMax { get => expMax; }
    public int Level { get => level; }
    public int Attack { get => attack; }
    public int Defence { get => defence; }
    public int Health { get => health; }
    public int Critical { get => critical; }


}
