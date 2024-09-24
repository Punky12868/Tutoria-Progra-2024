using UnityEngine;

public class OpenCloseInventory : MonoBehaviour
{
    public void OpenClose(GameObject inv)
    {
        inv.SetActive(!inv.activeSelf);
    }
}
