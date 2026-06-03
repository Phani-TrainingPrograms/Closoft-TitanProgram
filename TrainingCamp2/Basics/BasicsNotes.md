# C# Basics: Data Types, Type Conversions, `var`, Convert Class, Enums, Structs, and Functions

---

# Introduction to C#

C# (pronounced "C-Sharp") is a modern, object-oriented programming language developed by [Microsoft](https://www.microsoft.com?utm_source=chatgpt.com) as part of the .NET ecosystem. It is widely used for building desktop applications, web applications, cloud services, mobile applications, games, and enterprise software.

One of the reasons C# is popular among developers is its balance between simplicity and power. It provides strong type safety, automatic memory management through garbage collection, and a rich standard library that simplifies common programming tasks.

Think of C# as a highly organized workshop. Every tool has a specific purpose, every item has a designated place, and strict rules help prevent mistakes. This organization makes large software projects easier to develop and maintain.

![A conceptual image showing C# as the central language connecting web, desktop, cloud, and mobile applications](./images/placeholder.png)

---

# Understanding Data Types

## What Are Data Types?

A data type defines the kind of data a variable can store. Before a program can store information, it must know what kind of information it is dealing with.

Imagine a warehouse with different storage containers:

* Small boxes for storing numbers
* Large containers for storing text
* Special lockers for storing dates
* Separate bins for storing true/false values

Similarly, C# uses different data types to store different kinds of information efficiently.

---

## Why Data Types Matter

Data types are important because they:

* Determine how much memory is allocated for a value. A small number requires less memory than a large text string.
* Help the compiler detect programming errors before execution. For example, accidentally assigning text to a numeric variable can be caught immediately.
* Improve program performance because the system knows exactly how data should be processed.

---

## Categories of Data Types

C# data types are broadly divided into:

| Category        | Description                            | Examples                |
| --------------- | -------------------------------------- | ----------------------- |
| Value Types     | Store actual values directly in memory | int, double, char, bool |
| Reference Types | Store references to objects in memory  | string, arrays, classes |
| Pointer Types   | Store memory addresses                 | Used in unsafe code     |

---

## Common Value Types

### Integer Types

Integer types store whole numbers without decimal points.

| Type  | Size    | Range                     |
| ----- | ------- | ------------------------- |
| byte  | 1 byte  | 0 to 255                  |
| short | 2 bytes | -32,768 to 32,767         |
| int   | 4 bytes | ±2.1 billion              |
| long  | 8 bytes | Very large integer values |

Example:

```csharp
int age = 25;
long population = 8000000000;
```

### Real Number Types

These store decimal values.

| Type    | Precision              |
| ------- | ---------------------- |
| float   | Approximate            |
| double  | More precise           |
| decimal | Financial calculations |

Example:

```csharp
float price = 25.75f;
double distance = 1250.678;
decimal salary = 45000.50m;
```

### Character Type

Stores a single character.

```csharp
char grade = 'A';
```

### Boolean Type

Stores true or false values.

```csharp
bool isLoggedIn = true;
```

---

## Reference Types

Reference types store memory addresses pointing to actual objects.

### String

A string stores a sequence of characters.

```csharp
string name = "John";
```

### Array

Stores multiple values of the same type.

```csharp
int[] marks = { 80, 90, 95 };
```

---

## Real-World Example

Consider an online shopping application:

```csharp
string productName = "Laptop";
decimal price = 75000.99m;
int stock = 15;
bool inStock = true;
```

Each variable uses a different data type because the information being stored is fundamentally different.

---

# Data Type Conversions

## What Is Type Conversion?

Type conversion is the process of changing data from one type to another.

Imagine converting currency while traveling. Although the value remains conceptually the same, its representation changes. Similarly, data conversion changes how information is represented.

---

## Types of Conversion

### Implicit Conversion

Performed automatically when there is no risk of data loss.

Example:

```csharp
int number = 100;
double value = number;
```

Here, C# automatically converts the integer to a double.

### Conversion Flow

```text
byte → short → int → long → float → double
```

---

### Explicit Conversion (Casting)

Required when data loss may occur.

Example:

```csharp
double price = 99.99;
int amount = (int)price;
```

Output:

```text
99
```

The decimal portion is removed.

---

## Why Explicit Conversion Is Necessary

Suppose you pour water from a large bucket into a smaller bottle. Some water may spill.

Similarly, converting a larger data type into a smaller one may lose information.

---

## Real-World Example

```csharp
double percentage = 85.75;
int roundedPercentage = (int)percentage;
```

Output:

```text
85
```

The decimal value is discarded.

---

# The `var` Keyword

## What Is `var`?

The `var` keyword allows the compiler to automatically determine the variable's data type.

Example:

```csharp
var name = "David";
var age = 30;
var salary = 45000.50;
```

The compiler interprets these as:

```csharp
string name = "David";
int age = 30;
double salary = 45000.50;
```

---

## How It Works

The type is determined during compilation and cannot change later.

Example:

```csharp
var city = "London";
```

Equivalent to:

```csharp
string city = "London";
```

This is NOT allowed:

```csharp
var city = "London";
city = 100;
```

Because the variable is already identified as a string.

---

## Advantages of `var`

### Reduced Typing

It eliminates repetitive code when types are obvious.

```csharp
var employee = new Employee();
```

Instead of:

```csharp
Employee employee = new Employee();
```

### Better Readability

Complex object declarations become easier to read.

---

## When to Avoid `var`

Avoid using `var` when the data type is unclear.

Poor Example:

```csharp
var data = GetEmployeeDetails();
```

Better Example:

```csharp
EmployeeDetails data = GetEmployeeDetails();
```

This improves code readability.

---

## Real-World Example

```csharp
var totalAmount = 1500.75m;
var customerName = "Alice";
var isPremiumCustomer = true;
```

The compiler automatically determines the appropriate types.

---

# Convert Class

## What Is the Convert Class?

The `Convert` class provides methods for converting one data type into another.

It belongs to the `System` namespace.

Think of it as a universal translator that helps different data types communicate with each other.

---

## Why Use Convert?

Data often enters applications as strings:

* User input
* Configuration files
* Database records
* API responses

The Convert class transforms these strings into usable data types.

---

## Common Convert Methods

| Method              | Purpose             |
| ------------------- | ------------------- |
| Convert.ToInt32()   | Converts to int     |
| Convert.ToDouble()  | Converts to double  |
| Convert.ToBoolean() | Converts to bool    |
| Convert.ToDecimal() | Converts to decimal |
| Convert.ToString()  | Converts to string  |

---

## Example

```csharp
string ageText = "25";

int age = Convert.ToInt32(ageText);

Console.WriteLine(age);
```

Output:

```text
25
```

---

## Converting Multiple Types

```csharp
string salaryText = "45000.50";

decimal salary = Convert.ToDecimal(salaryText);

Console.WriteLine(salary);
```

---

## Real-World Example

User input:

```csharp
Console.Write("Enter your age: ");
string input = Console.ReadLine();

int age = Convert.ToInt32(input);
```

Without conversion, the input remains text and cannot be used for mathematical operations.

---

# Enums

## What Is an Enum?

An Enum (Enumeration) is a special type used to define a fixed set of named constants.

Instead of using meaningless numbers, enums provide readable names.

---

## Problem Without Enums

```csharp
int status = 1;
```

What does 1 mean?

* Active?
* Pending?
* Completed?

The meaning is unclear.

---

## Solution Using Enums

```csharp
enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered
}
```

Usage:

```csharp
OrderStatus status = OrderStatus.Shipped;
```

Now the code is self-explanatory.

---

## Default Values

```csharp
enum Days
{
    Monday,
    Tuesday,
    Wednesday
}
```

Values:

| Name      | Value |
| --------- | ----- |
| Monday    | 0     |
| Tuesday   | 1     |
| Wednesday | 2     |

---

## Custom Values

```csharp
enum UserRole
{
    Admin = 1,
    Manager = 2,
    Employee = 3
}
```

---

## Real-World Example

```csharp
enum PaymentStatus
{
    Pending,
    Success,
    Failed
}
```

```csharp
PaymentStatus payment = PaymentStatus.Success;
```

This makes business logic easier to understand and maintain.

---

# Structs

## What Is a Struct?

A struct is a user-defined value type that groups related data together.

Think of a struct as a small record card that stores related information in one package.

---

## Why Use Structs?

Structs are useful when:

* Data is small.
* Data logically belongs together.
* Object-oriented features are not heavily required.

---

## Struct Syntax

```csharp
struct Employee
{
    public int Id;
    public string Name;
}
```

Creating an object:

```csharp
Employee emp;

emp.Id = 101;
emp.Name = "John";
```

---

## Struct vs Class

| Feature     | Struct                | Class                      |
| ----------- | --------------------- | -------------------------- |
| Type        | Value Type            | Reference Type             |
| Storage     | Stack (typically)     | Heap                       |
| Inheritance | Not Supported         | Supported                  |
| Performance | Faster for small data | Better for complex objects |

---

## Example

```csharp
struct Point
{
    public int X;
    public int Y;
}
```

Usage:

```csharp
Point p;

p.X = 10;
p.Y = 20;
```

---

## Real-World Example

```csharp
struct Product
{
    public int ProductId;
    public string ProductName;
    public decimal Price;
}
```

A product record can be represented efficiently as a single structured unit.

![A diagram showing a struct containing multiple related fields grouped together](./images/placeholder.png)

---

# Functions

## What Is a Function?

A function is a reusable block of code that performs a specific task.

Think of a function like a vending machine:

* You provide input.
* The machine performs a process.
* You receive output.

---

## Why Functions Matter

Functions help:

* Reduce duplicate code.
* Improve maintainability.
* Increase readability.
* Simplify debugging.

---

## Function Syntax

```csharp
returnType FunctionName(parameters)
{
    // code
}
```

Example:

```csharp
int Add(int a, int b)
{
    return a + b;
}
```

---

## Calling a Function

```csharp
int result = Add(10, 20);

Console.WriteLine(result);
```

Output:

```text
30
```

---

## Function Components

| Component        | Purpose                  |
| ---------------- | ------------------------ |
| Return Type      | Specifies returned value |
| Function Name    | Identifies the function  |
| Parameters       | Accept input values      |
| Body             | Contains logic           |
| Return Statement | Sends result back        |

---

## Void Functions

Functions that do not return a value use `void`.

```csharp
void DisplayMessage()
{
    Console.WriteLine("Welcome");
}
```

Calling:

```csharp
DisplayMessage();
```

---

## Functions with Parameters

```csharp
void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}
```

Usage:

```csharp
Greet("Alice");
```

Output:

```text
Hello Alice
```

---

## Functions Returning Values

```csharp
double CalculateArea(double radius)
{
    return 3.14 * radius * radius;
}
```

Usage:

```csharp
double area = CalculateArea(5);
```

---

## Real-World Example

Banking application:

```csharp
decimal CalculateInterest(decimal principal,
                          decimal rate,
                          int years)
{
    return principal * rate * years / 100;
}
```

Usage:

```csharp
decimal interest = CalculateInterest(
                    10000,
                    5,
                    2);

Console.WriteLine(interest);
```

Output:

```text
1000
```

Functions allow this calculation to be reused throughout the application without rewriting the same logic repeatedly.

---

# Summary

| Topic                | Purpose                                 |
| -------------------- | --------------------------------------- |
| Data Types           | Define the kind of data stored          |
| Data Type Conversion | Convert values between types            |
| `var` Keyword        | Allows compiler type inference          |
| Convert Class        | Provides safe conversion methods        |
| Enums                | Represent fixed sets of named constants |
| Structs              | Group related data into value types     |
| Functions            | Create reusable blocks of logic         |

