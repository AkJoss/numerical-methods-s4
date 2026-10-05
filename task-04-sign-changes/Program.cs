// Coursework: Numerical Methods (4th semester)
// Detects sign changes of a function over sampled points.
// @author José Alberto Rocha Munguía
//

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> cambiosDeSigno = new List<int>();
        int prevValor = Funcion(1);
        for (int n = 2; n <= 1000; n++)
        {
            int valor = Funcion(n);
            if ((prevValor < 0 && valor >= 0) || (prevValor >= 0 && valor < 0))
            {
                cambiosDeSigno.Add(n);
            }

            prevValor = valor;
        }

        Console.WriteLine("Cambios de signo encontrados en los valores de n:");
        foreach (int n in cambiosDeSigno)
        {
            Console.WriteLine(n);
        }
    }

    static int Funcion(int n)
    {
        return n % 2 == 0 ? n : -n;
    }
}
