# C#
## My learning progress about C# and .Net
### Part 1 - C# Tutorial - Introduction.avi
Using System declaration
The namespace declaration, using System, indicates that you are using the System namespace. If  you omit the using System, declaration, then you have to use the fully qualified name of the Console class. A namespace is used to organize your code and is collection of classes, interfaces, structs, enums and delegates. We will discuss about namespaces in detail in a later session.

Purpose of Main() method - Main method is the entry point into your application.

### Part 2 - C# Tutorial - Reading and writing to a console
<img width="392" alt="image" src="https://user-images.githubusercontent.com/57111980/216837554-f87ce10d-c2e3-46fa-9695-863ae98bac6a.png">
To write to it we use Console.WriteLine and to read(input) we use Console.ReadLine().

Since, we are writing to console, so we will use Console.Write

### Part 2 - C# Tutorial - Data types
A variable in C# must be a specified data type:
![image](https://user-images.githubusercontent.com/57111980/217227481-8d6fcc38-04fe-43b0-8acf-2b44de23916e.png)
Numbers:
Integer types stores whole numbers, positive or negative (such as 123 or -456), without decimals. Valid types are int and long. Which type you should use, depends on the numeric value.

Floating point types represents numbers with a fractional part, containing one or more decimals. Valid types are float and double.

Integer Types:
The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.

Floating Point Types:
You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.

The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:
