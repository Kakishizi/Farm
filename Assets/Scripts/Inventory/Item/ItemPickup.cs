using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFarm.Inventory
{
    public class ItemPickup : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            Item item=col.GetComponent<Item>();
            if (item != null)
            {
                if (item.itemDetails.canPickedup)
                {
                    InventoryManager.Instance.AddItem(item,true);
                }
            }
        }
    }
}