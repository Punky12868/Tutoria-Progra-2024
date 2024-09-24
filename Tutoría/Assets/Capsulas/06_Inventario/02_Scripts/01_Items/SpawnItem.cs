using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public void InstantiateItem(GameObject item)
    {
        GameObject newItem = Instantiate(item, transform.position, Quaternion.identity);
    }
}
