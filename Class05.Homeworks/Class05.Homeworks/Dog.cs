

namespace Class05.Homeworks;

public class Dog
{
    public string Name { get; set; }
    public string Race { get; set; }
    public string Color { get; set; }
    

    public void Eat()
    {
        Console.WriteLine("The dog is now eating !");
    }

    public void Play()
    {
        Console.WriteLine("The dog is now playing !");
    }

    public void ChaseTail()
    {
        Console.WriteLine("The dog is now chasing its tail !");
    }
}
