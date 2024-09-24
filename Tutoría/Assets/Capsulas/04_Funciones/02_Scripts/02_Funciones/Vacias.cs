using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacias : MonoBehaviour
{
    public void Saludar() // Funci�n que saluda
    {
        Debug.Log("Hola Mundo!"); // Muestra un mensaje en la consola saludando
    }

    public void SaludarDesdeRetorno() // Funci�n que saluda utilizando una funci�n con retorno
    {
        Debug.Log(FindObjectOfType<Retorno>().Saludar()); // Muestra un mensaje en la consola saludando utilizando la funci�n Saludar de la clase Retorno
    }

    /*
    B�sicamente, una funci�n vac�a, es una funci�n que no recibe par�metros y no retorna ning�n valor.
    En este caso, la funci�n Saludar muestra un mensaje en la consola saludando.
    Y la funci�n SaludarDesdeRetorno muestra un mensaje en la consola saludando utilizando la funci�n Saludar de la clase Retorno.

    Este es el tipo de funci�n m�s com�n, ya que se utiliza para ejecutar l�gica espec�fica sin necesidad de recibir o retornar valores.
    */
}
