using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryArrayManager : MonoBehaviour
{
    public Sprite emptySlotSprite;
    public ItemSlotsArray[] itemSlots;

    public void AddItem(ItemScriptableObject item)
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (itemSlots[i].item == item && item.isStackable)
            {
                itemSlots[i].UpdateAmmount(true);
                return;
            }
        }

        for (int i = 0; i < itemSlots.Length; i++)
        {
            if (itemSlots[i].item == null)
            {
                itemSlots[i].SetItem(item);
                return;
            }
        }
    }

    public void RemoveItem(ItemSlotsArray itemSlot)
    {
        itemSlot.UpdateAmmount(false);

        if (itemSlot.amount <= 0)
        {
            itemSlot.item = null;
            itemSlot.itemImage.sprite = emptySlotSprite;
            itemSlot.itemAmount.text = "";
        }
    }
}
