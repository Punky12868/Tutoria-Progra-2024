using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefab; // Objeto que se instanciar�.
    public Transform parent; // Objeto padre del objeto instanciado.
    public Vector3 position; // Posici�n en la que se instanciar� el objeto.
    public Vector3 rotation; // Rotaci�n con la que se instanciar� el objeto.
    public bool debug; // Variable para mostrar mensajes en la consola.

    /*
    InstantiatePrefabOne() Crea un objeto en una posici�n espec�fica sin rotaci�n ni padre.
    InstantiatePrefabTwo() Crea un objeto en la posici�n de su padre, sin rotaci�n.
    InstantiatePrefabThree() Crea un objeto en la posici�n y rotaci�n de su padre, asign�ndolo como hijo.
    InstantiatePrefabFour() Crea un objeto en una posici�n y rotaci�n espec�ficas, sin un padre.
    InstantiatePrefabFive() Crea un objeto en una posici�n y rotaci�n espec�ficas, asign�ndole un padre.
    */

    public void InstantiatePrefabOne()
    {
        Instantiate(prefab, position, Quaternion.identity); // Instancia el objeto en la posici�n y rotaci�n especificadas.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(1)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabTwo()
    {
        Instantiate(prefab, parent.position, Quaternion.identity); // Instancia el objeto en la posici�n de su padre, sin rotaci�n.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(2)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabThree()
    {
        Instantiate(prefab, parent.position, parent.rotation, parent); // Instancia el objeto en la posici�n y rotaci�n de su padre, asign�ndolo como hijo.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(3)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabFour()
    {
        Instantiate(prefab, position, Quaternion.Euler(rotation), null); // Instancia el objeto en una posici�n y rotaci�n espec�ficas, sin un padre.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(4)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    public void InstantiatePrefabFive()
    {
        Instantiate(prefab, position, Quaternion.Euler(rotation), parent); // Instancia el objeto en una posici�n y rotaci�n espec�ficas, asign�ndole un padre.
        if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(5)); // Esto solo manda el mensaje en la consola si la variable debug es verdadera.
    }

    /*
    if (debug) Message.Log(debug, Color.yellow, Descriptions.InstantiateDescription(1));
    Esta l�nea de c�digo manda un mensaje en la consola si la variable debug es verdadera, con el color amarillo y la descripci�n del m�todo InstantiatePrefabOne.
    El Script Message.cs se encuentra en la carpeta 01_Utilities y contiene m�todos para mostrar mensajes en la consola con diferentes colores.
    Es b�sicamente un Script custom de Debug.Log para mostrar mensajes en la consola con colores.
    */

}
