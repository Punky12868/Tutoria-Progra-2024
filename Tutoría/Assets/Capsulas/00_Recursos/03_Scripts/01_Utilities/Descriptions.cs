public abstract class Descriptions
{
    public static string InstantiateDescription(int i)
    {
        if (i == 1) return "Se instancia un prefab en una posición dada (position), sin rotación específica (usamos Quaternion.identity,\n que significa \"sin rotación\") y sin objeto padre. Esto crea el objeto en el espacio global de la escena.";
        if (i == 2) return "El prefab se instancia en la misma posición que el parent (el objeto padre) utilizando las coordenadas de su\n Transform. No hay rotación aplicada (se usa Quaternion.identity). Este método es útil cuando quieres colocar un objeto en la misma posición que su padre pero sin que herede su rotación.";
        if (i == 3) return "Se instancia el prefab en la misma posición y rotación que el parent, y también se le asigna como padre. Esto\n significa que el prefab se moverá junto con el padre si este se mueve. Este es un caso común cuando se quieren crear objetos que estén \"anclados\" a otros en la jerarquía de objetos de la escena.";
        if (i == 4) return "Aquí se usa un Vector3 específico para colocar el prefab en las coordenadas especificadas en el script y se le\n asigna una rotación asignada en el script usando Quaternion.Euler. No se le asigna ningún objeto padre, por lo que se creará en la raíz de la escena.";
        if (i == 5) return "Aquí se instancia el prefab en las coordenadas especificadas en el script con una rotación asignada en el script.\n Además, se le asigna un objeto parent, lo que significa que el prefab se convertirá en un hijo del padre especificado, moviéndose y rotando junto con él en el futuro.";
        else return "No se ha encontrado una descripción para el método InstantiatePrefab.";
    }

    public static string GetComponentDescription()
    {
        return "Se obtiene un componente en específico del objeto al que se le asigna el Script. Este método es útil cuando se necesita\n acceder a un componente específico de un objeto en tiempo de ejecución.";
    }

    public static string FindDescription()
    {
        return "Busca un objeto con un componente específico en toda la escena y lo almacena en una variable. Este método es útil\n cuando se necesita acceder a un objeto específico en tiempo de ejecución.";
    }
}
