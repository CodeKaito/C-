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

---------------------------------------------------------

1. [ Method.](#part16)
      - [ Method Parameters ](#methodparameters)
      - [ Default Parameters ](#defaultparameters)
      - [ Return Values ](#returnvalues)
      - [ Named Arguments ](#namedarguments)
      - [ Method Overloading ](#methodoverloading)
2. [ Classes. ](#classes)
      - [ Classes/Objects ](#objects)
      - [ Class Members ](#members)
      - [ Constructors ](#constructors)
      - [ Access Modifiers ](#modifiers)
      - [ Properties ](#properties)
      - [ Inheritance ](#inheritance)
      - [ Polymorphism ](#polymorphism)
      - [ Abstraction ](#abstraction)
      - [ Interface ](#interface)
      - [ Enums ](#enums)
      - [ Files ](#files)
      - [ Exception ](#expection)


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

⚠️ Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename.

⚠️ Note: In C#, the Main method is the entry point of the application, that is, the first method that runs when the application starts. The string[] args parameter is used to pass command-line arguments to the application.

Command-line arguments are strings that are passed to the application at startup. The args parameter is an array of strings representing these arguments. This means that you can access each argument passed to the application via the args array. For example, args[0] represents the first argument passed to the application.

The string[] args parameter is not required, but it is a common convention to use this name for the parameter representing command-line arguments. You can also use another name for the parameter, but this could cause confusion for other developers reading your code.

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

### Parameters and Arguments

Information can be passed to methods as parameter. Parameters act as variables inside the method.

They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.

The following example has a method that takes a `string` called `fname` as parameter. When the method is called, we pass along a first name, which is used inside the method to print the full name:

Example:
````
static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
  MyMethod("Liam");
  MyMethod("Jenny");
  MyMethod("Anja");
}

// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes
````

`When a parameter is passed to the method, it is called an argument. So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.`

### Multiple Parameters

You can have as many parameters as you like, just separate them with commas:

Example:

````
static void MyMethod(string fname, int age) 
{
  Console.WriteLine(fname + " is " + age);
}

static void Main(string[] args)
{
  MyMethod("Liam", 5);
  MyMethod("Jenny", 8);
  MyMethod("Anja", 31);
}

// Liam is 5
// Jenny is 8
// Anja is 31
````

⚠️ Note: when you are working with multiple parameters, the method call must have the same number of arguments as there are parameters, and the arguments must be passed in the same order.

<a name="defaultparameters"></a>
- ## Part 16 - Default Parameters

### Default Parameter Value

You can also use a default parameter value, by using the equals sign (=).

If we call the method without an argument, it uses the default value ("Norway"):

Example:

````
static void MyMethod(string country = "Norway") 
{
  Console.WriteLine(country);
}

static void Main(string[] args)
{
  MyMethod("Sweden");
  MyMethod("India");
  MyMethod();
  MyMethod("USA");
}

// Sweden
// India
// Norway
// USA
````

⚠️ Note: A parameter with a default value, is often known as an "optional parameter". From the example above, country is an optional parameter and "Norway" is the default value.

<a name="returnvalues"></a>
- ## Part 16 - Return Values
### Return Values
In the previous page, we used the `void` keyword in all examples, which indicates that the method should not return a value.

If you want the method to return a value, you can use a primitive data type (such as `int` or `double`) instead of `void`, and use the `return` keyword inside the method:

Example:
````
static int MyMethod(int x) 
{
  return 5 + x;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
}

// Outputs 8 (5 + 3)
````
This example returns the sum of a method's two parameters:

Example:
````
static int MyMethod(int x, int y) 
{
  return x + y;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(5, 3));
}

// Outputs 8 (5 + 3)
````

You can also store the result in a variable (recommended, as it is easier to read and maintain):

Example:
````
static int MyMethod(int x, int y) 
{
  return x + y;
}

static void Main(string[] args)
{
  int z = MyMethod(5, 3);
  Console.WriteLine(z);
}

// Outputs 8 (5 + 3)
````

<a name="namedarguments"></a>
- ## Part 16 - Named Arguments
### Named Arguments
It is also possible to send arguments with the `key: value` syntax.

That way, the order of the arguments does not matter:

Example:
````
static void MyMethod(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}

static void Main(string[] args)
{
  MyMethod(child3: "John", child1: "Liam", child2: "Liam");
}

// The youngest child is: John
````

<a name="methodoverloading"></a>
- ## Part 16 - Method Overloading
### Method Overloading
With method overloading, multiple methods can have the same name with different parameters:

Example:
````
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)
````
Consider the following example, which have two methods that add numbers of different type:

Example:
````
static int PlusMethodInt(int x, int y)
{
  return x + y;
}

static double PlusMethodDouble(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int myNum1 = PlusMethodInt(8, 5);
  double myNum2 = PlusMethodDouble(4.3, 6.26);
  Console.WriteLine("Int: " + myNum1);
  Console.WriteLine("Double: " + myNum2);
}
````

Instead of defining two methods that should do the same thing, it is better to overload one.

In the example below, we overload the `PlusMethod` method to work for both `int` and `double`:

Example:
````
static int PlusMethod(int x, int y)
{
  return x + y;
}

static double PlusMethod(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int myNum1 = PlusMethod(8, 5);
  double myNum2 = PlusMethod(4.3, 6.26);
  Console.WriteLine("Int: " + myNum1);
  Console.WriteLine("Double: " + myNum2);
}
````

⚠️ Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.

<a name="classes"></a>
- ## Classes
### C# - What is OOP?
OOP stands for Object-Oriented Programming.

Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

Object-oriented programming has several advantages over procedural programming:

OOP is faster and easier to execute
OOP provides a clear structure for the programs
OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
OOP makes it possible to create full reusable applications with less code and shorter development time
Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.

<a name="objects"></a>
### What are Classes and Objects?
Classes and objects are the two main aspects of object-oriented programming.

So, a class is a template for objects, and an object is an instance of a class.

When the individual objects are created, they inherit all the variables and methods from the class.

Everything in C# is associated with classes and objects, along with its attributes and methods. For example: in real life, a car is an object. The car has attributes, such as weight and color, and methods, such as drive and brake.

A Class is like an object constructor, or a "blueprint" for creating objects.

To create a class, use the class keyword:
````
class Car 
{
  string color = "red";
}
````

When a variable is declared directly in a class, it is often referred to as a field (or attribute).

It is not required, but it is a good practice to start with an uppercase first letter when naming classes. Also, it is common that the name of the C# file and the class matches, as it makes our code organized. However it is not required (like in Java).

### Create an Object
An object is created from a class. We have already created the class named Car, so now we can use this to create objects.

To create an object of Car, specify the class name, followed by the object name, and use the keyword new:
````
class Car 
{
  string color = "red";

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
````

⚠️ Note that we use the dot syntax (.) to access variables/fields inside a class (myObj.color)

You can create multiple objects of one class:
````
class Car
{
  string color = "red";
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color);
    Console.WriteLine(myObj2.color);
  }
}
````

## License

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

Released 2023 by [CodeKaito](https://github.com/CodeKaito)

## Contributors

<a href="https://github.com/codekaito/csharp/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codekaito/csharp" />
</a>
