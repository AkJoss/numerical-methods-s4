// Coursework: Numerical Methods (4th semester)
// Scans a function over an interval looking for solution points.
// @author José Alberto Rocha Munguía
//

// Part 1: scan f(i) = tan(i/10)^2 - cos(i/20) and report sign-change brackets.
double paso3 = 0.01, sol_1, sol_2 = 0;
for (double i = -100; i <= 100; i = i + paso3)
{
    sol_1 = Math.Pow(Math.Tan(i / 10), 2) - Math.Cos(i / 20);
    if (sol_1 * sol_2 < 0)
    {
        Console.WriteLine("la solucion es: " + i);
    }
    sol_2 = sol_1;
}

// Part 2: brute-force search for an integer solution of a 2x2 linear system.
double sol_eq1, sol_eq2, paso = 1;
for (double x = -100; x < 100; x = x + paso)
{
    for (double y = -100; y < 100; y = y + paso)
    {
        if (24 == 4 * x + 3 * y && 2 == 2 * x - y)
        {
            Console.WriteLine("La solucion es x =  " + x + " y = " + y);
        }
    }
}
