// Coursework: Numerical Methods (4th semester)
// Sets up a linear system from x/y samples and solves it.
// @author José Alberto Rocha Munguía
//

double[] x = { -2, -1, -0.3, 1.45, 4.3, 8, 9.56, 12.1, 23.5 };
double[] y = { 5, 7.3, 1.23, -3.5, 3, 7.8, 0.1, 3.4, 2.3 };
double[,] matriz = new double[9, 10];
double pivote, factor;
double x_0 = 5.234;
double y_0 = 0;

for (int i = 0; i < 9; i = i + 1)
{
    for (int j = 0; j < 9; j = j + 1)
    {
        matriz[i, j] = Math.Pow(x[i], j);
    }
}
for (int i = 0; i < 9; i = i + 1)
{
    matriz[i, 9] = y[i];
}
//Eliminación Gaussiana
//------------------------------
for (int reng = 0; reng < 9; reng = reng + 1)
{
    pivote = matriz[reng, reng];
    for (int colu = 0; colu < 10; colu = colu + 1)
    {
        matriz[reng, colu] = matriz[reng, colu] / pivote;
    }
    for (int reng_elimi = 0; reng_elimi < 9; reng_elimi = reng_elimi + 1)
    {
        if (reng_elimi != reng)
        {
            factor = matriz[reng_elimi, reng];
            for (int colu_elimi = 0; colu_elimi < 10; colu_elimi = colu_elimi + 1)
            {
                matriz[reng_elimi, colu_elimi] = matriz[reng_elimi, colu_elimi]
                    - factor * matriz[reng, colu_elimi];
            }
        }
    }
}
//------------------------------
for (int i = 0; i < 9; i = i + 1)
{
    y_0 = y_0 + matriz[i, 9] * Math.Pow(x_0, i);
}

Console.WriteLine("El valor de y en " + x_0 + " es " + y_0);
Console.ReadLine();
