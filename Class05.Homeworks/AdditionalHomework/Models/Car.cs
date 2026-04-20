
namespace AdditionalHomework.Models;

public class Car
{
    public string Model { get; set; }
    public int Speed { get; set; }
    public Driver Driver { get; set; }

    public Car(string model, int speed, Driver driver)
    {
        Model = model;
        Speed = speed;
        Driver = driver;
    }


    public double CalculateSpeed(Driver driver)
    {
        return Speed * driver.Skill;
    }

    public void RaceCars(Car car1, Car car2)
    {
        double car1Speed = car1.CalculateSpeed(Driver);
        double car2Speed = car2.CalculateSpeed(Driver);
        if (car1Speed > car2Speed)
        {
            Console.WriteLine($"{car1.Model} wins the race with {car1Speed} by driver called {car1.Driver.Name}");
        } else
        {
            Console.WriteLine($"{car2.Model} wins the race with {car2Speed} by driver called {car2.Driver.Name}");
        }
    }
};
