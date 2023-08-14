using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantidade de pessoas: ");
var n = int.Parse(Console.ReadLine()!);

var vector = new double[n];

for (var i = 0; i < vector.Length; i++)
{
   vector[i] = Double.Parse(Console.ReadLine()!); 
}

var avg = vector.DefaultIfEmpty().Average();

Console.WriteLine($"Média das alturas {avg.ToString("F2", locale)}");

