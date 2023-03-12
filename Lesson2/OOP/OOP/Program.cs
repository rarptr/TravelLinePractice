using System.ComponentModel;

namespace Practic;

static class Program
{
    public static void Main()
    {
        var p = new Person()
        {
            FirstName = "FirstName",
            LastName = "LastName",
        };
        Console.WriteLine(p.FirstName);
        Console.WriteLine(p.LastName);

        //try
        //{
        //    p.Age = -1;
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("wrong number");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    throw;
        //}

        var s = new Student()
        {
            FirstName = "FName",
            LastName = "LName",
            StudentId = 1
        };
        Console.WriteLine((Person)s);
    }

}

interface IPerson
{
    string FirstName { get; }
    string LastName { get; }
}

public class Person : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age
    {
        get => Age;
        set
        {
            ValidateAge(value);
            _age = value;
        }
    }

    private int _age;
    public Person()
    {

    }

    private void ValidateAge(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Age is wrong." + nameof(value));
        }
    }

    public override string ToString()
    {
        return $"Student: name: {FirstName}, last name: {LastName}. Not id";
    }
}

public class Student : Person
{
    public int StudentId { get; set; }


    public override string ToString()
    {
        return $"Student: name: {FirstName}, last name: {LastName}, id: {StudentId}";
    }
}

class Worker : Person
{

}