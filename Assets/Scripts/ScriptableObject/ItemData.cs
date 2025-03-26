using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item Data", menuName = "Item Data")]
public class ItemData : ScriptableObject
{
    [SerializeField] private string itemName;
    public string ItemName { get { return itemName; } }

    [SerializeField] private int increaseHealth;
    public int IncreaseHealth { get { return increaseHealth; } }

    [SerializeField] private int increaseAtk;
    public int IncreaseAtk { get { return increaseAtk; } }

    [SerializeField] private int increaseDef;
    public int IncreaseDef { get { return increaseDef; } }

    [SerializeField] private int increaseCrit;
    public int IncreaseCrit { get { return increaseCrit; } }

    [SerializeField] private Sprite iconSprite;
    public Sprite IconSprite { get { return iconSprite; } }
}
