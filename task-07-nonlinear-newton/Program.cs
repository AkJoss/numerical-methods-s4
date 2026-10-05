// Coursework: Numerical Methods (4th semester)
// Newton method for a nonlinear system of three equations.
// @author José Alberto Rocha Munguía
//

using System;

class NonlinearSystemSolver
{
    static double[] F(double[] X)
    {
        double x = X[0], y = X[1], z = X[2];
        return new double[]
        {
            4 * x * x + 8 * Math.Sin(y) + 2 * z + 3,
            Math.Exp(x) + Math.Pow(7, -y) + 3 * Math.Sin(z) - 1,
            3 * y * y - Math.Exp(x) + 2 * z
        };
    }

    static double[,] Jacobian(double[] X)
    {
        double x = X[0], y = X[1], z = X[2];
        return new double[,]
        {
            { 8 * x, 8 * Math.Cos(y), 2 },
            { Math.Exp(x), -Math.Log(7) * Math.Pow(7, -y), 3 * Math.Cos(z) },
            { -Math.Exp(x), 6 * y, 2 }
        };
    }

    static double[] SolveLinearSystem(double[,] A, double[] B)
    {
        int n = B.Length;
        double[] X = new double[n];
        for (int i = 0; i < n; i++)
        {
            int maxRow = i;
            for (int k = i + 1; k < n; k++)
                if (Math.Abs(A[k, i]) > Math.Abs(A[maxRow, i]))
                    maxRow = k;

            for (int k = i; k < n; k++)
            {
                double temp = A[maxRow, k];
                A[maxRow, k] = A[i, k];
                A[i, k] = temp;
            }

            double tempB = B[maxRow];
            B[maxRow] = B[i];
            B[i] = tempB;

            for (int k = i + 1; k < n; k++)
            {
                double factor = A[k, i] / A[i, i];
                B[k] -= factor * B[i];
                for (int j = i; j < n; j++)
                    A[k, j] -= factor * A[i, j];
            }
        }

        for (int i = n - 1; i >= 0; i--)
        {
            double sum = 0;
            for (int j = i + 1; j < n; j++)
                sum += A[i, j] * X[j];
            X[i] = (B[i] - sum) / A[i, i];
        }
        return X;
    }

    static double[] NewtonRaphson(double[] initial, int maxIter = 100, double tol = 1e-6)
    {
        double[] X = (double[])initial.Clone();
        for (int i = 0; i < maxIter; i++)
        {
            double[] Fx = F(X);
            double[,] Jx = Jacobian(X);
            double[] deltaX = SolveLinearSystem(Jx, new double[] { -Fx[0], -Fx[1], -Fx[2] });
            for (int j = 0; j < X.Length; j++)
                X[j] += deltaX[j];

            double norm = Math.Sqrt(deltaX[0] * deltaX[0] + deltaX[1] * deltaX[1] + deltaX[2] * deltaX[2]);
            if (norm < tol)
                break;
        }
        return X;
    }

    static void Main()
    {
        double[] initialGuess = { 0, 0, 0 };
        double[] solution = NewtonRaphson(initialGuess);
        Console.WriteLine($"Solución: x = {solution[0]}, y = {solution[1]}, z = {solution[2]}");
    }
}
