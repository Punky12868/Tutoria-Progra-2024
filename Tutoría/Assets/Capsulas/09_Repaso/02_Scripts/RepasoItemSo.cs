using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Repaso SO_Item", menuName = "Repaso/ItemData")]
public class RepasoItemSo : ScriptableObject
{
    public string itemName;
    public int itemPrice;
}
