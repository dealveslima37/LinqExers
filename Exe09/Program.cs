using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Quantos numeros voce vai digitar? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new double[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um numero: ");
    vector[i] = Double.Parse(Console.ReadLine()!, locale);
}

var maxValue = vector.Max();
var maxValuePosition = Array.IndexOf(vector, maxValue);

Console.WriteLine($"MAIOR VALOR = {maxValue.ToString("F2", locale)}");
Console.WriteLine($"POSICAO DO MAIOR VALOR = {maxValuePosition.ToString("F2", locale)}");