using System.Globalization;
using Exe15.Entities;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantas pessoas serão digitadas? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new Person[n];

for (var i = 0; i < n; i++)
{
    Console.Write($"Altura da {i + 1}º pessoa: ");
    var heigth = double.Parse(Console.ReadLine()!, locale);
    Console.Write($"Gênero da {i + 1}º pessoa: ");
    var genre = Console.ReadLine()!.ToUpper();

    vector[i] = new Person(heigth, genre);
}


var maxHeight = vector.DefaultIfEmpty().Max(p => p!.Height);
var minHeight = vector.DefaultIfEmpty().Min(p => p!.Height);
var avgHeightWomen = vector.Where(p => p.Genre!.StartsWith("F")).DefaultIfEmpty().Average(p => p!.Height);
var qtdMen = vector.DefaultIfEmpty().Count(p => p!.Genre!.StartsWith("M"));

Console.WriteLine();
Console.WriteLine($"Menor altura = {minHeight.ToString("F2", locale)}");
Console.WriteLine($"Maior altura = {maxHeight.ToString("F2", locale)}");
Console.WriteLine($"Media das alturas das mulheres = {avgHeightWomen.ToString("F2", locale)}");
Console.WriteLine($"Número de homens = {qtdMen}");