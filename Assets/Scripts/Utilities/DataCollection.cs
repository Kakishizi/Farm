using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ItemDetails
{
    public int itemId;
    public string itemName;
    public ItemType itemType;
    public Sprite itemIcon;
    public Sprite itemOnWorldSprite;
    public string itemDescription;
    public int itemUseRadius;// π”√∑∂Œß
    public bool canPickedup;
    public bool canDropped;
    public bool canCarried;
    public int itemPrice;
    [Range(0f, 1f)]
    public float sellPercentage;
}
