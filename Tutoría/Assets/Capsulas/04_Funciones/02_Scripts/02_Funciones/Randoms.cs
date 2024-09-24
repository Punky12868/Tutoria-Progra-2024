using UnityEngine;

public class Randoms : MonoBehaviour
{
    public string nombre1 = "Marco"; // Variables para almacenar nombres
    public string nombre2 = "Andres"; // Variables para almacenar nombres
    public string nombre3 = "Alejandra"; // Variables para almacenar nombres
    public string nombre4 = "Michelle"; // Variables para almacenar nombres

    public void SaludarRandom() // Función que saluda a un nombre aleatorio
    {
        int random = Random.Range(1, 5); // Genera un número aleatorio entre 1 y 4
        string nombre = ""; // Variable para almacenar el nombre aleatorio

        if (random == 1) // Si el número aleatorio es 1
        {
            nombre = nombre1; // Asigna el nombre1 a la variable nombre
        }
        else if (random == 2) // Si el número aleatorio es 2
        {
            nombre = nombre2; // Asigna el nombre2 a la variable nombre
        }
        else if (random == 3) // Si el número aleatorio es 3
        {
            nombre = nombre3; // Asigna el nombre3 a la variable nombre
        }
        else if (random == 4) // Si el número aleatorio es 4
        {
            nombre = nombre4; // Asigna el nombre4 a la variable nombre
        }

        Debug.Log("Hola " + nombre + "!"); // Muestra un mensaje en la consola saludando al nombre aleatorio
    }

    /*
    Básicamente, una función random, es una función que ejecuta una lógica aleatoria.
    En este caso, la función SaludarRandom genera un número aleatorio entre 1 y 4 y asigna un nombre aleatorio a una variable.
    Luego, muestra un mensaje en la consola saludando al nombre aleatorio.
    */
}
