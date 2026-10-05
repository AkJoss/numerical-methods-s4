// Coursework: Numerical Methods (4th semester)
// Prints terms of a numeric series until a stop condition.
// @author José Alberto Rocha Munguía
//

int n = 1;
double valorSerie;

while (true)
{
    valorSerie = (n * n - 3) / (double)n;
    Console.WriteLine($"Término {n}: {valorSerie}");

    if (valorSerie > 30)
    {
        Console.WriteLine($"La serie supera 30 en el término {n} con valor {valorSerie}");
        break;
    }

    n++;
}
