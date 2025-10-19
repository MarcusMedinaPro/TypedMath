// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDoubleExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.DoubleExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for double
/// </summary>
public static class TypedMathDoubleExtension
{

    /// <summary>
    /// Adds byte to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, byte addend) => x + (double)addend;

    /// <summary>
    /// Adds char to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, char addend) => x + (double)addend;

    /// <summary>
    /// Adds decimal to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, decimal addend) => x + (double)addend;

    /// <summary>
    /// Adds double to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, double addend) => x + addend;

    /// <summary>
    /// Adds float to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, float addend) => x + (double)addend;

    /// <summary>
    /// Adds int to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, int addend) => x + (double)addend;

    /// <summary>
    /// Adds long to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, long addend) => x + (double)addend;

    /// <summary>
    /// Adds sbyte to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, sbyte addend) => x + (double)addend;

    /// <summary>
    /// Adds short to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, short addend) => x + (double)addend;

    /// <summary>
    /// Adds uint to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, uint addend) => x + (double)addend;

    /// <summary>
    /// Adds ulong to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, ulong addend) => x + (double)addend;

    /// <summary>
    /// Adds ushort to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static double Add(this double x, ushort addend) => x + (double)addend;

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, byte percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, char percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, decimal percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, double percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, float percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, int percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, long percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, sbyte percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, short percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, uint percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, ulong percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Adds percentage to double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static double AddPercent(this double x, ushort percent) => x + (x * (double)percent / 100);

    /// <summary>
    /// Returns double if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, byte other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, char other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, decimal other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, double other) => x > other ? x : other;

    /// <summary>
    /// Returns double if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, float other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, int other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, long other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, sbyte other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, short other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, uint other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, ulong other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static double ChooseIfHigher(this double x, ushort other) => x > (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, byte other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, char other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, decimal other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, double other) => x < other ? x : other;

    /// <summary>
    /// Returns double if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, float other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, int other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, long other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, sbyte other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, short other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, uint other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, ulong other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Returns double if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static double ChooseIfLower(this double x, ushort other) => x < (double)other ? x : (double)other;

    /// <summary>
    /// Gets absolute difference between double and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, byte other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, char other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, decimal other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, double other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, float other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, int other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, long other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, sbyte other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, short other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, uint other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, ulong other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static double DiferenceFrom(this double x, ushort other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, byte other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, char other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, decimal other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, double other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, float other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, int other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, long other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, sbyte other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, short other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, uint other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, ulong other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Gets absolute difference between double and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static double DifferenceFrom(this double x, ushort other) => x > (double)other ? x - (double)other : x < (double)other ? (double)other - x : 0;

    /// <summary>
    /// Divides double by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, byte divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, char divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, decimal divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, double divisor) => x / divisor;

    /// <summary>
    /// Divides double by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, float divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, int divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, long divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, sbyte divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, short divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, uint divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, ulong divisor) => x / (double)divisor;

    /// <summary>
    /// Divides double by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static double DividedBy(this double x, ushort divisor) => x / (double)divisor;

    /// <summary>
    /// Checks if double is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, byte other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, char other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, decimal other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, double other) => x > other;

    /// <summary>
    /// Checks if double is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, float other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, int other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, long other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, sbyte other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, short other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, uint other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, ulong other) => x > (double)other;

    /// <summary>
    /// Checks if double is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this double x, ushort other) => x > (double)other;

    /// <summary>
    /// Checks if double equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, byte other) => x == (double)other;

    /// <summary>
    /// Checks if double equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, char other) => x == (double)other;

    /// <summary>
    /// Checks if double equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, decimal other) => x == (double)other;

    /// <summary>
    /// Checks if double equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, double other) => x == other;

    /// <summary>
    /// Checks if double equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, float other) => x == (double)other;

    /// <summary>
    /// Checks if double equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, int other) => x == (double)other;

    /// <summary>
    /// Checks if double equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, long other) => x == (double)other;

    /// <summary>
    /// Checks if double equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, sbyte other) => x == (double)other;

    /// <summary>
    /// Checks if double equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, short other) => x == (double)other;

    /// <summary>
    /// Checks if double equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, uint other) => x == (double)other;

    /// <summary>
    /// Checks if double equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, ulong other) => x == (double)other;

    /// <summary>
    /// Checks if double equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this double x, ushort other) => x == (double)other;

    /// <summary>
    /// Gets boolean true if double is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this double x) => x < 0;

    /// <summary>
    /// Checks if double does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, byte other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, char other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, decimal other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, double other) => x != other;

    /// <summary>
    /// Checks if double does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, float other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, int other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, long other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, sbyte other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, short other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, uint other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, ulong other) => x != (double)other;

    /// <summary>
    /// Checks if double does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this double x, ushort other) => x != (double)other;

    /// <summary>
    /// Gets boolean true if double is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this double x) => x > 0;

    /// <summary>
    /// Checks if double is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, byte other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, char other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, decimal other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, double other) => x < other;

    /// <summary>
    /// Checks if double is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, float other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, int other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, long other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, sbyte other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, short other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, uint other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, ulong other) => x < (double)other;

    /// <summary>
    /// Checks if double is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this double x, ushort other) => x < (double)other;

    /// <summary>
    /// Gets remainder of double divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, byte divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, char divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, decimal divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, double divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of double divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, float divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, int divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, long divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, sbyte divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, short divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, uint divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, ulong divisor) => x % (double)divisor;

    /// <summary>
    /// Gets remainder of double divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static double Modulus(this double x, ushort divisor) => x % (double)divisor;

    /// <summary>
    /// Multiplies double with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, byte multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, char multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, decimal multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, double multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies double with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, float multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, int multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, long multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, sbyte multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, short multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, uint multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, ulong multiplier) => x * (double)multiplier;

    /// <summary>
    /// Multiplies double with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static double MultipliedWith(this double x, ushort multiplier) => x * (double)multiplier;

    /// <summary>
    /// Calculates double percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, byte number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, char number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, decimal number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, double number) => x / 100 * number;

    /// <summary>
    /// Calculates double percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, float number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, int number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, long number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, sbyte number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, short number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, uint number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, ulong number) => x / 100 * (double)number;

    /// <summary>
    /// Calculates double percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static double PercentOf(this double x, ushort number) => x / 100 * (double)number;

    /// <summary>
    /// Subtracts byte from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, byte subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts char from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, char subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts decimal from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, decimal subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts double from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, double subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts float from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, float subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts int from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, int subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts long from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, long subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts sbyte from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, sbyte subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts short from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, short subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts uint from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, uint subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts ulong from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, ulong subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts ushort from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static double Substract(this double x, ushort subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, byte percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, char percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, decimal percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, double percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, float percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, int percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, long percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, sbyte percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, short percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, uint percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, ulong percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static double SubstractPercent(this double x, ushort percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts byte from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, byte subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts char from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, char subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts decimal from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, decimal subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts double from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, double subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts float from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, float subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts int from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, int subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts long from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, long subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts sbyte from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, sbyte subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts short from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, short subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts uint from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, uint subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts ulong from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, ulong subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts ushort from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static double Subtract(this double x, ushort subtrahend) => x - (double)subtrahend;

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, byte percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, char percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, decimal percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, double percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, float percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, int percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, long percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, sbyte percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, short percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, uint percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, ulong percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Subtracts percentage from double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static double SubtractPercent(this double x, ushort percent) => x - (x * (double)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static double[] DecreaseAllValuesWith(this double[] array, double dec) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static double[] GetFirstHalf(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static double GetFirstValue(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static double GetHighestValue(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static double[] GetLastHalf(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static double GetLastValue(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static double GetLowestValue(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static double[] GetMiddle(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static double GetMiddleValue(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static double[] GetValuesHigherThan(this double[] array, double x) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static double[] GetValuesLowerThan(this double[] array, double x) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static double[] IncreaseAllValuesWith(this double[] array, double add) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static double[] RotateLeft(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static double[] RotateRight(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static double[] SetNewArraySize(this double[] array, int size) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static double[] SortArrayAsc(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static double[] SortArrayDesc(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static double SumAllValues(this double[] array) =>
        MarcusMedinaPro.TypedMath.DoubleCollections.TypedMathDoubleCollections.SumAllValues(array);
}
