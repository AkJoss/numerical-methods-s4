// Coursework: Numerical Methods (4th semester)
// Riemann sum approximation for a polynomial function.
// @author José Alberto Rocha Munguía
//

using System;

class RiemannSum
{
    // Polynomial integrand used for the left Riemann sum demo.
    static double Funcion(double x)
    {
        return 3 * Math.Pow(x, 4) - 5 * Math.Pow(x, 3) + Math.Pow(x, 2) - 0.5 * x + 3;
    }

    // Left Riemann sum on [a, b] with n subintervals.
    static double SumaDeRiemann(double a, double b, int n)
    {
        double suma = 0.0;
        double deltaX = (b - a) / n;

        for (int i = 0; i < n; i++)
        {
            double x = a + i * deltaX; // left endpoint of each subinterval
            suma += Funcion(x) * deltaX;
        }

        return suma;
    }

    static void Main()
    {
        double a = 1.0 / 3.0;
        double b = 5.0 / 2.0;
        int n = 100000; // more partitions => better approximation

        double resultado = SumaDeRiemann(a, b, n);
        Console.WriteLine($"Resultado de la suma de Riemann: {resultado:F6}");
    }
}
