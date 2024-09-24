using UnityEngine;

public class ScriptEjemplo : MonoBehaviour
{
    public string nombre = "Diego"; // Variable de tipo string para saludar con retorno

    public Vacias vacias; // Variable de tipo Vacias
    public Retorno retorno; // Variable de tipo Retorno
    public Parametros parametros; // Variable de tipo Parametros
    public Randoms random; // Variable de tipo Random

    public KeyCode teclaFuncionVacia = KeyCode.Q; // Variable de tipo KeyCode para almacenar la tecla que se asignará a la función vacía
    public KeyCode teclaFuncionRetorno = KeyCode.W; // Variable de tipo KeyCode para almacenar la tecla que se asignará a la función de retorno
    public KeyCode teclaFuncionParametros = KeyCode.E; // Variable de tipo KeyCode para almacenar la tecla que se asignará a la función de parámetros
    public KeyCode teclaFuncionRandom = KeyCode.R; // Variable de tipo KeyCode para almacenar la tecla que se asignará a la función de random

    private void Start()
    {
        vacias = FindObjectOfType<Vacias>(); // Asigna el componente Vacias que se encuentre en la escena
        retorno = FindObjectOfType<Retorno>(); // Asigna el componente Retorno que se encuentre en la escena
        parametros = FindObjectOfType<Parametros>(); // Asigna el componente Parametros que se encuentre en la escena
        random = FindObjectOfType<Randoms>(); // Asigna el componente Randoms que se encuentre en la escena
    }

    private void Update()
    {
        if (Input.GetKeyDown(teclaFuncionVacia)) // Si se presiona la tecla asignada a la función vacía
        {
            vacias.Saludar(); // Llama a la función Saludar de la clase Vacias
        }

        if (Input.GetKeyDown(teclaFuncionRetorno)) // Si se presiona la tecla asignada a la función de retorno
        {
            string saludo = retorno.Saludar(); // Declara una variable de tipo string y le asigna el valor que retorna la función Saludar de la clase Retorno
            Debug.Log(saludo); // Muestra en consola el valor de la variable saludo
        }

        if (Input.GetKeyDown(teclaFuncionParametros)) // Si se presiona la tecla asignada a la función de parámetros
        {
            parametros.Saludar(nombre); // Llama a la función Saludar de la clase Parametros y le envía un string como parámetro
        }

        if (Input.GetKeyDown(teclaFuncionRandom)) // Si se presiona la tecla asignada a la función de random
        {
            random.SaludarRandom(); // Llama a la función Saludar de la clase Randoms
        }
    }

    /*
    Este script es un ejemplo de cómo llamar a funciones de otras clases.
    */
}
