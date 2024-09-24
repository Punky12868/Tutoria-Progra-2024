using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryListManager : MonoBehaviour
{
    public GameObject inventoryItemPanel;
    public Transform inventoryItemParent;

    public List<ItemListHolder> pickedItems = new List<ItemListHolder>();

    public void AddItem(ItemScriptableObject item)
    {
        if (item.isStackable)
        {
            foreach (ItemListHolder itemHolder in pickedItems)
            {
                if (itemHolder.item == item)
                {
                    itemHolder.amount++;
                    itemHolder.inventoryListButton.UpdateAmount(itemHolder.amount);
                    return;
                }
            }
        }

        pickedItems.Add(new ItemListHolder { amount = 1, item = item });
        AddItemButton(item, pickedItems[pickedItems.Count - 1]);
    }

    public void RemoveItem(ItemScriptableObject item)
    {
        foreach (ItemListHolder itemHolder in pickedItems)
        {
            if (itemHolder.item == item)
            {
                itemHolder.amount--;
                itemHolder.inventoryListButton.UpdateAmount(itemHolder.amount);

                if (itemHolder.amount <= 0)
                {
                    Destroy(itemHolder.inventoryListButton.gameObject);
                    pickedItems.Remove(itemHolder);
                }
                return;
            }
        }
    }

    public void AddItemButton(ItemScriptableObject item, ItemListHolder holder)
    {
        GameObject newItem = Instantiate(inventoryItemPanel, inventoryItemParent);
        holder.inventoryListButton = newItem.GetComponent<InventoryListButton>();
        newItem.GetComponent<InventoryListButton>().SetItem(item);
    }
}

[Serializable]
public class ItemListHolder
{
    public ItemScriptableObject item;
    public InventoryListButton inventoryListButton;
    public int amount;
}
