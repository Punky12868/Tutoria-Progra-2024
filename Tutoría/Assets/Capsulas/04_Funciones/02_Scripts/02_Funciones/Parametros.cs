using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parametros : MonoBehaviour
{
    public void Saludar(string nombre) // Funci�n que saluda a un nombre espec�fico
    {
        Debug.Log("Hola " + nombre + "!"); // Muestra un mensaje en la consola saludando al nombre espec�fico
    }

    /*
    B�sicamente, una funci�n con par�metros, es una funci�n que recibe valores espec�ficos.
    En este caso, la funci�n Saludar recibe un par�metro de tipo string llamado nombre.
    Es decir, al llamar a la funci�n Saludar, se debe enviar un valor de tipo string.
    Luego, la funci�n Saludar muestra un mensaje en la consola saludando al nombre espec�fico.
    */
}
