namespace Exe07.Entities;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

    public Person(string? name, int age, double height)
    {
        Name = name;
        Age = age;
        Height = height;
    }
    
}