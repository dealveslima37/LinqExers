using System.Globalization;
using Exe04.Entities;

var locale = CultureInfo.InvariantCulture;

Console.Write("Quantos funcionários serão registrados: ");
var n = int.Parse(Console.ReadLine()!);

List<Employee> employees = new();

for (var i = 0; i < n; i++)
{
    Console.WriteLine($"Funcionário {i + 1}");
    Console.Write("Id: ");
    var id = int.Parse(Console.ReadLine()!);
    Console.Write("Nome: ");
    var name = Console.ReadLine();
    Console.Write("Salário R$: ");
    var salary = double.Parse(Console.ReadLine()!, locale);

    employees.Add(new Employee(id, name, salary));
}

Console.Write("Entre com o id do funcionário que terá aumento: ");
var idEmp = int.Parse(Console.ReadLine()!);

var emp = employees.SingleOrDefault(e => e.Id == idEmp);

if (emp != null)
{
    Console.Write("Qual o valor da porcentagem: ");
    var percentage = double.Parse(Console.ReadLine()!, locale);

    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine($"Não existe funcionário com o id {idEmp}");
}

Console.WriteLine();
Console.WriteLine("Lista de funcionários atualizada");
employees.ForEach(Console.WriteLine);