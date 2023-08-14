using Exe03.Entities;

Console.Write("Quantos quartos serão alugados: ");
var n = int.Parse(Console.ReadLine()!);

var vector = new Rent[10];

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Reserva #{i + 1}");
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Quarto: ");
    var room = int.Parse(Console.ReadLine()!);

    vector[room] = new Rent() { Name = name, Email = email, Room = room};
}

var rents = vector.Where(x => x != null).ToList();

Console.WriteLine();
Console.WriteLine("Quartos ocupados");
rents.ForEach(Console.WriteLine);
