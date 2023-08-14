Console.Write("Quantos numeros voce vai digitar? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new int[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um numero: ");
    vector[i] = int.Parse(Console.ReadLine()!);
}

var evenNumbers =  vector.Where(number => number % 2 == 0).ToList();
var qtdEvenNumbers = evenNumbers.Count;

Console.WriteLine();
Console.WriteLine("Número pares:");
evenNumbers.ForEach(number => Console.Write($"{number} "));
Console.WriteLine($"\nQuantidade de pares {qtdEvenNumbers}");
