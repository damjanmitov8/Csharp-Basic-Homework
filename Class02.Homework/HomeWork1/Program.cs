#region Exercises 4
//On one tree there are 12 branches with n apples on them.
//One basket can hold m apples.

//n = 8
//m = 5
//If a user enters the number of trees, calculate how many baskets are needed to collect all apples.
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

int treeBranches = 12;
int branchWithApples = 8; 
int basketHold = 5;
Console.WriteLine("Enter number of trees");
bool parsedInput = int.TryParse(Console.ReadLine(), out int input);
int treeAples = treeBranches * branchWithApples;
int numOfTrees = treeAples * input;
int basketNum = numOfTrees / basketHold;
Console.WriteLine("You need " + basketNum + " baskets to collect all apples");

#endregion

#region Exercises 5
//EXERCISE 5
//Create two variables and initialize them
//Determine which number is larger
//Determine whether the larger number is even or odd
int num1 = 2;
int num2 = 3;

if (num1 > num2)
{
    if (num1 % 2 == 0)
        Console.WriteLine("The larger number from " + num2 + " is " + num1 + " and that number is even");
    else
        Console.WriteLine("The larger number from " + num2 + " is " + num1 + " and that number is odd");
}
else
{
    if (num2 % 2 == 0)
        Console.WriteLine("The larger number from " + num1 + " is "  + num2 + " and that number is even");
    else
        Console.WriteLine("The larger number from " + num1 + " is "  + num2 + " and that number is odd");
}
#endregion

#region Exercises 6
//Ask the user to enter a number from 1 to 3:

//1 → “You got a new car!”
//2 → “You got a new plane!”
//3 → “You got a new bike!”
//Any other input → error message

Console.WriteLine("Enter a number from 1 to 3");
bool _ = int.TryParse(Console.ReadLine(),out int number);
switch (number)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("YOu got a new bike");
        break;

    default:
        Console.WriteLine("You must enter numbers from 1 to 3! Try Again!");
        break;
}
#endregion

#region Additonal HomeWorks
//Task 1
//Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ).
//Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.WriteLine("Enter the first number");
bool parsedNum1 = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Enter the second number");
bool parsedNum2 = int.TryParse(Console.ReadLine(), out int number2);
Console.WriteLine("Enter the operation you want to done");
string operations = Console.ReadLine();

int result;
switch (operations)
{
    case "+":
        result = number1 + number2;
        Console.WriteLine(result);
        break;
    case "-":
        result = number1 - number2;
        Console.WriteLine(result);
        break;
    case "*":
        result = number1 * number2;
        Console.WriteLine(result);
        break;
    case "/":
        if (number1 == 0 || number2 == 0)
        {
            Console.WriteLine("Can not divide with zero");
        }
        else
        {
            result = number1 / number2;
            Console.WriteLine(result);
        }
        break;
    default:
        Console.WriteLine("Error");
        break;
}

//Task 2
//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter first number");
bool parsedNum = int.TryParse(Console.ReadLine(), out int numberOne);
Console.WriteLine("Enter second number");
bool parsedNumSecond = int.TryParse(Console.ReadLine(), out int numberSecond);
Console.WriteLine("Enter third number");
bool parsedNumThird = int.TryParse(Console.ReadLine(), out int numberThird);
int averageNumber = (numberOne + numberSecond + numberThird) / 3;
Console.WriteLine("The average of " + numberOne + " " + numberSecond + " " + numberThird + " is " + averageNumber);

//Create new console application called “SwapNumbers”.
//Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

bool __ = int.TryParse(Console.ReadLine(), out int num);
bool ___ = int.TryParse(Console.ReadLine(), out int numTwo);
Console.WriteLine("After Swapping");
int temp = num;
num = numTwo;
numTwo = temp;
Console.WriteLine(num);
Console.WriteLine(numTwo);


#endregion
