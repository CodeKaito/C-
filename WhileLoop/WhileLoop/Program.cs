// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your target?");
int UserTarget = int.Parse(Console.ReadLine());

int Start = 0;

while (Start <= UserTarget)
{
    Console.WriteLine(Start);
    Start++;
}