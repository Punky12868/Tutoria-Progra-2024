using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ItemSlotsArray : MonoBehaviour
{
    public ItemScriptableObject item;
    public Image itemImage;
    public TMP_Text itemAmount;
    public int amount;

    public void SetItem(ItemScriptableObject newItem)
    {
        item = newItem;
        itemImage.sprite = item.itemSprite;

        if (newItem.isStackable)
        {
            itemAmount.text = "1";
        }
        else
        {
            itemAmount.text = "";
        }
    }

    public void UseItem()
    {
        if (item != null)
        {
            FindObjectOfType<InventoryArrayManager>().RemoveItem(this);
        }
    }

    public void UpdateAmmount(bool value)
    {
        if (item.isStackable)
        {
            if (value)
            {
                amount++;
            }
            else
            {
                amount--;
            }

            itemAmount.text = amount.ToString();
        }
    }
}
