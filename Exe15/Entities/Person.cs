namespace Exe15.Entities;

public class Person
{
    public double Height { get; set; }
    public string? Genre { get; set; }

    public Person(double height, string? genre)
    {
        Height = height;
        Genre = genre;
    }
}