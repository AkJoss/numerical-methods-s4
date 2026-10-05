// Coursework: Numerical Methods (4th semester)
// Evidence 2: sales over months and trend/matrix analysis.
// @author José Alberto Rocha Munguía
//

using System;

class Program
{
    static void Main()
    {
        // Datos de entrada
        double[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        double[] ventas = { 65, 69, 76, 82, 89, 94, 96, 96, 92, 85, 76, 67, 58, 60, 70, 80, 82, 89 };

        int n = meses.Length;
        double[,] A = new double[n, 4];
        double[] b = new double[n];

        // Construcción de la matriz A y del vector b
        for (int i = 0; i < n; i++)
        {
            A[i, 0] = meses[i];
            A[i, 1] = Math.Cos(meses[i]);
            A[i, 2] = meses[i] * meses[i];
            A[i, 3] = 1;
            b[i] = ventas[i];
        }

        // Resolver por mínimos cuadrados usando multiplicación de matrices
        double[,] At = TransponerMatriz(A);
        double[,] AtA = MultiplicarMatrices(At, A);
        double[] Atb = MultiplicarMatrizVector(At, b);
        double[] coeficientes = ResolverSistema(AtA, Atb);

        // Mostrar coeficientes
        Console.WriteLine($"Coeficientes obtenidos: x1 = {coeficientes[0]}, x2 = {coeficientes[1]}, x3 = {coeficientes[2]}, x4 = {coeficientes[3]}");
    }

    static double[,] TransponerMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[,] transpuesta = new double[columnas, filas];
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                transpuesta[j, i] = matriz[i, j];
        return transpuesta;
    }

    static double[,] MultiplicarMatrices(double[,] A, double[,] B)
    {
        int filas = A.GetLength(0), columnas = B.GetLength(1), comunes = A.GetLength(1);
        double[,] resultado = new double[filas, columnas];
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                for (int k = 0; k < comunes; k++)
                    resultado[i, j] += A[i, k] * B[k, j];
        return resultado;
    }

    static double[] MultiplicarMatrizVector(double[,] A, double[] v)
    {
        int filas = A.GetLength(0), columnas = A.GetLength(1);
        double[] resultado = new double[filas];
        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                resultado[i] += A[i, j] * v[j];
        return resultado;
    }

    static double[] ResolverSistema(double[,] A, double[] b)
    {
        int n = A.GetLength(0);
        double[] x = new double[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                double factor = A[j, i] / A[i, i];
                for (int k = 0; k < n; k++)
                    A[j, k] -= factor * A[i, k];
                b[j] -= factor * b[i];
            }
        }
        for (int i = n - 1; i >= 0; i--)
        {
            double suma = 0;
            for (int j = i + 1; j < n; j++)
                suma += A[i, j] * x[j];
            x[i] = (b[i] - suma) / A[i, i];
        }
        return x;
    }
}
