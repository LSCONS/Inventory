using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private UIMainMenu menu;
    [SerializeField] private UIInventory inventory;
    [SerializeField] private UIStatus status;

    public UIMainMenu Menu { get => menu; }
    public UIInventory Inventory { get => inventory; } 
    public UIStatus Status { get => status; }
}
