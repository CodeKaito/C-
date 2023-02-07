// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your target");
int UserTarget = int.Parse(Console.ReadLine());

int Start = 0;

while (Start<=UserTarget)
{
    Console.Write(Start + "");
    Start++;
}

string UserChoice = "";

do
{
    Console.WriteLine("Do you want to continue - Yes or No ?");

    if (UserChoice != "Yes" && UserChoice != "No")
    {
        Console.WriteLine("Invalid choice");
    } while (UserChoice != "Yes" && UserChoice != "No")
    {

    }
}
