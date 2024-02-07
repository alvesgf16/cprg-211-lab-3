namespace Interfaces;

public class Cat(string name, string colour, int height, int age) : IAnimal
{
    public Cat(string name) : this(name, "Black", 24, 8) { }
    
    public string Name { get; set; } = name;
    public string Colour { get; set; } = colour;
    public int Height { get; set; } = height;
    public int Age { get; set; } = age;

    public string Cry() => "Meow!";

    public void Eat() => Console.WriteLine("Cats eat mice");
}
