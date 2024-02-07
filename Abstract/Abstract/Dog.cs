namespace Abstract;

internal class Dog(string name, string colour = "Caramel", int age = 7) : Animal(name, colour, age)
{
    public override void Eat() => Console.Write("Dogs eat meat.");
}
