using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class InventoryListButton : MonoBehaviour
{
    public ItemScriptableObject item;
    public Image itemSprite;
    public TMP_Text itemName;
    public TMP_Text itemAmount;

    public void SetItem(ItemScriptableObject newItem)
    {
        item = newItem;
        itemSprite.sprite = newItem.itemSprite;
        itemName.text = item.itemName;
    }

    public void UseItem()
    {
        FindObjectOfType<InventoryListManager>().RemoveItem(item);
    }

    public void DropItem()
    {
        FindObjectOfType<InventoryListManager>().RemoveItem(item);
    }

    public void UpdateAmount(int amount)
    {
        itemAmount.text = amount.ToString();
    }
}
