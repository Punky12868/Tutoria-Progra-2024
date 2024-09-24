using UnityEngine;

public class GetObjectScript : MonoBehaviour
{
    public Rigidbody Rigidbody; // Variable para almacenar el componente Rigidbody.
    public bool debug; // Variable para mostrar mensajes en la consola.

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>(); // Obtiene el componente Rigidbody del objeto.
        Message.Log(debug, Color.green, Descriptions.GetComponentDescription()); // Muestra un mensaje en la consola si la variable debug es verdadera.
    }

    /*
    Básicamente, GetComponent busca cualquier componente que queramos obtener DENTRO del objeto al que se le asigna el Script.
    En este caso, se obtiene el componente Rigidbody y se almacena en la variable Rigidbody.
    */
}
