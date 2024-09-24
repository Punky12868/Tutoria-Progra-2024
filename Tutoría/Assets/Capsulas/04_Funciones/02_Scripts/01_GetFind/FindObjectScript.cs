using UnityEngine;

public class FindObjectScript : MonoBehaviour
{
    public Rigidbody gameObjRb; // Variable para guardar el objeto encontrado
    public bool debug; // Variable para mostrar mensajes en la consola.

    private void Start()
    {
        gameObjRb = FindObjectOfType<Rigidbody>(); // Busca un objeto con el componente Rigidbody dentro de toda la escena y lo guarda en la variable
        Message.Log(debug, Color.green, Descriptions.FindDescription()); // Muestra un mensaje en la consola si la variable debug es verdadera.
    }

    /*
    Básicamente, Find busca un objeto con un componente específico en toda la escena y lo almacena en una variable.
    En este caso, se busca un objeto con el componente Rigidbody y se almacena en la variable gameObjRb.
    */
}
