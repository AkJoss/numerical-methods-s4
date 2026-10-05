// Coursework: Numerical Methods (4th semester)
// Builds and solves a linear system from sample data (Gauss).
// @author José Alberto Rocha Munguía
//

using System;

class Program
{
    static void Main(string[] args)
    {
        double pivote, factor;
        int nDatos = 30;
        int nCoef = 5; // Más coeficientes para mejor ajuste

        double[,] jacobiana = new double[nDatos, nCoef];
        double[,] matriz = new double[nCoef, nCoef + 1];

        double[] voltaje = { 14.537, 17.877, 17.877, 15.546, 17.535, 23.933,
                             31.615, 36.277, 36.397, 34.61, 10.463,
                             13.803, 12.962, 11.472, 13.461, 19.859,
                             27.541, 32.203, 32.317, 30.536, 7.2074,
                             10.547, 9.7056, 8.216, 10.205, 16.603,
                             24.285, 28.947, 29.061, 27.28 };

        double[] tiempo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
                            17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        // Llenado de la matriz Jacobiana con más términos
        for (int i = 0; i < nDatos; i++)
        {
            jacobiana[i, 0] = tiempo[i] * tiempo[i];
            jacobiana[i, 1] = Math.Sin(tiempo[i]);
            jacobiana[i, 2] = Math.Exp(tiempo[i] / 10);
            jacobiana[i, 3] = Math.Pow(tiempo[i], 3); // x^3
            jacobiana[i, 4] = Math.Cos(tiempo[i]); // cos(x)
        }

        // Multiplicación de Jacobiana^T * Jacobiana
        for (int i = 0; i < nCoef; i++)
            for (int j = 0; j < nCoef; j++)
            {
                matriz[i, j] = 0;
                for (int k = 0; k < nDatos; k++)
                    matriz[i, j] += jacobiana[k, i] * jacobiana[k, j];
            }

        // Multiplicación de Jacobiana^T * voltaje
        for (int i = 0; i < nCoef; i++)
        {
            matriz[i, nCoef] = 0;
            for (int k = 0; k < nDatos; k++)
                matriz[i, nCoef] += voltaje[k] * jacobiana[k, i];
        }

        // Eliminación Gaussiana para resolver el sistema
        for (int reng = 0; reng < nCoef; reng++)
        {
            pivote = matriz[reng, reng];
            if (Math.Abs(pivote) < 1e-10)
            {
                Console.WriteLine("Error: Pivote cercano a 0. El sistema no es resoluble.");
                return;
            }

            for (int colu = 0; colu <= nCoef; colu++)
                matriz[reng, colu] /= pivote;

            for (int reng_elimi = 0; reng_elimi < nCoef; reng_elimi++)
            {
                if (reng_elimi != reng)
                {
                    factor = matriz[reng_elimi, reng];
                    for (int colu_elimi = 0; colu_elimi <= nCoef; colu_elimi++)
                        matriz[reng_elimi, colu_elimi] -= factor * matriz[reng, colu_elimi];
                }
            }
        }

        // Obtener coeficientes
        double a = matriz[0, nCoef];
        double b = matriz[1, nCoef];
        double c = matriz[2, nCoef];
        double d = matriz[3, nCoef];
        double e = matriz[4, nCoef];

        // Imprimir ecuación ajustada con más términos
        Console.WriteLine($"Ecuación ajustada:");
        Console.WriteLine($"y = {a} * x^2 + {b} * sin(x) + {c} * e^(x/10) + {d} * x^3 + {e} * cos(x)");

        Console.ReadLine();
    }
}
