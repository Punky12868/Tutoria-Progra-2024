using UnityEngine;

public class ScriptEjemplo : MonoBehaviour
{
    public string nombre = "Diego"; // Variable de tipo string para saludar con retorno

    public Vacias vacias; // Variable de tipo Vacias
    public Retorno retorno; // Variable de tipo Retorno
    public Parametros parametros; // Variable de tipo Parametros
    public Randoms random; // Variable de tipo Random

    public KeyCode teclaFuncionVacia = KeyCode.Q; // Variable de tipo KeyCode para almacenar la tecla que se asignar� a la funci�n vac�a
    public KeyCode teclaFuncionRetorno = KeyCode.W; // Variable de tipo KeyCode para almacenar la tecla que se asignar� a la funci�n de retorno
    public KeyCode teclaFuncionParametros = KeyCode.E; // Variable de tipo KeyCode para almacenar la tecla que se asignar� a la funci�n de par�metros
    public KeyCode teclaFuncionRandom = KeyCode.R; // Variable de tipo KeyCode para almacenar la tecla que se asignar� a la funci�n de random

    private void Start()
    {
        vacias = FindObjectOfType<Vacias>(); // Asigna el componente Vacias que se encuentre en la escena
        retorno = FindObjectOfType<Retorno>(); // Asigna el componente Retorno que se encuentre en la escena
        parametros = FindObjectOfType<Parametros>(); // Asigna el componente Parametros que se encuentre en la escena
        random = FindObjectOfType<Randoms>(); // Asigna el componente Randoms que se encuentre en la escena
    }

    private void Update()
    {
        if (Input.GetKeyDown(teclaFuncionVacia)) // Si se presiona la tecla asignada a la funci�n vac�a
        {
            vacias.Saludar(); // Llama a la funci�n Saludar de la clase Vacias
        }

        if (Input.GetKeyDown(teclaFuncionRetorno)) // Si se presiona la tecla asignada a la funci�n de retorno
        {
            string saludo = retorno.Saludar(); // Declara una variable de tipo string y le asigna el valor que retorna la funci�n Saludar de la clase Retorno
            Debug.Log(saludo); // Muestra en consola el valor de la variable saludo
        }

        if (Input.GetKeyDown(teclaFuncionParametros)) // Si se presiona la tecla asignada a la funci�n de par�metros
        {
            parametros.Saludar(nombre); // Llama a la funci�n Saludar de la clase Parametros y le env�a un string como par�metro
        }

        if (Input.GetKeyDown(teclaFuncionRandom)) // Si se presiona la tecla asignada a la funci�n de random
        {
            random.SaludarRandom(); // Llama a la funci�n Saludar de la clase Randoms
        }
    }

    /*
    Este script es un ejemplo de c�mo llamar a funciones de otras clases.
    */
}
