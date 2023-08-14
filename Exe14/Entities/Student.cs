namespace Exe14.Entities;

public class Student
{
    public string? Name { get; set; }
    public double Grade1 { get; set; }
    public double Grade2 { get; set; }

    public Student(string? name, double grade1, double grade2)
    {
        Name = name;
        Grade1 = grade1;
        Grade2 = grade2;
    }

    public double FinalGrade()
    {
        return (Grade1 + Grade2) / 2.0;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}