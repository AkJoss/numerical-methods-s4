// Coursework: Numerical Methods (4th semester)
// Simpson's rule integration with multiple subinterval counts.
// @author José Alberto Rocha Munguía
//

using System;

class SimpsonPrecision
{
    static void Main()
    {
        int[] subintervals = { 2, 5, 10, 20, 100, 5000, 10000 };
        double a = -10;
        double b = 10;

        // High-n result used as a reference to measure relative error.
        double reference = Simpson(f, a, b, 10000);
        Console.WriteLine($"Valor de referencia (n=10000): {reference}\n");

        foreach (int n in subintervals)
        {
            // Simpson's rule requires an even number of subintervals.
            if (n % 2 != 0)
            {
                Console.WriteLine($"n = {n} → debe ser par. Se ajusta a n = {n + 1}");
            }

            int nAdjusted = (n % 2 == 0) ? n : n + 1;
            double result = Simpson(f, a, b, nAdjusted);
            double errorPercent = Math.Abs((reference - result) / reference) * 100;

            Console.WriteLine($"n = {nAdjusted} → Resultado: {result:F8}, Error: {errorPercent:F6}%");

            if (errorPercent < 0.1)
            {
                Console.WriteLine($"\n✅ Se alcanza 99.9% de precisión con n = {nAdjusted}");
                break;
            }
        }
    }

    // Composite Simpson's rule: (h/3)*(y0 + 4y1 + 2y2 + ... + yn)
    static double Simpson(Func<double, double> f, double a, double b, int n)
    {
        double h = (b - a) / n;
        double sum = f(a) + f(b);

        for (int i = 1; i < n; i += 2)
        {
            double x = a + i * h;
            sum += 4 * f(x);
        }

        for (int i = 2; i < n; i += 2)
        {
            double x = a + i * h;
            sum += 2 * f(x);
        }

        return (h / 3) * sum;
    }

    // f(x) = sin(x)/x + 1  (limit at 0 is 2)
    static double f(double x)
    {
        return x == 0 ? 2 : Math.Sin(x) / x + 1;
    }
}
