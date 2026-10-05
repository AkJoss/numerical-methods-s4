// Coursework: Numerical Methods (4th semester)
// Reads three integers and prints basic operations/results.
// @author José Alberto Rocha Munguía
//

int numero_1, numero_2, numero_3;
Console.WriteLine("Ingrese numero 1:");  
numero_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero 2:");
numero_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero 3:");
numero_3 = int.Parse(Console.ReadLine());

double opera_1 = numero_1 + numero_2 - numero_3;
double opera_2 = numero_1 * numero_2 * numero_3;
double opera_3 = numero_2 & numero_3;

Console.WriteLine("El resultado de Opera 1 es igual a: \n" + opera_1);
Console.WriteLine("El resultado de Opera 2 es igual a: \n" + opera_2);
Console.WriteLine("El resultado de Opera 3 es igual a: \n" + opera_3);

bool contraste_1 = numero_1 == numero_3;
bool contraste_2 = numero_1 > numero_2 && numero_1 > numero_3;
bool contraste_3 = contraste_1 == contraste_2;

Console.WriteLine("Contraste 1 es: \n" + contraste_1);
Console.WriteLine("Contraste 2 es: \n" + contraste_2);
Console.WriteLine("Contraste 3 es: \n" + contraste_3);
