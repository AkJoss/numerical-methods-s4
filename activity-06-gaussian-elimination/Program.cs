// Coursework: Numerical Methods (4th semester)
// Gaussian elimination on a 3x4 augmented matrix (user input).
// @author José Alberto Rocha Munguía
//

// Augmented matrix [A|b] for a 3x3 linear system (3 rows, 4 columns).
double[,] matriz = new double[3, 4];
int a = 1;
double pivote, factor;

// Read coefficients row by row from the user.
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine($"Ingresa en orden la ecuacion: {a++}");
        matriz[i, j] = double.Parse(Console.ReadLine());
    }
}

// Gaussian elimination to reduced row-echelon form.
for (int reng = 0; reng < 3; reng++)
{
    pivote = matriz[reng, reng];

    // Scale the pivot row so the pivot becomes 1.
    for (int colu = 0; colu < 4; colu++)
    {
        matriz[reng, colu] = matriz[reng, colu] / pivote;
    }

    // Eliminate the pivot column in every other row.
    for (int reng_elimi = 0; reng_elimi < 3; reng_elimi++)
    {
        if (reng_elimi != reng)
        {
            factor = matriz[reng_elimi, reng];
            for (int colu_elimi = 0; colu_elimi < 4; colu_elimi++)
            {
                matriz[reng_elimi, colu_elimi] = matriz[reng_elimi, colu_elimi] - factor * matriz[reng, colu_elimi];
            }
        }
    }
}

// Last column holds the solution after elimination.
Console.WriteLine($" x = {matriz[0, 3]}");
Console.WriteLine($" y = {matriz[1, 3]}");
Console.WriteLine($" z = {matriz[2, 3]}");
