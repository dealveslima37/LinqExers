using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantos numeros voce vai digitar? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new double[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    vector[i] = double.Parse(Console.ReadLine()!, locale);
}

var sum = vector.Sum();
var avg = vector.DefaultIfEmpty().Average();

Console.Write("Valores = ");
vector.ToList().ForEach(x => Console.Write($"{x.ToString("F1", locale)} "));
Console.WriteLine($"\nSoma = {sum.ToString("F1", locale)}");
Console.WriteLine($"Média = {avg.ToString("F1", locale)}");