# C#
## My learning progress about C# and .Net

- ### Part 1 - C# Tutorial - Introduction.avi 
Using System declaration
The namespace declaration, using System, indicates that you are using the System namespace. If  you omit the using System, declaration, then you have to use the fully qualified name of the Console class. A namespace is used to organize your code and is collection of classes, interfaces, structs, enums and delegates. We will discuss about namespaces in detail in a later session.

Purpose of Main() method - Main method is the entry point into your application.

- ### Part 2 - C# Tutorial - Reading and writing to a console
<img width="392" alt="image" src="https://user-images.githubusercontent.com/57111980/216837554-f87ce10d-c2e3-46fa-9695-863ae98bac6a.png">
To write to it we use Console.WriteLine and to read(input) we use Console.ReadLine().

Since, we are writing to console, so we will use Console.Write

- ### Part 3 - C# Tutorial - Data types
A variable in C# must be a specified data type:
![image](https://user-images.githubusercontent.com/57111980/217227481-8d6fcc38-04fe-43b0-8acf-2b44de23916e.png)
Numbers:
Integer types stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are int and long. Which type you should use, depends on the numeric value.

Floating point types represents numbers with a fractional part, containing one or more decimals. Valid types are float and double.

Integer Types:
The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.

Floating Point Types:
You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.

The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles.

- ### Part 13 - C# Tutorial - while loop in c#
The while loop loops through a block of code as long as a specified condition is True:
````
do 
{
  // code block to be executed
}
while (condition);
````
#### Do not forget to increase the variable used in the condition, otherwise the loop will never end!

- ### Part 14 - C# Tutorial - do while loop in c#
The example below uses a do/while loop. The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested:
````
int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);
````
In our example, if we want to do what we are doing with the IF statement we need the "DO WHILE" function.
````
Console.WriteLine("Please enter your target?");
int UserTarget = int.Parse(Console.ReadLine());

int Start = 0;

while (Start <= UserTarget)
{
    Console.WriteLine(Start);
    Start++;
}
````

With the "DO WHILE" loop we can iterate the entire code until the condition become "True":
````
string UserChoice = "";

do
{
    Console.WriteLine("Please enter your target");
    int UserTarget = int.Parse(Console.ReadLine());

    int Start = 0;

    while (Start <= UserTarget)
    {
        Console.Write(Start + " ");
        Start = Start + 2;
    }



    do
    {
        Console.WriteLine("Do you want to continue - Yes or No ?");

        UserChoice = Console.ReadLine().ToUpper();

        if (UserChoice != "YES" && UserChoice != "NO")
        {
            Console.WriteLine("Invalid choice, please say Yes or No");
        }
    } while (UserChoice != "YES" && UserChoice != "NO");
} while (UserChoice == "YES");
````

- ### Part 15 - C# Tutorial - for and foreach loops in c#
When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
````
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}
````

Statement 1 is executed (one time) before the execution of the code block.

Statement 2 defines the condition for executing the code block.

Statement 3 is executed (every time) after the code block has been executed.

````
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}
````

Example:
````
int[] Numbers = new int[3];

Numbers[0] = 101;
Numbers[1] = 102;
Numbers[2] = 103;

int i = 0;
while (1 < Numbers.Length)
{
    Console.WriteLine(Numbers[i]);
    i++;
}
````

It's the same thing if we write the condition with the for loop, same way but more correct:
````
for (int j = 0; j <Numbers.Length; j++)
{
    Console.WriteLine(Numbers[j]);
}
````

It is also possible to place a loop inside another loop. This is called a nested loop.
The "inner loop" will be executed one time for each iteration of the "outer loop":
````
// Outer loop
for (int i = 1; i <= 2; ++i) 
{
  Console.WriteLine("Outer: " + i);  // Executes 2 times

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}
````
