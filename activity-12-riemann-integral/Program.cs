// Coursework: Numerical Methods (4th semester)
// Approximates a definite integral with Riemann sums.
// @author José Alberto Rocha Munguía
//

using System;

class Program
{
    // Integrand f(x) = x^3 + 5
    static double Function(double x)
    {
        return Math.Pow(x, 3) + 5;
    }

    // Midpoint Riemann sum on [a, b] with n partitions.
    static double RiemannSum(double a, double b, int n)
    {
        double deltaX = (b - a) / n;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double xMid = a + (i + 0.5) * deltaX;
            sum += Function(xMid) * deltaX;
        }

        return sum;
    }

    static void Main()
    {
        double a = 0.5;
        double b = 2.0;
        int n = 1000;

        double approxArea = RiemannSum(a, b, n);
        Console.WriteLine("Aproximación del área usando suma de Riemann: " + approxArea);
    }
}
