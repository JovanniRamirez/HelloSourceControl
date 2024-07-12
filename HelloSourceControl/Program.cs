// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, GitHub!");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Number: {i}");
}

int num = 1; 

while (num < 10)
{
    num *= 2; 
    Console.WriteLine(num);
}
Console.WriteLine($"Number multiplied by 2 until reaching 10 is {num}");

Console.WriteLine("Enter age");
int userAge = Convert.ToInt32(Console.ReadLine());
int yearBorn = DateTime.Now.Year - userAge;
Console.WriteLine($"User year they were born is estimated at: {yearBorn}.");