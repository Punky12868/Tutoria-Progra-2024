using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "r_NewItem", menuName = "Post Super/New Item", order = 0)]
public class r_ItemDataSo : ScriptableObject
{
    public string itemName;
    public int itemPrice;
}
