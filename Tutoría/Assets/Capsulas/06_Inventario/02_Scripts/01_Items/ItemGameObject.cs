using UnityEngine;

public class ItemGameObject : MonoBehaviour
{
    public ItemScriptableObject item; // Se crea una variable de tipo ItemScriptableObject

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Si el objeto colisiona con el jugador
        {
            InventoryListManager inventoryList = FindObjectOfType<InventoryListManager>(); // Se busca el inventario
            InventoryArrayManager inventoryArray = FindObjectOfType<InventoryArrayManager>(); // Se busca el inventario

            if (inventoryList != null) // Si el inventario es diferente de nulo
            {
                inventoryList.AddItem(item); // Se añade el objeto al inventario
            }
            else if (inventoryArray != null) // Si el inventario es diferente de nulo
            {
                inventoryArray.AddItem(item); // Se añade el objeto al inventario
            }

            Destroy(gameObject); // Se destruye el objeto
        }
    }
}
