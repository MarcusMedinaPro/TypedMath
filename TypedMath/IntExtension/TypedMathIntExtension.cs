// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathIntExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.IntExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for int
/// </summary>
public static class TypedMathIntExtension
{

    /// <summary>
    /// Adds byte to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, byte addend) => x + (int)addend;

    /// <summary>
    /// Adds char to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, char addend) => x + (int)addend;

    /// <summary>
    /// Adds decimal to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, decimal addend) => x + (int)addend;

    /// <summary>
    /// Adds double to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, double addend) => x + (int)addend;

    /// <summary>
    /// Adds float to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, float addend) => x + (int)addend;

    /// <summary>
    /// Adds int to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, int addend) => x + addend;

    /// <summary>
    /// Adds long to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, long addend) => x + (int)addend;

    /// <summary>
    /// Adds sbyte to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, sbyte addend) => x + (int)addend;

    /// <summary>
    /// Adds short to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, short addend) => x + (int)addend;

    /// <summary>
    /// Adds uint to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, uint addend) => x + (int)addend;

    /// <summary>
    /// Adds ulong to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, ulong addend) => x + (int)addend;

    /// <summary>
    /// Adds ushort to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static int Add(this int x, ushort addend) => x + (int)addend;

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, byte percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, char percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, decimal percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, double percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, float percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, int percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, long percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, sbyte percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, short percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, uint percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, ulong percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Adds percentage to int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static int AddPercent(this int x, ushort percent) => x + (x * (int)percent / 100);

    /// <summary>
    /// Returns int if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, byte other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, char other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, decimal other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, double other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, float other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, int other) => x > other ? x : other;

    /// <summary>
    /// Returns int if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, long other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, sbyte other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, short other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, uint other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, ulong other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static int ChooseIfHigher(this int x, ushort other) => x > (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, byte other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, char other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, decimal other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, double other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, float other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, int other) => x < other ? x : other;

    /// <summary>
    /// Returns int if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, long other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, sbyte other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, short other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, uint other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, ulong other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Returns int if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static int ChooseIfLower(this int x, ushort other) => x < (int)other ? x : (int)other;

    /// <summary>
    /// Gets absolute difference between int and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, byte other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, char other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, decimal other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, double other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, float other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, int other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, long other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, sbyte other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, short other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, uint other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, ulong other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static int DiferenceFrom(this int x, ushort other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, byte other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, char other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, decimal other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, double other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, float other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, int other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, long other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, sbyte other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, short other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, uint other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, ulong other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Gets absolute difference between int and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static int DifferenceFrom(this int x, ushort other) => x > (int)other ? x - (int)other : x < (int)other ? (int)other - x : 0;

    /// <summary>
    /// Divides int by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, byte divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, char divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, decimal divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, double divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, float divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, int divisor) => x / divisor;

    /// <summary>
    /// Divides int by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, long divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, sbyte divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, short divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, uint divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, ulong divisor) => x / (int)divisor;

    /// <summary>
    /// Divides int by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static int DividedBy(this int x, ushort divisor) => x / (int)divisor;

    /// <summary>
    /// Checks if int is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, byte other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, char other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, decimal other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, double other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, float other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, int other) => x > other;

    /// <summary>
    /// Checks if int is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, long other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, sbyte other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, short other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, uint other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, ulong other) => x > (int)other;

    /// <summary>
    /// Checks if int is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this int x, ushort other) => x > (int)other;

    /// <summary>
    /// Checks if int equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, byte other) => x == (int)other;

    /// <summary>
    /// Checks if int equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, char other) => x == (int)other;

    /// <summary>
    /// Checks if int equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, decimal other) => x == (int)other;

    /// <summary>
    /// Checks if int equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, double other) => x == (int)other;

    /// <summary>
    /// Checks if int equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, float other) => x == (int)other;

    /// <summary>
    /// Checks if int equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, int other) => x == other;

    /// <summary>
    /// Checks if int equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, long other) => x == (int)other;

    /// <summary>
    /// Checks if int equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, sbyte other) => x == (int)other;

    /// <summary>
    /// Checks if int equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, short other) => x == (int)other;

    /// <summary>
    /// Checks if int equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, uint other) => x == (int)other;

    /// <summary>
    /// Checks if int equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, ulong other) => x == (int)other;

    /// <summary>
    /// Checks if int equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this int x, ushort other) => x == (int)other;

    /// <summary>
    /// Gets boolean true if int is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this int x) => x < 0;

    /// <summary>
    /// Checks if int does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, byte other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, char other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, decimal other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, double other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, float other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, int other) => x != other;

    /// <summary>
    /// Checks if int does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, long other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, sbyte other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, short other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, uint other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, ulong other) => x != (int)other;

    /// <summary>
    /// Checks if int does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this int x, ushort other) => x != (int)other;

    /// <summary>
    /// Gets boolean true if int is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this int x) => x > 0;

    /// <summary>
    /// Checks if int is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, byte other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, char other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, decimal other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, double other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, float other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, int other) => x < other;

    /// <summary>
    /// Checks if int is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, long other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, sbyte other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, short other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, uint other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, ulong other) => x < (int)other;

    /// <summary>
    /// Checks if int is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this int x, ushort other) => x < (int)other;

    /// <summary>
    /// Gets remainder of int divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, byte divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, char divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, decimal divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, double divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, float divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, int divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of int divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, long divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, sbyte divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, short divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, uint divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, ulong divisor) => x % (int)divisor;

    /// <summary>
    /// Gets remainder of int divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static int Modulus(this int x, ushort divisor) => x % (int)divisor;

    /// <summary>
    /// Multiplies int with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, byte multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, char multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, decimal multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, double multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, float multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, int multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies int with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, long multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, sbyte multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, short multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, uint multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, ulong multiplier) => x * (int)multiplier;

    /// <summary>
    /// Multiplies int with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static int MultipliedWith(this int x, ushort multiplier) => x * (int)multiplier;

    /// <summary>
    /// Calculates int percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, byte number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, char number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, decimal number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, double number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, float number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, int number) => x / 100 * number;

    /// <summary>
    /// Calculates int percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, long number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, sbyte number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, short number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, uint number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, ulong number) => x / 100 * (int)number;

    /// <summary>
    /// Calculates int percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static int PercentOf(this int x, ushort number) => x / 100 * (int)number;

    /// <summary>
    /// Subtracts byte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, byte subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts char from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, char subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts decimal from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, decimal subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts double from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, double subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts float from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, float subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts int from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, int subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts long from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, long subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts sbyte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, sbyte subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts short from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, short subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts uint from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, uint subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts ulong from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, ulong subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts ushort from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static int Substract(this int x, ushort subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, byte percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, char percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, decimal percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, double percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, float percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, int percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, long percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, sbyte percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, short percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, uint percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, ulong percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static int SubstractPercent(this int x, ushort percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts byte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, byte subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts char from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, char subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts decimal from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, decimal subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts double from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, double subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts float from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, float subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts int from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, int subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts long from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, long subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts sbyte from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, sbyte subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts short from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, short subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts uint from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, uint subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts ulong from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, ulong subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts ushort from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static int Subtract(this int x, ushort subtrahend) => x - (int)subtrahend;

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, byte percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, char percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, decimal percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, double percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, float percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, int percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, long percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, sbyte percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, short percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, uint percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, ulong percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Subtracts percentage from int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static int SubtractPercent(this int x, ushort percent) => x - (x * (int)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static int[] DecreaseAllValuesWith(this int[] array, int dec) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static int[] GetFirstHalf(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static int GetFirstValue(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static int GetHighestValue(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static int[] GetLastHalf(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static int GetLastValue(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static int GetLowestValue(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static int[] GetMiddle(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static int GetMiddleValue(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static int[] GetValuesHigherThan(this int[] array, int x) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static int[] GetValuesLowerThan(this int[] array, int x) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static int[] IncreaseAllValuesWith(this int[] array, int add) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static int[] RotateLeft(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static int[] RotateRight(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static int[] SetNewArraySize(this int[] array, int size) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static int[] SortArrayAsc(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static int[] SortArrayDesc(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static int SumAllValues(this int[] array) =>
        MarcusMedinaPro.TypedMath.IntCollections.TypedMathIntCollections.SumAllValues(array);
}
