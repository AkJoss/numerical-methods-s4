// Coursework: Numerical Methods (4th semester)
// Evaluates a hypothetical equation for a user-provided x.
// @author José Alberto Rocha Munguía
//

Console.WriteLine("Ingresa el número hipotético x con el cual se realizará la ecuación");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el número hipotético y con el cual se realizará la ecuación");
double y = double.Parse(Console.ReadLine());

double tol = 1e-6; // Tolerancia para la convergencia
int maxIter = 1000; // Número máximo de iteraciones

for (int iter = 0; iter < maxIter; iter++)
{
    double f1 = Math.Exp(x) + y * y - 5;
    double f2 = x * x + y - 2;

    double df1dx = Math.Exp(x);
    double df1dy = 2 * y;
    double df2dx = 2 * x;
    double df2dy = 1;

    double det = df1dx * df2dy - df1dy * df2dx;

    if (Math.Abs(det) < tol)
    {
        Console.WriteLine("El determinante es muy pequeño, el método no puede continuar.");
        return;
    }

    double dx = (f1 * df2dy - f2 * df1dy) / det;
    double dy = (f2 * df1dx - f1 * df2dx) / det;

    x -= dx;
    y -= dy;

    if (Math.Abs(dx) < tol && Math.Abs(dy) < tol)
    {
        break;
    }
}

Console.WriteLine("Las soluciones son:");
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
