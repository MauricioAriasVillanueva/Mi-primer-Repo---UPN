using System;

class Program
{
    static void Main()
    {
    double[] GrupoA = { 12, 15, 18, 20, 17 };
    double[] GrupoB = { 13 };
    double[] GrupoC = { 12.99 };
    double[] GrupoD = { };
    double[] GrupoE = { 12, 15, 18, 20, 21 }; // Nota inválida
    double[] notasTurnoNoche = { 14, 13, 18, 16, 15 };
    double raiz = Math.Sqrt(81);
    Console.WriteLine($"La raíz cuadrada es: {raiz}");

    ProcesarGrupo("Grupo A", GrupoA);
    ProcesarGrupo("Grupo B", GrupoB);
    ProcesarGrupo("Grupo C", GrupoC);
    ProcesarGrupo("Grupo D", GrupoD);
    ProcesarGrupo("Grupo E", GrupoE);
    ProcesarGrupo("Turno noche", notasTurnoNoche);
    }

    static void ProcesarGrupo(string nombreGrupo, double[] notas)
    {
        if (Calculos.NotasValidas(notas))
        {
            double promedio = Calculos.CalcularPromedio(notas);
            string condicion = Calculos.DeterminarCondicion(promedio);
            double notaMaxima = Calculos.ObtenerNotaMaxima(notas);
            Console.WriteLine($"{nombreGrupo}: {promedio:F2} - {condicion} - Nota máxima: {notaMaxima:F2}");
        }
        else
        {
            Console.WriteLine($"{nombreGrupo}: tiene notas inválidas.");
        }
    }
}

/*
        if (Calculos.NotasValidas(GrupoA))
        {
            double promedioA = Calculos.CalcularPromedio(GrupoA);
            string condicionA = Calculos.DeterminarCondicion(promedioA);
            double notaMaximaA = Calculos.ObtenerNotaMaxima(GrupoA);
            Console.WriteLine($"Grupo A: {promedioA:F2} - {condicionA} - Nota máxima: {notaMaximaA:F2}");
        }
        else
        {
            Console.WriteLine("Grupo A tiene notas inválidas.");
        }

        if (Calculos.NotasValidas(GrupoB))
        {
            double promedioB = Calculos.CalcularPromedio(GrupoB);
            string condicionB = Calculos.DeterminarCondicion(promedioB);
            double notaMaximaB = Calculos.ObtenerNotaMaxima(GrupoB);
            Console.WriteLine($"Grupo B: {promedioB:F2} - {condicionB} - Nota máxima: {notaMaximaB:F2}");
        }
        else
        {
            Console.WriteLine("Grupo B tiene notas inválidas.");
        }

        if (Calculos.NotasValidas(GrupoC))
        {
            double promedioC = Calculos.CalcularPromedio(GrupoC);
            string condicionC = Calculos.DeterminarCondicion(promedioC);
            Console.WriteLine($"Grupo C: {promedioC:F2} - {condicionC}");
        }
        else
        {
            Console.WriteLine("Grupo C tiene notas inválidas.");
        }

        if (Calculos.NotasValidas(GrupoD))
        {
            double promedioD = Calculos.CalcularPromedio(GrupoD);
            string condicionD = Calculos.DeterminarCondicion(promedioD);
            Console.WriteLine($"Grupo D: {promedioD:F2} - {condicionD}");
        }
        else
        {
            Console.WriteLine("Grupo D tiene notas inválidas.");
        }

        if (Calculos.NotasValidas(GrupoE))
        {
            double promedioE = Calculos.CalcularPromedio(GrupoE);
            string condicionE = Calculos.DeterminarCondicion(promedioE);
            Console.WriteLine($"Grupo E: {promedioE:F2} - {condicionE}");
        }
        else
        {
            Console.WriteLine("Grupo E tiene notas inválidas.");
        }

        if (Calculos.NotasValidas(notasTurnoNoche))
        {
            double promedioTurnoNoche = Calculos.CalcularPromedio(notasTurnoNoche);
            string condicionTurnoNoche = Calculos.DeterminarCondicion(promedioTurnoNoche);
            Console.WriteLine($"Notas del turno noche: {promedioTurnoNoche:F2} - {condicionTurnoNoche}");
        }
        else
        {
            Console.WriteLine("Notas del turno noche son inválidas.");
        }
*/
