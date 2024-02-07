namespace Interfaces;

public class Dog(string name, string colour, int height, int age) : IAnimal
{
    public Dog(string name) : this(name, "Caramel", 62, 7) { }

    public string Name { get; set; } = name;
    public string Colour { get; set; } = colour;
    public int Height { get; set; } = height;
    public int Age { get; set; } = age;

    public string Cry() => "Woof!";

    public void Eat() => Console.WriteLine("Dogs eat meat");
}
