using System.Globalization;

Console.Write("Quantos elementos vai ter o vetor? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new int[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    vector[i] = int.Parse(Console.ReadLine()!);
}

var evenNumbers = vector.Where(x => x % 2 == 0).ToList();
var avgEvenNumbers = evenNumbers.DefaultIfEmpty().Average();

var result = (evenNumbers.Any())
    ? $"Média dos pares {avgEvenNumbers.ToString("F1", CultureInfo.InvariantCulture)}"
    : "NENHUM NÚMERO PAR";

Console.WriteLine(result);