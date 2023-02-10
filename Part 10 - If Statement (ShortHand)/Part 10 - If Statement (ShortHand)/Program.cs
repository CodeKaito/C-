Console.WriteLine("Insert a number");

int time = int.Parse(Console.ReadLine());
/*
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
*/

// variable = (condition) ? expressionTrue :  expressionFalse;

string result = (time < 18) ? "Good day.." : "Good evening..";
Console.WriteLine(result);
