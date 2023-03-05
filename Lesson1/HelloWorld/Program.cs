using HelloWorld;

public static class Program
{
    public static void Main()
    {
        Person person = new Person("Cat");

        //person.SetName("Dog");

        person.Name = "Dog";

        Console.WriteLine(person.Name);
    }
}
