// Coursework: Numerical Methods (4th semester)
// Evaluates a hypothetical equation for a user-provided x.
// @author José Alberto Rocha Munguía
//

// 2D Newton method for:
//   f1(x,y) = e^x + y^2 - 5 = 0
//   f2(x,y) = x^2 + y - 2   = 0
Console.WriteLine("Ingresa el número hipotético x con el cual se realizará la ecuación");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el número hipotético y con el cual se realizará la ecuación");
double y = double.Parse(Console.ReadLine());

double tol = 1e-6; // Convergence tolerance
int maxIter = 1000; // Safety cap on iterations

for (int iter = 0; iter < maxIter; iter++)
{
    double f1 = Math.Exp(x) + y * y - 5;
    double f2 = x * x + y - 2;

    // Jacobian entries
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

    // Solve J * [dx, dy]^T = [f1, f2]^T then step backwards (Newton update).
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
