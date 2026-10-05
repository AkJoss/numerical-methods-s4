// Coursework: Numerical Methods (4th semester)
// Collects and lists Mexican states the user has visited.
// @author José Alberto Rocha Munguía
//

int estados;
Console.WriteLine("¿Cuántos estados de la republica conoces o has visitado?");
estados = int.Parse(Console.ReadLine());

string[][] lugares_Visitados = new string[estados][];
for (int i = 0; i < estados; i++)
{
    Console.WriteLine($"Ingrese el estado que ha visitado {i + 1}: ");
    string estado = Console.ReadLine();

    Console.WriteLine("Cuantos lugares ha visitado en ese estado?");
    int lugares = int.Parse(Console.ReadLine());

    lugares_Visitados[i] = new string[lugares];
    for (int j = 0; j < lugares; j++)
    {
        Console.WriteLine($"Ingrese el nombre del lugar {j + 1} en el estado de {estado}");
        lugares_Visitados[i][j] = Console.ReadLine();
    }
    string[] anecdotas = new string[estados];
    Console.WriteLine($"Ingrese una anecdota sobre ese estado: ");
    anecdotas[i] = Console.ReadLine();

}
