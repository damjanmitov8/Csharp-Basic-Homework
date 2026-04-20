using AdditionalHomework.Models;
using System.Reflection.Metadata;

Driver bob = new Driver("Bob", 5);
Driver john = new Driver("John", 7);
Driver jane = new Driver("Jane", 6);
Driver chris = new Driver("Chris", 8);

Car bmw = new Car("BMW", 200, bob);
Car ferrari = new Car("Ferrari", 250, john);
Car audi = new Car("Audi", 220, jane);
Car mazda = new Car("Mazda", 180, chris);


Car chosenCar1 = null;
Car chosenCar2 = null;
Driver chosenDriver1 = null;
Driver chosenDriver2 = null;
while (true)
{
    for (int i = 1; i <= 2; i++)
    {
        Console.WriteLine($"Choose a car {i}:");
        Console.WriteLine("----------------");
        Console.WriteLine("1." + bmw.Model);
        Console.WriteLine("2." + ferrari.Model);
        Console.WriteLine("3." + audi.Model);
        Console.WriteLine("4." + mazda.Model);
        int selectedCar = Int32.Parse(Console.ReadLine());
        if(selectedCar > 4 || selectedCar < 1)
        {
            Console.WriteLine("Invalid car selection. Please try again.");
            i--;
            continue;
        }
   


        Console.WriteLine($"Choose a driver {i}:");
        Console.WriteLine("-------------------");
        Console.WriteLine("1." + bob.Name);
        Console.WriteLine("2." + john.Name);
        Console.WriteLine("3." + jane.Name);
        Console.WriteLine("4." + chris.Name);
        int selectedDriver = Int32.Parse(Console.ReadLine());
        if(selectedDriver > 4 || selectedDriver < 1)
        {
            Console.WriteLine("Invalid driver selection. Please try again.");
            i--;
            continue;
        }

        Car chosenCar;
        Driver choosenDriver;

        switch (selectedCar)
        {
            case 1:
                chosenCar = bmw;
                break;

            case 2:
                chosenCar = ferrari;
                break;

            case 3:
                chosenCar = audi;
                break;

            case 4:
                chosenCar = mazda;
                break;

            default:
                return;

        }

        switch (selectedDriver)
        {
            case 1:
                choosenDriver = bob;
                break;
            case 2:
                choosenDriver = john;
                break;
            case 3:
                choosenDriver = jane;
                break;
            case 4:
                choosenDriver = chris;
                break;
            default:
                return;

        }

        if (i == 1)
        {
            chosenCar1 = chosenCar;
            chosenDriver1 = choosenDriver;
        }
        else if (i == 2)
        {
            chosenCar2 = chosenCar;
            chosenDriver2 = choosenDriver;
        }
    }
    chosenCar1.Driver = chosenDriver1;
    chosenCar2.Driver = chosenDriver2;

    chosenCar1.RaceCars(chosenCar1, chosenCar2);

    Console.WriteLine("Race again? If you want to quit prees 'n'");
    string inputRace = Console.ReadLine();
    if(inputRace == "n")
    {
        break;
    }
}










