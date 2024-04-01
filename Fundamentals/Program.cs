// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Age = 35;

string Name = "Spencer";

Console.WriteLine($"My name is {Name} I am {Age} years old");

if (Age > 21)
{
    // 
}

string[] Strings = new string[3];
Console.WriteLine(Strings[1]);

int[] Integers = new int[6];
Console.WriteLine(Integers[4]);
// Console.WriteLine(Integers[7]); //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//    at Program.<Main>$(String[] args) in C:\stacks\CSharp\Apr24\Fundamentals\Program.cs:line 20

for (int i = 0; i < Integers.Length; i++)
{
    Console.WriteLine(Integers[i]);
}

foreach (int num in Integers)
{
    Console.WriteLine(num);
    // num = 9; can't do this, foreach is essentially read only
}

// List<string> Names = ["Christian", "Shawn", "Bob"]; 
List<string> Names = new(); 
Names.Add("Christian");
Names.Add("Shawn");
Names.Add("Bob");

Names.ForEach(Console.WriteLine);

Dictionary<string, int> PetAges = new()
{
    {"Wiley",4},
    {"Honey",4}
};

// PetAges.Add("Wiley",999); // this will be runtime error, can't re-add same key
PetAges["Wiley"] = 999;

foreach (KeyValuePair<string,int> entry in PetAges)
{
    Console.WriteLine($"{entry.Key} is {entry.Value} years old");
    
}
