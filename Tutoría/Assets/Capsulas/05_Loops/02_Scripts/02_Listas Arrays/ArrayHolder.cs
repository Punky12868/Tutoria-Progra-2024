using UnityEngine;

public class ArrayHolder : MonoBehaviour
{
    public bool getObjectsOnAwake; // Esta variable se utiliza para obtener los objetos en el array en el Awake
    public GameObject[] objectsOnArray; // Este es el array que contendrá los objetos
    private void Awake() // Este método se ejecuta antes de que se ejecute el Start
    {
        if (getObjectsOnAwake) // Si la variable getObjectsOnAwake es verdadera
        {
            objectsOnArray = GameObject.FindGameObjectsWithTag("array"); // Se obtienen los objetos con el tag "array"

            for (int i = 0; i < objectsOnArray.Length; i++) // Se recorre el array de objetos
            {
                Destroy(objectsOnArray[i].gameObject); // Se destruyen los objetos
                objectsOnArray[i] = FindObjectOfType<InstantiateListsEx>().arrayItem; // Se asignan los objetos del array de la clase InstantiateListsEx
            }
        }
    }
    private void OnTriggerEnter(Collider other) // Este método se ejecuta cuando un objeto entra en el trigger
    {
        if (other.gameObject.CompareTag("array")) // Si el objeto tiene el tag "array"
        {
            for (int i = 0; i < objectsOnArray.Length; i++) // Se recorre el array de objetos
            {
                if (objectsOnArray[i] == null) // Si el objeto en la posición i es nulo
                {
                    objectsOnArray[i] = FindObjectOfType<InstantiateListsEx>().arrayItem; // Se asigna el objeto de la clase InstantiateListsEx
                    Destroy(other.gameObject); // Se destruye el objeto

                    break; // Se sale del bucle
                }
            }
        }
    }
}
