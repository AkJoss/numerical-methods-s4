// Coursework: Numerical Methods (4th semester)
// Computes a requested term of the Fibonacci sequence.
// @author José Alberto Rocha Munguía
//

Console.WriteLine("Ingrese el termino de la serie de Fibonacci que desee:");
int termino = int.Parse(Console.ReadLine());

int Fibonacci_a = 0;
int Fibonacci_b = 1;

for (int Fibonnaci_i = 2; Fibonnaci_i <= termino; Fibonnaci_i++)
{
    int serie = Fibonacci_a + Fibonacci_b;
    Fibonacci_a = Fibonacci_b;
    Fibonacci_b = serie;
    Console.WriteLine($"El numero del termino {termino} de la serie de Fibonacci es {Fibonacci_b}");
}
