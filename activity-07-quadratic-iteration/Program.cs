// Coursework: Numerical Methods (4th semester)
// Iterative evaluation related to a quadratic equation.
// @author José Alberto Rocha Munguía
//

float a = 1;
float b = -5;
float c = 6;


Console.WriteLine("Desde que numero quieres empezar la formula");
double x_nuevo = double.Parse(Console.ReadLine());
double x_viejo = 0;
double y_nuevo = a * (x_nuevo * x_nuevo) + b * x_nuevo + c;
double y_viejo = y_nuevo;
int paso = 1;
while (y_nuevo * y_viejo > 0)
{
    x_viejo = x_nuevo;
    x_nuevo = x_viejo + paso;

    y_viejo = y_nuevo;
    y_nuevo = a * (x_nuevo * x_nuevo) + b * x_nuevo + c;
}

Console.WriteLine($"El intervalo en el que esta la raiz está entre {x_viejo} y {x_nuevo}");
Console.ReadLine();
