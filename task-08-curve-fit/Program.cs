// Coursework: Numerical Methods (4th semester)
// Curve fitting / regression over tabulated t and f values.
// @author José Alberto Rocha Munguía
//

using System;

class Program
{
    static void Main()
    {
        // Datos de entrada
        double[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] f = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.2849, 28.9468, 29.0606, 27.2799 };

        int n = t.Length;

        // Variables para los sumatorios
        double sumT = 0, sumSinT = 0, sumFT = 0, sumFSinT = 0;
        double sumT2 = 0, sumSinT2 = 0, sumTSinT = 0, sumF = 0;

        // Cálculo de los sumatorios
        for (int i = 0; i < n; i++)
        {
            double sinT = Math.Sin(t[i]);
            sumT += t[i];
            sumSinT += sinT;
            sumFT += t[i] * f[i];
            sumFSinT += sinT * f[i];
            sumT2 += t[i] * t[i];
            sumSinT2 += sinT * sinT;
            sumTSinT += t[i] * sinT;
            sumF += f[i];
        }

        // Resolver el sistema de ecuaciones lineales
        double denominator = (sumT2 * sumSinT2 - sumTSinT * sumTSinT);
        if (Math.Abs(denominator) < 1e-9)
        {
            Console.WriteLine("El sistema no tiene solución única.");
            return;
        }

        double x1 = (sumFT * sumSinT2 - sumFSinT * sumTSinT) / denominator;
        double x2 = (sumFSinT * sumT2 - sumFT * sumTSinT) / denominator;

        // Mostrar resultados
        Console.WriteLine($"Coeficiente x1: {x1}");
        Console.WriteLine($"Coeficiente x2: {x2}");
        Console.WriteLine($"Ecuación ajustada: f(t) = {x1} * t + {x2} * sin(t)");
    }
}
