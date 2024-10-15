using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class RepasoRaycast : MonoBehaviour
{
    public GameObject panelItemData;
    public TMP_Text itemName;
    public TMP_Text itemPrice;

    public LayerMask itemLayer;
    public float rayLength;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayLength, itemLayer))
        {
            if (hit.transform.GetComponent<RepasoItem>())
            {
                RepasoItem itemScript = hit.transform.GetComponent<RepasoItem>();
                itemName.text = itemScript._data.itemName;
                itemPrice.text = itemScript._data.itemPrice.ToString();
                panelItemData.SetActive(true);
            }
        }
        else if (panelItemData.activeInHierarchy)
        {
            panelItemData.SetActive(false);
            itemName.text = "";
            itemPrice.text = "";
        }
    }
}
