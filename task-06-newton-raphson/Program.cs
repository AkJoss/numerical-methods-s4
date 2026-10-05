// Coursework: Numerical Methods (4th semester)
// Newton-Raphson root finding for a quadratic-like function.
// @author José Alberto Rocha Munguía
//

using System;

class NewtonRaphson
{
    static double Funcion(double x)
    {
        return x * x - 5 * x + 6;
    }

    static double Derivada(double x)
    {
        return 2 * x - 5;
    }

    static double NewtonRaphsonMethod(double x0, double tol, int maxIter)
    {
        double x = x0;
        int iter = 0;

        while (Math.Abs(Funcion(x)) > tol && iter < maxIter)
        {
            double dfx = Derivada(x);

            if (dfx == 0)
            {
                Console.WriteLine("Derivada cero, método falló.");
                return double.NaN;
            }

            x = x - Funcion(x) / dfx;
            iter++;
        }

        return x;
    }

    static void Main()
    {
        double x0 = 3.0; // Estimación inicial
        double tolerancia = 1e-6;
        int maxIteraciones = 100;

        double raiz = NewtonRaphsonMethod(x0, tolerancia, maxIteraciones);

        if (!double.IsNaN(raiz))
            Console.WriteLine($"La raíz encontrada es: {raiz}");
        else
            Console.WriteLine("No se encontró una solución válida.");
    }
}
