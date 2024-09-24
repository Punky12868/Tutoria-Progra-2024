using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")] // Se crea un menú para crear un nuevo objeto
public class ItemScriptableObject : ScriptableObject // Se crea una clase Item que hereda de ScriptableObject
{
    public string itemName; // Nombre del objeto
    public Sprite itemSprite; // Imagen del objeto
    public GameObject itemPrefab; // Prefab del objeto
    public bool isConsumable; // Si el objeto es un consumible
    public bool isStackable; // Si el objeto es apilable

    [Header("If Consumable")]
    public int healthAmount; // Cantidad de vida que recupera
}
