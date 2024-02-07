namespace Abstract;

class Program
{
    static void Main(string[] args)
    {
        // Create and display info for dog
        DisplayInfoFor(AnimalOfType("dog"));

        // Create and display info for cat
        DisplayInfoFor(AnimalOfType("cat"));
    }

    private static Animal AnimalOfType(string animalType) => animalType switch
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

    private static void DisplayInfoFor(Animal animal)
    {
        Console.WriteLine($"Name: {animal.Name}");
        Console.WriteLine($"Colour: {animal.Colour}");
        Console.WriteLine($"Age: {animal.Age}");
        animal.Eat();
    }
}