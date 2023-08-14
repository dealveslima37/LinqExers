Console.Write("Quantos numeros voce vai digitar? ");
var n = int.Parse(Console.ReadLine()!);

var vector = new int[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um número: ");
    vector[i] = int.Parse(Console.ReadLine()!);
}

var negativeNumbers = vector.Where(num => num < 0).ToList();

negativeNumbers.ForEach(Console.WriteLine);


