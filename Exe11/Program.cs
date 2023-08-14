using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantos elementos vai ter o vetor? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new double[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    vector[i] = double.Parse(Console.ReadLine()!, locale);
}

var avg = vector.DefaultIfEmpty().Average();
var elementsUnderAvg = vector.Where(number => number < avg).ToList();

Console.WriteLine();
Console.WriteLine($"Média do vetor = {avg.ToString("F3", locale)}");
Console.WriteLine($"Elementos abaixo da média");
elementsUnderAvg.ForEach(x => Console.WriteLine($"{x.ToString("F2", locale)}"));