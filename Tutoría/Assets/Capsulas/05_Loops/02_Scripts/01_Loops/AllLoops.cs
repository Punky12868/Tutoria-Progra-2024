using System.Collections.Generic;
using UnityEngine;

public class AllLoops : MonoBehaviour
{
    public int numerosDePrueba; // Variable para almacenar el número de pruebas
    int i; // Variable para almacenar el número de pruebas

    public GameObject[] arrayDePrueba; // Array de GameObjects para almacenar los objetos de prueba

    public List<GameObject> listaDePrueba = new List<GameObject>(); // Lista de GameObjects para almacenar los objetos de prueba

    [SerializeField] TMPro.TMP_Text textoEjemplo; // Texto para mostrar los resultados

    public bool usandoNumeros; // Variable para saber si se usan números

    public bool usandoArray; // Variable para saber si se usa un array

    public bool usandoLista; // Variable para saber si se usa una lista
    private void Awake()
    {
        /*foreach (GameObject nombre in arrayDePrueba) // Por Cada (GameObject "nombre" dentrode arrayDePrueba)
        {
            textoEjemplo.text += "Foreach Loop Array" + "\n" + "\n";
        }*/
    }

    public void ForLoop() // Método para el bucle For
    {
        if (usandoNumeros)
        {
            for (int i = 0; i < numerosDePrueba; i++)
            {
                textoEjemplo.text += "ForLoop Numero" + i + "\n" + "\n";
            }
        }
        else if (usandoArray) // Si se está usando un array
        {
            for (int i = 0; i < arrayDePrueba.Length; i++)
            {
                textoEjemplo.text += "ForLoop Array" + i + "\n" + "\n";
            }
        }
        else if (usandoLista) // Si se está usando una lista
        {
            for (int i = 0; i < listaDePrueba.Count; i++)
            {
                textoEjemplo.text += "ForLoop Lista" + i + "\n" + "\n";
            }
        }
        
    }
    public void ForeachLoop() // Método para el bucle Foreach
    {
        if (usandoArray) // Si se está usando un array
        {
            foreach (GameObject gameObject in arrayDePrueba)
            {
                textoEjemplo.text += "Foreach Loop Array" + "\n" + "\n";
            }
        }
        else if (usandoLista) // Si se está usando una lista
        {
            foreach (GameObject gameObject in listaDePrueba)
            {
                textoEjemplo.text += "Foreach Loop Lista" + "\n" + "\n";
            }
        }
    }
    public void WhileLoop() // Método para el bucle While
    {
        while (i < numerosDePrueba)
        {
            i++;
            textoEjemplo.text += "While Loop" + i + "\n" + "\n";
        }
    }

    public void RestarScene() // Método para reiniciar la escena
    {
        textoEjemplo.text = "";
        i = 0;
    }

    /*
     * Explicación de los bucles:
     * 
     * El For Loop es un bucle que se ejecuta un número determinado de veces. Se utiliza cuando se sabe cuántas veces se va a ejecutar el bucle.
     * La estructura de un bucle For es la siguiente: for (inicialización; condición; incremento) { código a ejecutar }
     * for (int i = 0; i < 10; i++) { código a ejecutar } En este caso, el bucle se ejecutará 10 veces.
     * 
     * El Foreach Loop es un bucle que se utiliza para recorrer arrays y listas. Se utiliza cuando se quiere recorrer todos los elementos de un array o una lista.
     * La estructura de un bucle Foreach es la siguiente: foreach (tipoDeDato nombre in arrayOLista) { código a ejecutar }
     * foreach (GameObject nombre in arrayDePrueba) { código a ejecutar } En este caso, el bucle recorrerá todos los elementos del array arrayDePrueba.
     * 
     * El While Loop es un bucle que se ejecuta mientras se cumpla una condición. Se utiliza cuando no se sabe cuántas veces se va a ejecutar el bucle.
     * La estructura de un bucle While es la siguiente: while (condición) { código a ejecutar }
     * while (i < 10) { código a ejecutar } En este caso, el bucle se ejecutará mientras la variable i sea menor que 10.
     * 
    */
}
