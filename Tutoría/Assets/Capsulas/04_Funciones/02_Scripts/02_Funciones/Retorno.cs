using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retorno : MonoBehaviour
{
    public string Saludar() // Funci�n que retorna un string
    {
        return "Hola Chicos!"; // Retorna un string
    }

    /*
    B�sicamente, una funci�n con retorno, es un tipo de funci�n que retorna un valor espec�fico.
    En este caso, la funci�n Saludar retorna un string con el mensaje "Hola Mundo!".
    Es decir, la funci�n Saludar es en teor�a lo mismo que una variable de tipo string con el valor "Hola Mundo!". (string saludo = "Hola Mundo!")
    Solo que en este caso, al contener la funci�n un return, se puede llamar a la funci�n ejecutando cualquier tipo de l�gica dentro de esta misma 
    Y obtener el valor que retorna.
    */
}
