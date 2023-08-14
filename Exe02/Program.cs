using System.Globalization;
using Exe02.Entities;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantidade de produtos: ");
var n = int.Parse(Console.ReadLine()!);

var vector = new Product[n];

for (var i = 0; i < vector.Length; i++)
{
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Preço R$: ");
    var price = double.Parse(Console.ReadLine()!, locale);

    vector[i] = new Product() { Name = name, Price = price };
}

var avg = vector.Select(p => p.Price).DefaultIfEmpty().Average();

Console.WriteLine($"Média de preço R$ {avg.ToString("F2", locale)}");