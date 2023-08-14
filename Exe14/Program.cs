using System.Globalization;
using Exe14.Entities;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantos alunos serao digitados? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new Student[n];

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Digite nome, primeira e segunda nota do {i + 1}º aluno:");
    var name = Console.ReadLine();
    var grade1 = double.Parse(Console.ReadLine()!, locale);
    var grade2 = double.Parse(Console.ReadLine()!, locale);

    vector[i] = new Student(name, grade1, grade2);
}

var aproved = vector
    .Where(s => s.FinalGrade() >= 6.0)
    .ToList();

Console.WriteLine();
Console.WriteLine("Alunos aprovados");
aproved.ForEach(s => Console.WriteLine($"{s.Name} || Nota final {s.FinalGrade().ToString("F2", locale)}"));