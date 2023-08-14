using System.Globalization;
using Exe07.Entities;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantas pessoas serão digitadas? ");
var n = int.Parse(Console.ReadLine()!);

List<Person> persons = new();

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Dados da {i + 1}º pessoa");
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Idade: ");
    var age = int.Parse(Console.ReadLine()!);
    Console.Write("Altura: ");
    var height = double.Parse(Console.ReadLine()!, locale);

    persons.Add(new Person(name, age, height));
}

var avgHeight = persons.DefaultIfEmpty().Average(p => p!.Height);
var personsUnderSixTeen = persons.Where(p => p.Age < 16).Select(p => p.Name).ToList();
var percentageUnderSixTeen = (double)personsUnderSixTeen.Count / n * 100;

Console.WriteLine();
Console.WriteLine($"Altura média: {avgHeight.ToString("F2", locale)}");
Console.WriteLine($"Pessoas com menos de 16 anos: {percentageUnderSixTeen.ToString("F2", locale)}%");
personsUnderSixTeen.ForEach(Console.WriteLine);