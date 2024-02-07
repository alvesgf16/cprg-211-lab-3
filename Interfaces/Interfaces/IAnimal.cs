namespace Interfaces;

public interface IAnimal
{
  public string Name { get; set; }
  public string Colour { get; set; }
  public int Height { get; set; }
  public int Age { get; set; }
  public abstract void Eat();
  public string Cry();
}
