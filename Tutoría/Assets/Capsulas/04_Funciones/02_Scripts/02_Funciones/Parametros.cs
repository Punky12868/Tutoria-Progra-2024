using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parametros : MonoBehaviour
{
    public void Saludar(string nombre) // Función que saluda a un nombre específico
    {
        Debug.Log("Hola " + nombre + "!"); // Muestra un mensaje en la consola saludando al nombre específico
    }

    /*
    Básicamente, una función con parámetros, es una función que recibe valores específicos.
    En este caso, la función Saludar recibe un parámetro de tipo string llamado nombre.
    Es decir, al llamar a la función Saludar, se debe enviar un valor de tipo string.
    Luego, la función Saludar muestra un mensaje en la consola saludando al nombre específico.
    */
}
