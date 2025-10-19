# TypedMath

[![NuGet](https://img.shields.io/nuget/v/TypedMath.svg)](https://www.nuget.org/packages/TypedMath/)
[![.NET](https://img.shields.io/badge/.NET-8.0+-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](CONTRIBUTING.md)
[![Made with ❤️](https://img.shields.io/badge/Made%20with-%E2%9D%A4-red)](https://github.com/MarcusMedina)

Verbose math operations for better code readability. Perfect for developers dealing with dyscalculia or anyone who prefers explicit, readable calculations.

## Overview

Sometimes when working with calculations, I tend to get a touch of Dyscalculia. That's why I loved Visual Basic in the 90s - it had descriptive code, and VB.NET still does. But I prefer working with C#, though I miss some functions from time to time.

To avoid visits from the ghost of Dyscalculia, I created TypedMath. At first it seemed pretty meaningless, but soon I realized this could be useful for others too!

### Learning-first design
TypedMath is built with students in mind. Every extension is written so younger learners, newcomers to programming, and people who struggle with dyscalculia can read, reason about, and explain calculations without stumbling over symbols. Each method name follows the same storytelling style (`Add`, `MultiplyWith`, `PercentOf`, …), making it easy to narrate solutions in classrooms or study sessions. Even the supporting generator in `../TypedMathGenerator` exists to keep this experience consistent across every numeric type so nobody hits an unexpected gap while practicing.

## The Problem

Traditional operators get dense once you mix scaling, percentages, and offsets:

```csharp
var finalScore = baseScore * difficulty + bonus - penalties + (int)Math.Round(baseScore * 0.15);
```

## The Solution

TypedMath spells out each step so you can narrate the intent line by line:

```csharp
var finalScore = baseScore
    .MultipliedWith(difficulty)
    .Add(bonus)
    .Subtract(penalties)
    .Add(15.PercentOf(baseScore));
```

## Features

- ✅ **Verbose Arithmetic** - Explicit method names for all math operations
- ✅ **Type Extensions** - Works with all numeric types (int, double, decimal, float, byte, char, long, etc.)
- ✅ **Comparison Methods** - Readable `GreaterThan()`, `LessThan()`, `IsEqualTo()`
- ✅ **Bitwise Operations** - `And()`, `Or()`, `Xor()`, `Not()`, `ShiftLeft()`, `ShiftRight()`
- ✅ **Percentage Helpers** - Easy `PercentOf()`, `AddPercent()`, `SubtractPercent()`
- ✅ **Array Operations** - Comprehensive array manipulation methods
- ✅ **Prime Number Detection** - Built-in `IsPrime()` method
- ✅ **Value Selection** - Helpers like `ChooseIfHigher()`, `SwapWith()`
- ✅ **Zero Dependencies** - Pure .NET extensions
- ✅ **Comprehensive Tests** - Full xUnit test coverage

## Requirements

- .NET 8.0 or higher

## Installation

### Package Manager Console
```powershell
Install-Package TypedMath
```

### .NET CLI
```bash
dotnet add package TypedMath
```

### Package Reference
```xml
<PackageReference Include="TypedMath" Version="2.0.0" />
```

## Quick Start

```csharp
using MarcusMedinaPro.TypedMath.IntExtension;

// Arithmetic operations
var sum = 10.Add(5);              // 15
var diff = 10.Subtract(3);        // 7
var product = 10.MultipliedWith(5); // 50
var quotient = 20.DividedBy(4);   // 5
var remainder = 10.Modulus(3);    // 1

// Comparisons
if (y.GreaterThan(x))
{
    // Do something
}

// Percentages
var money = 1500.5;
var tax = 15.2.PercentOf(money);       // Calculate 15.2% of money
money = money.AddPercent(20);          // Increase by 20%
money = money.SubtractPercent(10);     // Decrease by 10%

// Prime numbers
if (17.IsPrime())
{
    Console.WriteLine("17 is prime!");
}

// Value selection
var highest = 50.ChooseIfHigher(32);   // Returns 50
var lowest = 32.ChooseIfLower(50);     // Returns 32
```

### Scenario: Budgeting with explicit math

```csharp
using MarcusMedinaPro.TypedMath.DecimalExtension;
using MarcusMedinaPro.TypedMath.IntExtension;

var monthlyBudget = 7_500.00m;
var rent = 4_200.00m;
var groceries = 1_250.00m;
var transportTickets = 650.00m;

// Calculate total expenses and savings rate without symbols
var expenses = rent.Add(groceries).Add(transportTickets);
var savings = monthlyBudget.Subtract(expenses);

var savingsPercent = savings.PercentOf(monthlyBudget);          // 22.67%
var goalPercent = 20.PercentOf(monthlyBudget);                   // Target savings goal

if (savings.GreaterThan(goalPercent))
{
    Console.WriteLine("Great job! You're above your savings target.");
}
else
{
    var shortfall = goalPercent.Subtract(savings);
    Console.WriteLine($"You're short by {shortfall} this month.");
}
```

## Supported Types

TypedMath provides extensions for all common numeric types:

```csharp
using MarcusMedinaPro.TypedMath.ByteExtension;    // byte
using MarcusMedinaPro.TypedMath.CharExtension;    // char
using MarcusMedinaPro.TypedMath.DecimalExtension; // decimal
using MarcusMedinaPro.TypedMath.DoubleExtension;  // double
using MarcusMedinaPro.TypedMath.FloatExtension;   // float
using MarcusMedinaPro.TypedMath.IntExtension;     // int
using MarcusMedinaPro.TypedMath.LongExtension;    // long
using MarcusMedinaPro.TypedMath.SByteExtension;   // sbyte
using MarcusMedinaPro.TypedMath.ShortExtension;   // short
using MarcusMedinaPro.TypedMath.UintExtension;    // uint
using MarcusMedinaPro.TypedMath.UlongExtension;   // ulong
using MarcusMedinaPro.TypedMath.UshortExtension;  // ushort
```

Most functions have automatic casting between types, so you can mix doubles, floats, and ints if needed.

## API Reference

### Arithmetic Operations

```csharp
int Add(this int x, int y)
int Subtract(this int x, int y)
int MultipliedWith(this int x, int y)
int DividedBy(this int x, int y)
int Modulus(this int x, int y)
```

### Comparison Operations

```csharp
bool GreaterThan(this int x, int y)
bool LessThan(this int x, int y)
bool IsEqualTo(this int x, int y)
bool IsNotEqualTo(this int x, int y)
bool IsPositive(this int x)
bool IsNegative(this int x)
```

### Bitwise Operations

Available for integer types (int, short, sbyte, long, etc.):

```csharp
int And(this int x, int y)          // Bitwise AND
int Or(this int x, int y)           // Bitwise OR
int Xor(this int x, int y)          // Bitwise XOR
int Not(this int x)                 // Bitwise NOT
int ShiftLeft(this int x, int y)    // Left shift
int ShiftRight(this int x, int y)   // Right shift
```

**Example:**
```csharp
var test1 = 10.And(2);        // 1010 & 0010 = 0010 (2)
var test2 = 12.Or(2);         // 1100 | 0010 = 1110 (14)
var test3 = 14.Xor(2);        // 1110 ^ 0010 = 1100 (12)
var test4 = 16.Not();         // ~16 = -17
var test5 = 42.ShiftLeft(1);  // 42 << 1 = 84
var test6 = 24.ShiftRight(1); // 24 >> 1 = 12
```

### Percentage Operations

```csharp
double PercentOf(this double x, double y)
double AddPercent(this double x, double y)
double SubtractPercent(this double x, double y)
```

**Example:**
```csharp
var money = 1500.5;
var x = 15.2.PercentOf(money);  // Calculate 15.2% of 1500.5
money = money.AddPercent(20);    // Add 20% to money
money = money.SubtractPercent(20); // Subtract 20% from money
```

### Value Selection

```csharp
int ChooseIfHigher(this int x, int y)  // Returns higher value
int ChooseIfLower(this int x, int y)   // Returns lower value
void SwapWith(this int x, ref int y)   // Swaps two values
void SetHighestValueOf(this ref int x, int val1, int val2)
void SetLowestValueOf(this ref int x, int val1, int val2)
```

**Example:**
```csharp
var value1 = 50;
var value2 = 32;
var x = value1.ChooseIfHigher(value2);  // Returns 50
var y = value2.ChooseIfLower(value1);   // Returns 32

// Swap values
var a = 10;
var b = 20;
b.SwapWith(ref a);  // a = 20, b = 10
```

### Prime Numbers

```csharp
bool IsPrime(this int x)
```

**Example:**
```csharp
var x = 5.IsPrime();  // true
var y = 6.IsPrime();  // false
```

### Difference

```csharp
int GetDifference(this int x, int y)
```

**Example:**
```csharp
var num1 = 100;
var num2 = 129;
var diff = num1.GetDifference(num2);  // 29

var num3 = 100;
var num4 = 35;
var diff2 = num3.GetDifference(num4); // -65
```

### Type Casting

```csharp
byte CastDoubleToByte(this double x)
char CastDoubleToChar(this double x)
decimal CastDoubleToDecimal(this double x)
int CastDoubleToInt(this double x)
long CastDoubleToLong(this double x)
sbyte CastDoubleToSbyte(this double x)
short CastDoubleToShort(this double x)
uint CastDoubleToUint(this double x)
ulong CastDoubleToUlong(this double x)
ushort CastDoubleToUshort(this double x)
```

**Example:**
```csharp
double y = 13.37;
var i = y.CastDoubleToInt();      // 13
var d = y.CastDoubleToDecimal();  // 13.37
var b = y.CastDoubleToByte();     // 13
```

## Array Extensions

TypedMath includes comprehensive array manipulation methods:

```csharp
using MarcusMedinaPro.TypedMath.DoubleExtension;

var arr = new double[] { 10, 42, 20.13, 91.4, 30, 1, 3, 11, 29, 46 };
```

### Basic Array Operations

```csharp
var average = arr.GetAverage();      // Calculate average
var first = arr.GetFirstValue();     // Get first element
var last = arr.GetLastValue();       // Get last element
var middle = arr.GetMiddleValue();   // Get middle element
var highest = arr.GetHighestValue(); // Get maximum
var lowest = arr.GetLowestValue();   // Get minimum
```

### Filtering Operations

```csharp
var higherThan = arr.GetValuesHigherThan(10);  // Values > 10
var lowerThan = arr.GetValuesLowerThan(10);    // Values < 10
```

### Sorting Operations

```csharp
var sortAscending = arr.SortArrayAsc();   // Sort ascending
var sortDescending = arr.SortArrayDesc(); // Sort descending
```

### Array Manipulation

```csharp
var newSize = arr.SetNewArraySize(150);          // Resize array
var sum = arr.SumAllValues();                    // Sum all elements
var left = arr.RotateLeft();                     // Rotate left
var right = arr.RotateRight();                   // Rotate right
var ints = arr.ConvertArrayToInt();              // Convert to int[]
var plusVal = arr.IncreaseAllValuesWith(10);     // Add 10 to all
var minusVal = arr.DecreaseAllValuesWith(12);    // Subtract 12 from all
```

### Array Sections

```csharp
var firstHalf = arr.GetFirstHalf();     // First half of array
var middleValues = arr.GetMiddle();     // Middle elements
var lastHalf = arr.GetLastHalf();       // Last half of array
```

## When to Use TypedMath

### ✅ Good Use Cases

- **Code readability** - When you value explicit, self-documenting code
- **Dyscalculia** - When you struggle with traditional math notation
- **Teaching** - When explaining code to beginners
- **Complex calculations** - When chaining many operations
- **Code reviews** - When you want intentions to be crystal clear

### ❌ Not Recommended

- **Performance-critical code** - Adds minimal overhead
- **Math-heavy algorithms** - Traditional operators are more concise
- **When using LINQ** - LINQ already provides readable operations
- **Minimalist code** - If you prefer terse, compact code

## Disclaimer

This project is nothing magical - most functions are one-liners. The idea isn't to create special functions, but to make code easier to read. If you're a hardcore coder who loves to minimize your code, this isn't for you. But if you want code that's easy to read and maintain, this might help.

## Migration Guide

### From v1.x to v2.0.0

**Breaking Changes:**
- **.NET Framework 4.6.1 → .NET 8.0**: Update your project's target framework
- **License Change**: GPL v3 → MIT (more permissive)

**New Features:**
- Full xUnit test coverage
- Modern SDK-style project format
- GitHub Actions CI/CD
- Improved XML documentation
- NuGet package improvements

**No API Changes** - All existing code continues to work!

## Credits

- **Author**: Marcus Medina
- **Prime Numbers**: LINQ implementation by [Zoran Horvat](http://www.codinghelmet.com/articles/linq-all-primes/)
- **Array Operations**: Inspired by [mqp on Stack Overflow](https://stackoverflow.com/a/823537)
- **Icon**: GPL from [Icons8](http://www.iconarchive.com/show/ios7-icons-by-icons8/Science-Math-icon.html)

## License

This work is licensed under the [MIT License](https://opensource.org/licenses/MIT).

## Source Code

Full source available on [GitHub](https://github.com/MarcusMedina/TypedMath)

## NuGet Package

Available on [NuGet.org](https://www.nuget.org/packages/TypedMath/)

## Collaboration

Feel free to add, suggest, or request a feature. If you want to help develop this package, feel free to send a Pull Request!

---

**Made with ❤️ for better code readability**
