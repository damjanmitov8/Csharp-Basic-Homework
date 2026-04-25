using MyLibary.Models;

SalesPerson sp  = new SalesPerson("John", "Doe");
sp.PrintInfo();
sp.AddSuccesRevenue(3000);
sp.AddSuccesRevenue(3000);
Console.WriteLine($"Salary for {sp.FirstName} is {sp.GetSalary()}");

Manager m = new Manager("Damjan","Mitov");
m.AddBonus(5000);
m.PrintInfo();
Console.WriteLine($"Salary for {m.FirstName} is {m.GetSalary()}");



