#region Exercises 3


string[] names = new string[] { "damjan", "martin", "ognen", "david", "stefan" };
string[] animals = new string[] { "lion", "elephant", "monkey", "tiger", "dog" };
string[] company = new string[] { "avenga", "multisped", "rio", "deni", "acer" };
string[] words = new string[] { "Hello", "Bye", "GoodBye", "How", "Arrays" };
string[] motorcycle = new string[] { "Honda", "BMW", "Yamaha", "Duccati", "Aprilia" };

double[] numbers = new double[] { 1.3, 2.2, 4.3, 22.1, 25, 2 };
double[] decimals = new double[] { 1.2, 1.5, 20.6, 21.22 };
double[] numbers1 = new double[] { 22.1, 52.21, 32.1, 23, 1, 12, 6 };
double[] numbers2 = new double[] { 253.2, 321.2, 121.2, 11.1, 125.2 };
double[] numbers3 = new double[] { 12.2, 1.1, 2.2, 55.2, 11.2 };

char[] bLetter = new char[] { 'b', 'd', 'w', 'q', 'f' };
char[] damjan = new char[] { 'd', 'a', 'm', 'j', 'a', 'n' };
char[] hello = new char[] { 'h', 'e', 'l', 'l', 'o' };
char[] coffe = new char[] { 'c', 'o', 'f', 'f', 'e' };
char[] tiger = new char[] { 't', 'i', 'g', 'e', 'r' };

bool[] flags = new bool[] { true, false, true, false, true };

int[][] wholeNumbers = new int[][]
{
    new int[]{20,10},
    new int[]{20,20},
    new int[]{30,10},
    new int[]{22,11},
    new int[]{42,21}

};

#endregion

#region Exercises 4
int[] num = new int[5];
int sum = 0;
Console.WriteLine("Enter five numbers");
for (int i = 0; i < num.Length; i++)
{
    bool parsedNum = int.TryParse(Console.ReadLine(), out int number);
    num[i] = number;
}
for (int i = 0; i < num.Length; i++)
{
    sum += num[i];
    Console.Write(num[i] + " ");
}
Console.ReadLine();
Console.WriteLine("The sum of the numbers is: " + sum);
#endregion

#region Exercises 5
string[] names1 = new string[0];
do
{
    Console.WriteLine("Enter a name");
    string input = Console.ReadLine();

    Array.Resize(ref names1, names1.Length + 1);
    names1[names1.Length - 1] = input;

    Console.WriteLine("Do you want to insert new name? If is no press enter N/n");
    input = Console.ReadLine();

    if (input == "N" || input == "n")
        break;
} while (true);

foreach (string name in names1)
{
    Console.WriteLine(name);
}

#endregion
