using System.Collections;
using UnityEngine;
using TMPro;

public class r_Boleta : MonoBehaviour
{
    [SerializeField] private r_Inventory inv;

    [SerializeField] private float sec;
    [SerializeField] private GameObject boletaPanel;
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text itemPrice;
    [SerializeField] private TMP_Text total;
    [SerializeField] private int plataMano;
    private int totalPrice = 0;

    private bool paid;
    private bool canPay;

    private void Start()
    {
        boletaPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inv.items.Count > 0 && !paid)
        {
            for (int i = 0; i < inv.items.Count; i++)
            {
                totalPrice += inv.items[i]._data.itemPrice;

                if (totalPrice > plataMano)
                {
                    Debug.LogError("NO HAY PLATA");
                    totalPrice = 0;
                    canPay = false;
                    break;
                }

                canPay = true;
            }

            if (canPay)
            {
                StartCoroutine(PagarCorrutina());
            }
        }
    }

    public void Pagar()
    {
        for (int i = 0; i < inv.items.Count; i++)
        {
            itemName.text += inv.items[i]._data.itemName + "\n";
            itemPrice.text += inv.items[i]._data.itemPrice + "\n";
            totalPrice += inv.items[i]._data.itemPrice;
        }
        total.text += totalPrice.ToString();

        boletaPanel.SetActive(true);
    }

    IEnumerator PagarCorrutina()
    {
        totalPrice = 0;
        paid = true;
        boletaPanel.SetActive(true);

        for (int i = 0; i < inv.items.Count; i++)
        {
            itemName.text += inv.items[i]._data.itemName + "\n";
            itemPrice.text += inv.items[i]._data.itemPrice + "\n";
            totalPrice += inv.items[i]._data.itemPrice;
            total.text = "TOTAL: " + totalPrice.ToString();

            yield return new WaitForSeconds(sec);
        }
    }
}
