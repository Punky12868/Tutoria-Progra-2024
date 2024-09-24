public abstract class Descriptions
{
    public static string InstantiateDescription(int i)
    {
        if (i == 1) return "Se instancia un prefab en una posici�n dada (position), sin rotaci�n espec�fica (usamos Quaternion.identity,\n que significa \"sin rotaci�n\") y sin objeto padre. Esto crea el objeto en el espacio global de la escena.";
        if (i == 2) return "El prefab se instancia en la misma posici�n que el parent (el objeto padre) utilizando las coordenadas de su\n Transform. No hay rotaci�n aplicada (se usa Quaternion.identity). Este m�todo es �til cuando quieres colocar un objeto en la misma posici�n que su padre pero sin que herede su rotaci�n.";
        if (i == 3) return "Se instancia el prefab en la misma posici�n y rotaci�n que el parent, y tambi�n se le asigna como padre. Esto\n significa que el prefab se mover� junto con el padre si este se mueve. Este es un caso com�n cuando se quieren crear objetos que est�n \"anclados\" a otros en la jerarqu�a de objetos de la escena.";
        if (i == 4) return "Aqu� se usa un Vector3 espec�fico para colocar el prefab en las coordenadas especificadas en el script y se le\n asigna una rotaci�n asignada en el script usando Quaternion.Euler. No se le asigna ning�n objeto padre, por lo que se crear� en la ra�z de la escena.";
        if (i == 5) return "Aqu� se instancia el prefab en las coordenadas especificadas en el script con una rotaci�n asignada en el script.\n Adem�s, se le asigna un objeto parent, lo que significa que el prefab se convertir� en un hijo del padre especificado, movi�ndose y rotando junto con �l en el futuro.";
        else return "No se ha encontrado una descripci�n para el m�todo InstantiatePrefab.";
    }

    public static string GetComponentDescription()
    {
        return "Se obtiene un componente en espec�fico del objeto al que se le asigna el Script. Este m�todo es �til cuando se necesita\n acceder a un componente espec�fico de un objeto en tiempo de ejecuci�n.";
    }

    public static string FindDescription()
    {
        return "Busca un objeto con un componente espec�fico en toda la escena y lo almacena en una variable. Este m�todo es �til\n cuando se necesita acceder a un objeto espec�fico en tiempo de ejecuci�n.";
    }
}
