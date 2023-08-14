Console.Write("Quantos valores vai ter cada vetor? ");
var n = int.Parse(Console.ReadLine()!);

var vectorA = new int[n];
var vectorB = new int[n];
var vectorC = new int[n];

Console.WriteLine("Digite os valores do vetor A");
for (var i = 0; i < n; i++)
{
    vectorA[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Digite os valores do vetor B");
for (var i = 0; i < n; i++)
{
    vectorB[i] = int.Parse(Console.ReadLine()!);
}

for (var i = 0; i < n; i++)
{
    vectorC[i] = vectorA[i] + vectorB[i];
}

Console.WriteLine("Vetor resultate");
vectorC.ToList().ForEach(Console.WriteLine);