
#region Exercises 3

//In the existing Console Application:

//Create a new method called Substrings
//Inside the method use the string:
//"Hello from Avenga Codecademy 2024"
//Ask the user to enter a number n
//Print the first n characters
//Print the length of the new string
//Try to handle all scenarios

void Substring()
{
    string msg = "Hello from Avenga Codecademy 2024";
    Console.WriteLine(msg);

    Console.WriteLine("Enter a number");
    bool parsedInput = int.TryParse(Console.ReadLine(), out int startIndex);

    if (!parsedInput)
    {
        Console.WriteLine("Invalid input ! You must enter a number");
    }
    else if (startIndex < 0)
    {
        Console.WriteLine("You cant enter a negative numbers");
    }
    else if (startIndex > msg.Length)
    {
        Console.WriteLine("You can not enter a number higher of msg length");
    }
    else
    {
        string newMsg = msg.Substring(0, startIndex);
        Console.WriteLine($"This is the new message: {newMsg}");
        Console.WriteLine($"Length of the new message is: {newMsg.Length}");
    }
}

Substring();

#endregion

#region Exercises 4

//Print the date that is 3 days from now
//Print the date that is 1 month from now
//Print the date that is 1 month and 3 days from now
//Print the date 1 year and 2 months ago
//Print only the current month
//Print only the current year

DateTime addedDays = DateTime.Now.AddDays(3);
Console.WriteLine($"The date that is 3 days from now is: {addedDays}");
DateTime addedMonth = DateTime.Now.AddMonths(1);
Console.WriteLine($"The date that is 1 month from now is {addedMonth}");
DateTime addedMonthsAndDays = DateTime.Now.AddMonths(1).AddDays(3);
Console.WriteLine($"The date that is 1 month and 3 days from now is {addedMonthsAndDays}");
DateTime addedYearAndMonth = DateTime.Now.AddYears(1).AddMonths(2);
Console.WriteLine($"The date that is 1 year and 2 month from now is {addedYearAndMonth}");
var currentMonth = DateTime.Now.ToString("M MMMM");
Console.WriteLine($"Current month is: {currentMonth}");
int currentYear = DateTime.Now.Year;
Console.WriteLine($"Current years is: {currentYear}");

#endregion

#region Additonal Homework

//Task
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Now;
    int age = today.Year - birthday.Year;
    if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
    {
        age--;
    }
    return age;

 
}
AgeCalculator(new DateTime(2002,01,26));

void UserAge()
{
    Console.WriteLine("Enter your birthday (yyyy/MM/dd)");
    bool parsedDate = DateTime.TryParse(Console.ReadLine(), out DateTime userInput);
    if (!parsedDate)
    {
        Console.WriteLine("Invalid input ! You must enter a date");
    };

    int age = AgeCalculator(userInput);
    Console.WriteLine($"You are {age} years old");

}
UserAge();
#endregion
