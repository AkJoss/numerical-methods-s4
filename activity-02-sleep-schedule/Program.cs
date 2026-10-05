// Coursework: Numerical Methods (4th semester)
// Interactive loop that validates a sleep hour between 0 and 23.
// @author José Alberto Rocha Munguía
//

int dormir;
while (true)
{
    Console.WriteLine("Ingrese la hora a la que se duerme de 0 a 23: ");
    dormir = int.Parse(Console.ReadLine());

    if (dormir >= 0 && dormir <= 23)
        break;
    else
        Console.WriteLine("Hora invalida, porfavor ingrese una hora valida desde el 0 al 23: ");
}

int despertar = (dormir + 8) % 24;

switch (dormir)
{
    case 23:
    case 0:
    case 1:
        Console.WriteLine($"Duerme usted un poco tarde, trate de descansar más, hora recomendada {despertar}:00");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine($"Usted duerme muy tarde, eso no es bueno para la salud, hora recomendada:{despertar}:00");
        break;
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
        Console.WriteLine($"Supongo que duerme a estas horas porque tiene un trabajo nocturno, hora recomendada {despertar}:00");
        break;
    case 11:
    case 12:
    case 13:
    case 14:
    case 15:
    case 16:
    case 17:
    case 18:
        Console.WriteLine($"Usted tiene un horario de sueño muy extraño, hora recomendada {despertar}:00");
        break;
    case 19:
    case 20:
        Console.WriteLine($"Usted duerme muy temprano");
        break;
    case 21:
    case 22:
        Console.WriteLine($"Usted duerme a muy buena hora, felicidades, hora recomendada {despertar}:00");
    break;

}
