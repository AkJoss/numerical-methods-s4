// Coursework: Numerical Methods (4th semester)
// Midterm practice: product catalog with cost logic.
// @author José Alberto Rocha Munguía
//

double costo;
int producto;
Console.WriteLine("Catalogo de productos: ");
Console.WriteLine();
Console.WriteLine("1.- Televisor \n2.- Sala \n3.- Comedor");
Console.WriteLine();
producto = 2;

switch (producto)
{
    case 1:
        costo = 1000;
        Console.WriteLine("Televisor con un costo de: " + costo);
        break;
    case 2:
    case 3:
        costo = 2500;
        Console.WriteLine("Sala con un costo de: " + costo);
        costo = 4390;
        Console.WriteLine("Comedor con un costo de " + costo);
        break;
    default: 
        Console.WriteLine("No se ha comprado nada");
        break;
}
