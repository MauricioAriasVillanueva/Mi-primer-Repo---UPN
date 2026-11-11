public static class Calculos
{
    /// <summary>
    /// Calcula el promedio de un arreglo de notas.
    /// </summary>
    /// <param name="notas">
    /// El arreglo de notas del cual se desea calcular el promedio.
    /// </param>
    /// <returns>
    /// El promedio de las notas.
    /// </returns>

    public static double CalcularPromedio(double[] notas)
    {
        double suma = 0;

        foreach (double nota in notas)
        {
            suma += nota;
        }

        return suma / notas.Length;
    }

    /// <summary>
    /// Verifica si un arreglo de notas es válido.
    /// </summary>
    /// <param name="notas">
    /// El arreglo de notas a verificar.
    /// </param>
    /// <returns>
    /// true si las notas son válidas, false en caso contrario.
    /// </returns>
    public static bool NotasValidas(double[] notas)
    {
        if (notas == null || notas.Length == 0)
        {
            return false;
        }

        foreach (double nota in notas)
        {
            if (nota < 0 || nota > 20)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Determina la condición de un estudiante según su promedio.
    /// </summary>
    /// <param name="promedio">
    /// El promedio del estudiante.
    /// </param>
    /// <returns>
    /// "Aprobado" si el promedio es mayor o igual a 13, "Reprobado" en caso contrario.
    /// </returns>

    public static string DeterminarCondicion(double promedio)
    {
        if (promedio >= 13)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }
    }

    /// <summary>
    /// Obtiene la nota máxima de un arreglo de notas.
    /// </summary>
    /// <param name="notas">
    /// El arreglo de notas del cual se desea obtener la nota máxima.
    /// </param>
    /// <returns>
    /// La nota máxima del arreglo.
    /// </returns>

    public static double ObtenerNotaMaxima(double[] notas)
    {
        double notaMaxima = notas[0];

        foreach (double nota in notas)
        {
            if (nota > notaMaxima)
            {
                notaMaxima = nota;
            }
        }

        return notaMaxima;
    }
}