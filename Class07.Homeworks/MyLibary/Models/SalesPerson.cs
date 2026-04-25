using MyLibary.Enum;


namespace MyLibary.Models;

public class SalesPerson : Employee
{
    private double SuccesSaleRevenue { get; set; }


    public SalesPerson(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
        Role = Role.Sales;
        Salary = 500;
    }

    public void AddSuccesRevenue(double number)
    {
         SuccesSaleRevenue += number;
    }

    public override double GetSalary()
    {
        double bonus = 0;
        if(SuccesSaleRevenue <= 2000)
        {
            bonus = 500;
        }else if (SuccesSaleRevenue <= 5000)
        {
            bonus = 1000;

        }else if(SuccesSaleRevenue > 5000)
        {
            bonus = 1500;
        }

        return Salary + bonus;

    }
}
