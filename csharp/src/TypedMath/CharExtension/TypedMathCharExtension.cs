// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathCharExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.CharExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for char
/// </summary>
public static class TypedMathCharExtension
{

    /// <summary>
    /// Adds byte to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, byte addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds char to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, char addend) => (char)(x + addend);

    /// <summary>
    /// Adds decimal to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, decimal addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds double to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, double addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds float to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, float addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds int to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, int addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds long to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, long addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds sbyte to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, sbyte addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds short to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, short addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds uint to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, uint addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds ulong to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, ulong addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds ushort to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static char Add(this char x, ushort addend) => (char)(x + (char)addend);

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, byte percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, char percent) => (char)(x + (x * percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, decimal percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, double percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, float percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, int percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, long percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, sbyte percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, short percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, uint percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, ulong percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Adds percentage to char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static char AddPercent(this char x, ushort percent) => (char)(x + (x * (char)percent / 100));

    /// <summary>
    /// Returns char if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, byte other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, char other) => (char)(x > other ? x : other);

    /// <summary>
    /// Returns char if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, decimal other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, double other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, float other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, int other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, long other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, sbyte other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, short other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, uint other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, ulong other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static char ChooseIfHigher(this char x, ushort other) => (char)(x > (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, byte other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, char other) => (char)(x < other ? x : other);

    /// <summary>
    /// Returns char if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, decimal other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, double other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, float other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, int other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, long other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, sbyte other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, short other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, uint other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, ulong other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Returns char if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static char ChooseIfLower(this char x, ushort other) => (char)(x < (char)other ? x : (char)other);

    /// <summary>
    /// Gets absolute difference between char and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, byte other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, char other) => (char)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, decimal other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, double other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, float other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, int other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, long other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, sbyte other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, short other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, uint other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, ulong other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static char DiferenceFrom(this char x, ushort other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, byte other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, char other) => (char)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, decimal other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, double other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, float other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, int other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, long other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, sbyte other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, short other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, uint other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, ulong other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Gets absolute difference between char and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static char DifferenceFrom(this char x, ushort other) => (char)(x > (char)other ? x - (char)other : x < (char)other ? (char)other - x : 0);

    /// <summary>
    /// Divides char by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, byte divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, char divisor) => (char)(x / divisor);

    /// <summary>
    /// Divides char by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, decimal divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, double divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, float divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, int divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, long divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, sbyte divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, short divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, uint divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, ulong divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Divides char by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static char DividedBy(this char x, ushort divisor) => (char)(x / (char)divisor);

    /// <summary>
    /// Checks if char is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, byte other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, char other) => x > other;

    /// <summary>
    /// Checks if char is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, decimal other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, double other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, float other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, int other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, long other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, sbyte other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, short other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, uint other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, ulong other) => x > (char)other;

    /// <summary>
    /// Checks if char is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this char x, ushort other) => x > (char)other;

    /// <summary>
    /// Checks if char equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, byte other) => x == (char)other;

    /// <summary>
    /// Checks if char equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, char other) => x == other;

    /// <summary>
    /// Checks if char equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, decimal other) => x == (char)other;

    /// <summary>
    /// Checks if char equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, double other) => x == (char)other;

    /// <summary>
    /// Checks if char equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, float other) => x == (char)other;

    /// <summary>
    /// Checks if char equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, int other) => x == (char)other;

    /// <summary>
    /// Checks if char equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, long other) => x == (char)other;

    /// <summary>
    /// Checks if char equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, sbyte other) => x == (char)other;

    /// <summary>
    /// Checks if char equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, short other) => x == (char)other;

    /// <summary>
    /// Checks if char equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, uint other) => x == (char)other;

    /// <summary>
    /// Checks if char equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, ulong other) => x == (char)other;

    /// <summary>
    /// Checks if char equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this char x, ushort other) => x == (char)other;

    /// <summary>
    /// Gets boolean true if char is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this char x) => x < 0;

    /// <summary>
    /// Checks if char does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, byte other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, char other) => x != other;

    /// <summary>
    /// Checks if char does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, decimal other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, double other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, float other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, int other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, long other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, sbyte other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, short other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, uint other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, ulong other) => x != (char)other;

    /// <summary>
    /// Checks if char does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this char x, ushort other) => x != (char)other;

    /// <summary>
    /// Gets boolean true if char is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this char x) => x > 0;

    /// <summary>
    /// Checks if char is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, byte other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, char other) => x < other;

    /// <summary>
    /// Checks if char is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, decimal other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, double other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, float other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, int other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, long other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, sbyte other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, short other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, uint other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, ulong other) => x < (char)other;

    /// <summary>
    /// Checks if char is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this char x, ushort other) => x < (char)other;

    /// <summary>
    /// Gets remainder of char divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, byte divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, char divisor) => (char)(x % divisor);

    /// <summary>
    /// Gets remainder of char divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, decimal divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, double divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, float divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, int divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, long divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, sbyte divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, short divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, uint divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, ulong divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Gets remainder of char divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static char Modulus(this char x, ushort divisor) => (char)(x % (char)divisor);

    /// <summary>
    /// Multiplies char with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, byte multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, char multiplier) => (char)(x * multiplier);

    /// <summary>
    /// Multiplies char with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, decimal multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, double multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, float multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, int multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, long multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, sbyte multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, short multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, uint multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, ulong multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Multiplies char with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static char MultipliedWith(this char x, ushort multiplier) => (char)(x * (char)multiplier);

    /// <summary>
    /// Calculates char percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, byte number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, char number) => (char)(x / 100 * number);

    /// <summary>
    /// Calculates char percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, decimal number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, double number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, float number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, int number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, long number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, sbyte number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, short number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, uint number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, ulong number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Calculates char percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static char PercentOf(this char x, ushort number) => (char)(x / 100 * (char)number);

    /// <summary>
    /// Subtracts byte from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, byte subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts char from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, char subtrahend) => (char)(x - subtrahend);

    /// <summary>
    /// Subtracts decimal from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, decimal subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts double from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, double subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts float from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, float subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts int from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, int subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts long from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, long subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts sbyte from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, sbyte subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts short from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, short subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts uint from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, uint subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts ulong from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, ulong subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts ushort from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static char Substract(this char x, ushort subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, byte percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, char percent) => (char)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, decimal percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, double percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, float percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, int percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, long percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, sbyte percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, short percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, uint percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, ulong percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static char SubstractPercent(this char x, ushort percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts byte from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, byte subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts char from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, char subtrahend) => (char)(x - subtrahend);

    /// <summary>
    /// Subtracts decimal from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, decimal subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts double from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, double subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts float from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, float subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts int from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, int subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts long from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, long subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts sbyte from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, sbyte subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts short from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, short subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts uint from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, uint subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts ulong from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, ulong subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts ushort from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static char Subtract(this char x, ushort subtrahend) => (char)(x - (char)subtrahend);

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, byte percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, char percent) => (char)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, decimal percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, double percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, float percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, int percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, long percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, sbyte percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, short percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, uint percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, ulong percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Subtracts percentage from char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static char SubtractPercent(this char x, ushort percent) => (char)(x - (x * (char)percent / 100));

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static char[] DecreaseAllValuesWith(this char[] array, char dec) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static char[] GetFirstHalf(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static char GetFirstValue(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static char GetHighestValue(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static char[] GetLastHalf(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static char GetLastValue(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static char GetLowestValue(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static char[] GetMiddle(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static char GetMiddleValue(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static char[] GetValuesHigherThan(this char[] array, char x) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static char[] GetValuesLowerThan(this char[] array, char x) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static char[] IncreaseAllValuesWith(this char[] array, char add) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static char[] RotateLeft(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static char[] RotateRight(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static char[] SetNewArraySize(this char[] array, int size) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static char[] SortArrayAsc(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static char[] SortArrayDesc(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static char SumAllValues(this char[] array) =>
        MarcusMedinaPro.TypedMath.CharCollections.TypedMathCharCollections.SumAllValues(array);
}
