// Coursework: Numerical Methods (4th semester)
// Reads course grades and computes an accumulator/average.
// @author José Alberto Rocha Munguía
//

int materias;
int acumulador = 0;

Console.WriteLine("Ingrese el numero de materia que lleva: ");
materias = int.Parse(Console.ReadLine());

int[] calificaciones = new int[materias];

for (int i = 0; i < materias; i++)
{
    Console.WriteLine($"Ingrese la calificacion de la materia {i}: ");
    calificaciones[i] = int.Parse(Console.ReadLine());
    acumulador = acumulador + calificaciones[i];
}
int maximo = calificaciones[0];
int minimo = calificaciones[0];

foreach (int calificacion in calificaciones)
{
    if (calificacion < minimo)
    {
        minimo = calificacion;
    }

    if (calificacion > maximo)
    {
        maximo = calificacion;
    }
}
int promedio = acumulador / calificaciones.Length;
Console.WriteLine("El promedio es: " + promedio);
Console.WriteLine("La calificacion mas baja es: " + minimo);
Console.WriteLine("La calificacion mas alta es: " + maximo);
