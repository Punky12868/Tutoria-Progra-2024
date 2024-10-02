using System.Collections.Generic;
using UnityEngine;

public class ListHolder : MonoBehaviour
{
    public List<GameObject> gameObjectsOnList = new List<GameObject>(); // Esta es la lista que contendrá los objetos

    private void OnTriggerEnter(Collider other) // Este método se ejecuta cuando un objeto entra en el trigger
    {
        if (other.gameObject.CompareTag("list")) // Si el objeto tiene el tag "list"
        {
            gameObjectsOnList.Add(FindObjectOfType<InstantiateListsEx>().listItem); // Se añade el objeto de la clase InstantiateListsEx a la lista
            //Destroy(other.gameObject); // Se destruye el objeto
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) // Si se pulsa la tecla O
        {
            gameObjectsOnList.Clear(); // Se limpia la lista
        }

        if (Input.GetKeyDown(KeyCode.L)) // Si se pulsa la tecla L
        {
            if (gameObjectsOnList.Count > 0) // Si hay objetos en la lista
            {
                Debug.Log(gameObjectsOnList.Count - 1); // Se muestra el último objeto de la lista
                gameObjectsOnList.RemoveAt(gameObjectsOnList.Count - 1); // Se elimina el último objeto de la lista
            }
            else
            {
                Debug.Log("No objects on this list"); // Si no hay objetos en la lista se muestra un mensaje
            }
        }
    }
}
