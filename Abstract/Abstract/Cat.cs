namespace Abstract;

internal class Cat(string name, string colour = "Black", int age = 8) : Animal(name, colour, age)
{
    public override void Eat() => Console.WriteLine("Cats eat mice.");
}
