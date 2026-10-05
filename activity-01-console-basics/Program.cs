// Coursework: Numerical Methods (4th semester)
// Console basics: read values, arithmetic operations, and comparisons.
// @author José Alberto Rocha Munguía
//

double valor_1, valor_2, valor_3, valor_4;
Console.WriteLine("Ingrese valor de valor_1:");
valor_1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese valor de valor_2:");
valor_2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese valor de valor_3:");
valor_3 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese valor de valor_4:");
valor_4 = double.Parse(Console.ReadLine());

double Operacion_1 = valor_1 + valor_2 + valor_3 + valor_4;
Console.WriteLine("Operacion 1 es igual a: \n" + Operacion_1);
double Operacion_2 = valor_1 * valor_2 * valor_3 * valor_4;
Console.WriteLine("Operacion 2 es igual a: \n" + Operacion_2);
double Operacion_3 = valor_1 / valor_2 / valor_3 / valor_4;
Console.WriteLine("Operacion 3 es igual a: \n" + Operacion_3);
double Operacion_4 = Operacion_1 / Operacion_2;
Console.WriteLine("Operacion 4 es igual a: \n" + Operacion_4);

bool compara_1 = valor_1 != valor_3;
bool compara_2 = valor_2 == valor_4;
bool compara_3 = valor_1 > valor_3 && valor_1 < valor_4;
bool compara_4 = valor_2 < Operacion_3;

Console.WriteLine("Comparacion 1 es igual a: \n" + compara_1);
Console.WriteLine("Comparacion 2 es igual a: \n" + compara_2);
Console.WriteLine("Comparacion 3 es igual a: \n" + compara_3);
Console.WriteLine("Comparacion 4 es igual a: \n" + compara_4);
