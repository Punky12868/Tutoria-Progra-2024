using UnityEngine;

public class InstantiateListsEx : MonoBehaviour
{
    [SerializeField] Transform spawnerArrayItem;
    [SerializeField] Transform spawnerListItem;

    public GameObject arrayItem;
    public GameObject listItem;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(arrayItem, spawnerArrayItem.position, spawnerArrayItem.rotation);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(listItem, spawnerListItem.position, spawnerListItem.rotation);

        }
    }

    // Script que se utiliza para instanciar objetos para la lista y el array
}
