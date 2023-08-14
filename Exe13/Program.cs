using Exe13.Entities;

Console.Write("Quantas pessoas voce vai digitar? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new Person[n];

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Dados da {i + 1}º pessoa");
    Console.Write("Nome ");
    var name = Console.ReadLine()!;
    Console.Write("Idade: ");
    var age = int.Parse(Console.ReadLine()!);

    vector[i] = new Person(name, age);
}

var maxAge = vector.Select(p => p.Age).Max();
var personOldest = vector
    .Where(p => p.Age == maxAge)
    .OrderBy(p => p.Name)
    .Select(p => new { p.Name })
    .ToList();


Console.WriteLine($"Pessoa mais velha {personOldest.FirstOrDefault()!.Name}");