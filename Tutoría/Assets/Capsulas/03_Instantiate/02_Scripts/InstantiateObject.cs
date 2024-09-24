using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefab; // Objeto que se instanciará.
    public Transform parent; // Objeto padre del objeto instanciado.
    public Vector3 position; // Posición en la que se instanciará el objeto.
    public Vector3 rotation; // Rotación con la que se instanciará el objeto.
    public bool debug; // Variable para mostrar mensajes en la consola.

    /*
    InstantiatePrefabOne() Crea un objeto en una posición específica sin rotación ni padre.
    InstantiatePrefabTwo() Crea un objeto en la posición de su padre, sin rotación.
    InstantiatePrefabThree() Crea un objeto en la posición y rotación de su padre, asignándolo como hijo.
    InstantiatePrefabFour() Crea un objeto en una posición y rotación específicas, sin un padre.
    InstantiatePrefabFive() Crea un objeto en una posición y rotación específicas, asignándole un padre.
    */

    public void InstantiatePrefabOne()
    {
        Instantiate(prefab, position, Quaternion.identity); // Instancia el objeto en la posición y rotación especificadas.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(1)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabTwo()
    {
        Instantiate(prefab, parent.position, Quaternion.identity); // Instancia el objeto en la posición de su padre, sin rotación.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(2)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabThree()
    {
        Instantiate(prefab, parent.position, parent.rotation, parent); // Instancia el objeto en la posición y rotación de su padre, asignándolo como hijo.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(3)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabFour()
    {
        Instantiate(prefab, position, Quaternion.Euler(rotation), null); // Instancia el objeto en una posición y rotación específicas, sin un padre.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(4)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabFive()
    {
        Instantiate(prefab, position, Quaternion.Euler(rotation), parent); // Instancia el objeto en una posición y rotación específicas, asignándole un padre.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(5)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    /*
    if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(1));
    Esta línea de código manda un mensaje en la consola si la variable debug es verdadera, con el color amarillo y la descripción del método InstantiatePrefabOne.
    El Script Message.cs se encuentra en la carpeta 01_Utilities y contiene métodos para mostrar mensajes en la consola con diferentes colores.
    Es básicamente un Script custom de Debug.Log para mostrar mensajes en la consola con colores.
    */

}
