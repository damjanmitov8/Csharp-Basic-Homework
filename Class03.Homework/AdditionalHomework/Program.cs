#region Task 1

//Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.2:
//3
//Enter integer no.3:
//7
//Enter integer no.4:
//3
//Enter integer no.5:
//2
//Enter integer no.6:
//8
//Expected Output:
//The result is: 14

using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

int[] numbers = new int[6];
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1}");
    bool parsedNum = int.TryParse(Console.ReadLine(), out int number);
    numbers[i] = number;

    if (numbers[i] % 2 == 0) 
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"The result of even numbers is {sum}");



#endregion

#region Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] {"Damjan", "Martin", "Ognen", "David", "Stefan" };

Console.WriteLine("Enter student group(1 or 2)");
bool parsedGroup = int.TryParse(Console.ReadLine(), out int group);

    if(group == 1)
    {
        Console.WriteLine("The students in G1 are:");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }

    } else if(group == 2)
    {
        Console.WriteLine("The students in G2 are:");
            foreach (string student in studentsG2)
            {
            Console.WriteLine(student);
            }
    }

#endregion