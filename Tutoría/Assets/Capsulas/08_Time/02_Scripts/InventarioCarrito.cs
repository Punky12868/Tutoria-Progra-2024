using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioCarrito : MonoBehaviour
{
    [SerializeField] private List<ItemScriptableObject> item = new List<ItemScriptableObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ItemGameObject>().item)
        {
            item.Add(other.GetComponent<ItemGameObject>().item);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ItemGameObject>().item)
        {
            item.Remove(other.GetComponent<ItemGameObject>().item);
        }
    }
}
