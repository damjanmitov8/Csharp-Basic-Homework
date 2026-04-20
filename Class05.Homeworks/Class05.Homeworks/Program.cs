using Class05.Homeworks;
#region Exercises 2 
//Create a class Dog.

//Add properties:

//Name
//Race
//Color
//Add methods:

//Eat → prints “The dog is now eating.”
//Play → prints “The dog is now playing.”
//ChaseTail → prints “The dog is now chasing its tail.”
//Ask the user to:

//Enter dog data
//Choose one of the actions
//Call the selected method.

Console.WriteLine("Enter name of the dog");
string name = Console.ReadLine();
Console.WriteLine("Enter race of the dog");
string race = Console.ReadLine();
Console.WriteLine("Enter color of the dog");
string color = Console.ReadLine();

Dog dog = new Dog()
{
    Name = name,
    Color = color,
    Race = race
};
Console.WriteLine("What do you want to do your dog ?");
Console.WriteLine("1 - Eat \n2 - Play \n3 - Chase Tail");

bool inputPrased = int.TryParse(Console.ReadLine(), out int input);
if (1 == input)
{
    dog.Eat();
}
else if (2 == input)
{
    dog.Play();
}
else if (3 == input)
{
    dog.ChaseTail();
}
#endregion

#region Exercises 3 
//Create a class Student with properties:

//Name
//Academy
//Group
//Create an array with 5 Student objects.

//Ask the user to enter a name:

//If the student exists → print the information
//If not → print an error message

Student[] students = new Student[]
{
    new Student("John","C# Academy","Group 1"),
    new Student("Jane","JS Academy","Group 2"),
    new Student("Bob","Python Academy","Group 3"),
    new Student("Alice","Java Academy","Group 4"),
    new Student("Tom","C++ Academy","Group 5")
};
Console.WriteLine("------------------------------------------");
Console.WriteLine("Enter the name of the student");
string inputName = Console.ReadLine();
bool studentExists = false;
foreach (var student in students)
{
    if(student.Name == inputName)
    {
        studentExists = true;
        Console.WriteLine($"{student.Name} studying {student.Academy} in {student.Group}");
    }
}
if(studentExists == false)
{
    Console.WriteLine("Student not found");
}

    



#endregion


