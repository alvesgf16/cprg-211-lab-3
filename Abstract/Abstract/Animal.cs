namespace Abstract;

internal abstract class Animal(string name, string colour, int age)
{
    public string Name { get; set; } = name;
    public string Colour { get; set; } = colour;
    public int Age { get; set; } = age;

    public abstract void Eat();
}
