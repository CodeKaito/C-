# My learning progress about C# and .Net

### Index

1. [ Introduction. ](#introduction)
2. [ Reading and writing to a console. ](#part2)
3. [ Data types. ](#part3)
8. [ Arrays. ](#part8)
9. [ If statement. ](#part10)
13. [ While loop. ](#part13)
15. [ For loop. ](#part15)


<a name="introduction"></a>
- ## Part 1 - Introduction
Using System declaration
The namespace declaration, using System, indicates that you are using the System namespace. If  you omit the using System, declaration, then you have to use the fully qualified name of the Console class. A namespace is used to organize your code and is collection of classes, interfaces, structs, enums and delegates. We will discuss about namespaces in detail in a later session.

Purpose of Main() method - Main method is the entry point into your application.

<a name="part2"></a>
- ## Part 2 - Reading and writing to a console
````
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}
````

Line 1: using System means that we can use classes from the System namespace.

Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.

Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.

Line 4: The curly braces {} marks the beginning and the end of a block of code.

Line 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
To write to it we use Console.WriteLine and to read(input) we use Console.ReadLine().

Line 7: Another thing that always appear in a C# program, is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.

Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".

If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

Note: Every C# statement ends with a semicolon ;.

Note: C# is case-sensitive: "MyClass" and "myclass" has different meaning.

Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename. To run the example above on your computer, make sure that C# is properly installed: Go to the Get Started Chapter for how to install C#. The output should be:

Since, we are writing to console, so we will use Console.WriteLine() method.

- ### User Input
You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.

In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName:
````
// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);
````

<a name="part3"></a>
- ## Part 3 - Data types
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

<a name="part8"></a>
- ### Part 8 - Arrays
Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

To declare an array, define the variable type with square brackets:
````
string[] cars;
````

We have now declared a variable that holds an array of strings.

To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:
````
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
````

You access an array element by referring to the index number.

This statement accesses the value of the first element in cars:
````
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo
````

To find out how many elements an array has, use the Length property:
````
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4
````

<a name="part10"></a>
- ### Part 10 - If statement


<a name="part13"></a>
- ### Part 13 - While loop
The while loop loops through a block of code as long as a specified condition is True:
````
do 
{
  // code block to be executed
}
while (condition);
````
#### Do not forget to increase the variable used in the condition, otherwise the loop will never end!

- ### Do while loop in c#
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

<a name="part15"></a>
- ## Part 15 - For and foreach loops
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
The number of times that the inner loop will be executed is indicated by the Statement 2 moltiplicated by the Statement 2 of the first loop.
- ### Break statement
You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.

The break statement can also be used to jump out of a loop.

This example jumps out of the loop when i is equal to 4:
````
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}
````
- ### Continue statement
The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

This example skips the value of 4:
````
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}
````

- ### Foreach statement
There is also a foreach loop, which is used exclusively to loop through elements in an array:
````
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
````

For example: 
````
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
````
