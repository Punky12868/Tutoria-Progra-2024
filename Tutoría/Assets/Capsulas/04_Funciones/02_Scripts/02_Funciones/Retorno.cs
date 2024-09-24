using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retorno : MonoBehaviour
{
    public string Saludar() // Función que retorna un string
    {
        return "Hola Chicos!"; // Retorna un string
    }

    /*
    Básicamente, una función con retorno, es un tipo de función que retorna un valor específico.
    En este caso, la función Saludar retorna un string con el mensaje "Hola Mundo!".
    Es decir, la función Saludar es en teoría lo mismo que una variable de tipo string con el valor "Hola Mundo!". (string saludo = "Hola Mundo!")
    Solo que en este caso, al contener la función un return, se puede llamar a la función ejecutando cualquier tipo de lógica dentro de esta misma 
    Y obtener el valor que retorna.
    */
}
