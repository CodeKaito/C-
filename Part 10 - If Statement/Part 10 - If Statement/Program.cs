// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number");

int UserNumber = int.Parse(Console.ReadLine());

if (UserNumber == 1)
{
    Console.WriteLine("your number is 1");
}
if (UserNumber == 2)
{
    Console.WriteLine("your number is 2");
}
if (UserNumber == 3)
{
    Console.WriteLine("your numbers is 3");
}
if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
{
    Console.WriteLine("your number is not between 1 and 3");
}

