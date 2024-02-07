namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = AnimalOfType("dog");

        IAnimal cat = AnimalOfType("cat");

        List<IAnimal> animals = [dog, cat, new Dog("Rex"), new Cat("Princess")];

        DisplayInfoFor(dog);
        DisplayInfoFor(cat);
        Console.WriteLine("\nNames of all the animals:");
        animals.ForEach(DisplayName);
    }

    private static IAnimal AnimalOfType(string animalType) => animalType switch
    {
        "dog" => new Dog(NameFor(animalType)),
        "cat" => new Cat(NameFor(animalType)),
        _ => throw new ArgumentException("Invalid animal type."),
    };

    private static string NameFor(string animalType)
    {
        Console.WriteLine($"Enter {animalType}'s name:");
        return Console.ReadLine()!;
    }

    private static void DisplayInfoFor(IAnimal animal) {
        Console.WriteLine($"Name: {animal.Name}");
        Console.WriteLine($"Colour: {animal.Colour}");
        Console.WriteLine($"Height: {animal.Height}");
        Console.WriteLine($"Age: {animal.Age}");
        animal.Eat();
        Console.WriteLine($"And say: {animal.Cry()}");

    }

    private static void DisplayName(IAnimal animal) => Console.WriteLine($"- {animal.Name}");
}
