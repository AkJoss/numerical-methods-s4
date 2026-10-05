// Coursework: Numerical Methods (4th semester)
// Interactive Gaussian elimination for an n-equation system.
// @author José Alberto Rocha Munguía
//

using System;

class GaussElimination
{
    static double[,] IngresarMatriz(int n)
    {
        double[,] matriz = new double[n, n + 1];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ingrese los valores de la fila {i + 1}, separados por espacios:");
            string[] entrada = Console.ReadLine().Split(' ');
            if (entrada.Length != n + 1)
            {
                Console.WriteLine("Número incorrecto de valores, intente de nuevo.");
                return IngresarMatriz(n);
            }
            for (int j = 0; j <= n; j++)
                matriz[i, j] = double.Parse(entrada[j]);
        }
        return matriz;
    }

    static bool SonDependientes(double[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            bool filaCero = true;
            for (int j = 0; j < n; j++)
                if (matriz[i, j] != 0)
                    filaCero = false;
            if (filaCero)
                return true;
        }
        return false;
    }

    static void Gauss(double[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (matriz[i, i] == 0)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matriz[j, i] != 0)
                    {
                        for (int k = 0; k <= n; k++)
                        {
                            double temp = matriz[i, k];
                            matriz[i, k] = matriz[j, k];
                            matriz[j, k] = temp;
                        }
                        break;
                    }
                }
            }
            if (matriz[i, i] == 0) continue;

            double divisor = matriz[i, i];
            for (int j = 0; j <= n; j++)
                matriz[i, j] /= divisor;

            for (int j = i + 1; j < n; j++)
            {
                double factor = matriz[j, i];
                for (int k = 0; k <= n; k++)
                    matriz[j, k] -= factor * matriz[i, k];
            }
        }
    }

    static double[] Resolver(double[,] matriz, int n)
    {
        double[] soluciones = new double[n];
        for (int i = n - 1; i >= 0; i--)
        {
            soluciones[i] = matriz[i, n];
            for (int j = i + 1; j < n; j++)
                soluciones[i] -= matriz[i, j] * soluciones[j];
        }
        return soluciones;
    }

    static void Main()
    {
        Console.Write("Ingrese el tamaño de la matriz: ");
        int n = int.Parse(Console.ReadLine());
        double[,] matriz = IngresarMatriz(n);
        if (SonDependientes(matriz, n))
        {
            Console.WriteLine("Ecuaciones dependientes");
            return;
        }
        Gauss(matriz, n);
        double[] soluciones = Resolver(matriz, n);
        Console.WriteLine("Solución del sistema:");
        for (int i = 0; i < n; i++)
            Console.WriteLine($"x{i + 1} = {soluciones[i]}");
    }
}
