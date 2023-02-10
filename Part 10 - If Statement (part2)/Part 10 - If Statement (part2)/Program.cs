// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number");

int UserNumber = int.Parse(Console.ReadLine());

if (UserNumber == 10 | UserNumber == 20)
{
    Console.WriteLine("Your number is 10 or 20");
}
else
{
    Console.WriteLine("Your number is not 10 either 20");
}

// && - & means and 
// || - | means or