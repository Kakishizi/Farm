using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyFarm.Inventory
{

    public class InventoryManager : Singleton<InventoryManager>
    {
        public ItemDataList_SO ItemDataList_SO;
        /// <summary>
        /// 通过ID返回物品信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ItemDetails GetItemDetails(int ID)
        {
            return ItemDataList_SO.itemDetailsList.Find(i => i.itemId == ID);
        }
        public void AddItem(Item item, bool isDestory)
        {
            Debug.Log(GetItemDetails(item.itemID).itemId+"Name"+ GetItemDetails(item.itemID).itemName);
            if (isDestory)
            {
                Destroy(item.gameObject);
            }
        }
    }
}
