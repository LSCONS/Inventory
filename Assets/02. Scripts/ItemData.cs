using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    public int attack;
    public int defence;
    public int health;
    public int critical;
    public Sprite icon;
    public Color colorItem;
}
