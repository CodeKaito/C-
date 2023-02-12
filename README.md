# My learning progress about C# and .Net

### Index

1. [ Introduction. ](#introduction)
2. [ Reading and writing to a console. ](#part2)
   - [ User Input. ](#usernput)
3. [ Data types. ](#part3)
8. [ Arrays. ](#part8)
9. [ If statement. ](#part10)
   - [ Else statement. ](#else)
   - [ Else if statement. ](#elseif)
   - [ Shorthand If-Else. ](#shorthand)
13. [ While loop. ](#part13)
      - [ Do while. ](#dowhile)
15. [ For loop. ](#part15)
      - [ Break. ](#break)
      - [ Continue. ](#continue)
      - [ Foreach. ](#foreach)
16. [ Method.](#part16)
      - [ Method Parameters ](#methodparameters)
      - [ Default Parameters ](#defaultparameters)


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

Line 1: `using System means that we can use classes from the System namespace.`

Line 2: `A blank line. C# ignores white space. However, multiple lines makes the code more readable.`

Line 3: `namespace is used to organize your code, and it is a container for classes and other namespaces.`

Line 4: `The curly braces {} marks the beginning and the end of a block of code.`

Line 5: `class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
To write to it we use Console.WriteLine and to read(input) we use Console.ReadLine().`

Line 7: `Another thing that always appear in a C# program, is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.`

Line 9: `Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".`

If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

⚠️ Note: Every C# statement ends with a semicolon ;.

⚠️ Note: C# is case-sensitive: "MyClass" and "myclass" has different meaning.

⚠️ Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename. To run the example above on your computer, make sure that C# is properly installed: Go to the Get Started Chapter for how to install C#. The output should be:

Since, we are writing to console, so we will use Console.WriteLine() method.

<a name="usernput"></a>
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
⚠️ Note: It's very important in C# to define the type of the data!

A variable in C# must be a specified data type:

| *Data Type* | *Size* | *Description* |
| :---  | :---: | :--- |
| int   | 4 bytes     | 	Stores whole numbers from -2,147,483,648 to 2,147,483,647    |
| long     | 	8 bytes       | 	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807      |
| float     | 	4 bytes       | 	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits      |
| double     | 	8 bytes       | 	Stores fractional numbers. Sufficient for storing 15 decimal digits      |
| bool    | 	1 bytes       | 	Stores true or false values      |
| char   | 	2 bytes     | 	Stores a single character/letter, surrounded by single quotes    |
| string     | 2 bytes per character       | Stores a sequence of characters, surrounded by double quotes      |

Numbers:
Integer types stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are int and long. Which type you should use, depends on the numeric value.

Floating point types represents numbers with a fractional part, containing one or more decimals. Valid types are float and double.

Integer Types:
The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.

Floating Point Types:
You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.

The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles.

<a name="part8"></a>
- ## Part 8 - Arrays
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
- ## Part 10 - If statement
Use the if statement to specify a block of C# code to be executed if a condition is True.
````
if (condition) 
{
  // block of code to be executed if the condition is True
}
  // Note that if is in lowercase letters. Uppercase letters (If or IF) will generate an error.
````

In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text:
````
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}
````

<a name="else"></a>
- ### Else statement
Use the else statement to specify a block of code to be executed if the condition is False.
````
if (condition)
{
  // block of code to be executed if the condition is True
} 
else 
{
  // block of code to be executed if the condition is False
}
````

<a name="elseif"></a>
- ### Else if statement
````
if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}
````

<a name="shorthand"></a>
- ### Shorthand If-Else (Binary operator)
````
variable = (condition) ? expressionTrue :  expressionFalse;
````

example: 
````
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
----------------------------------------------------------------
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
````

<a name="part13"></a>
- ## Part 13 - While loop
The while loop loops through a block of code as long as a specified condition is True:
````
do 
{
  // code block to be executed
}
while (condition);
````
⚠️ Do not forget to increase the variable used in the condition, otherwise the loop will never end!

<a name="dowhile"></a>
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

<a name="break"></a>
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

<a name="continue"></a>
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

<a name="foreach"></a>
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

<a name="part16"></a>
- ## Part 16 - Method
A `method` is a block of code which only runs when it is called.

You can pass data, known as parameters, into a method.

Methods are used to perform certain actions, and they are also known as `functions`.

Why use methods? To reuse code: define the code once, and use it many times.

- ### How to create a method?
A method is defined with the name of the method, followed by `parentheses ()`.
C# provides some pre-defined methods, which you already are familiar with, such as `Main()`,
but you can also create your own methods to perform certain actions:
````
class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}
````
- `MyMethod()` is the name of the method.
- `static` means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
- `void` means that this method does not have a return value. You will learn more about return values later in this chapter.

⚠️ Note: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.

- ### Call a Method
To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;

In the following example, `MyMethod()` is used to print a text (the action), when it is called:

Example:
````
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
}

// Outputs "I just got executed!"
````

A method can be used multiple times, for example:
````
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
  MyMethod();
  MyMethod();
}

// I just got executed!
// I just got executed!
// I just got executed!
````

<a name="methodparameters"></a>
- ## Part 16 - Method Parameters

## License

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

Released 2023 by [CodeKaito](https://github.com/CodeKaito)

## Contributors

<a href="https://github.com/codekaito/csharp/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codekaito/csharp" />
</a>
