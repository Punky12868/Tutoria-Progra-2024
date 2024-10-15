using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RepasoListasArray : MonoBehaviour
{
    public List<RepasoItem> items = new List<RepasoItem>();

    public TMP_Text nombresItems;
    public TMP_Text preciosItems;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Datos();
        }
    }

    public void Datos()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log("ITEM: " + items[i]._data.itemName + ", PRICE: " + items[i]._data.itemPrice);

            //   "\n" Salto de linea

            nombresItems.text += items[i]._data.itemName + "\n";
            preciosItems.text += items[i]._data.itemPrice + "\n";
        }
    }
}
