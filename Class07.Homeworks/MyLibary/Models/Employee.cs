using MyLibary.Enum;

namespace MyLibary.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Role Role { get; set; }
    protected double Salary { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Hello I am {FirstName} {LastName} and my role is {Role}");
    }

    public virtual double GetSalary()
    {
        return Salary;
    }

}
