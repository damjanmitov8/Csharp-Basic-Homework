using MyLibary.Enum;

namespace MyLibary.Models;

public class Manager : Employee
{
    private double Bonus { get; set; }


    public Manager(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
        Role = Role.Manager;
        Salary = 500;
    }

    public void AddBonus(double bonus)
    {
        Bonus += bonus;
    }

    public override double GetSalary()
    {
        return Salary + Bonus;
    }
}

