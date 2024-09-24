using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacias : MonoBehaviour
{
    public void Saludar() // Función que saluda
    {
        Debug.Log("Hola Mundo!"); // Muestra un mensaje en la consola saludando
    }

    public void SaludarDesdeRetorno() // Función que saluda utilizando una función con retorno
    {
        Debug.Log(FindObjectOfType<Retorno>().Saludar()); // Muestra un mensaje en la consola saludando utilizando la función Saludar de la clase Retorno
    }

    /*
    Básicamente, una función vacía, es una función que no recibe parámetros y no retorna ningún valor.
    En este caso, la función Saludar muestra un mensaje en la consola saludando.
    Y la función SaludarDesdeRetorno muestra un mensaje en la consola saludando utilizando la función Saludar de la clase Retorno.

    Este es el tipo de función más común, ya que se utiliza para ejecutar lógica específica sin necesidad de recibir o retornar valores.
    */
}
