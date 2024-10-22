using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_Inventory : MonoBehaviour
{
    public List<r_Item> items = new List<r_Item>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<r_Item>())
        {
            items.Add(other.gameObject.GetComponent<r_Item>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<r_Item>())
        {
            items.Remove(other.gameObject.GetComponent<r_Item>());
        }
    }
}
