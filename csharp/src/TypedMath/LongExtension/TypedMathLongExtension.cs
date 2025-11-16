// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathLongExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.LongExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for long
/// </summary>
public static class TypedMathLongExtension
{

    /// <summary>
    /// Adds byte to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, byte addend) => x + (long)addend;

    /// <summary>
    /// Adds char to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, char addend) => x + (long)addend;

    /// <summary>
    /// Adds decimal to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, decimal addend) => x + (long)addend;

    /// <summary>
    /// Adds double to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, double addend) => x + (long)addend;

    /// <summary>
    /// Adds float to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, float addend) => x + (long)addend;

    /// <summary>
    /// Adds int to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, int addend) => x + (long)addend;

    /// <summary>
    /// Adds long to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, long addend) => x + addend;

    /// <summary>
    /// Adds sbyte to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, sbyte addend) => x + (long)addend;

    /// <summary>
    /// Adds short to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, short addend) => x + (long)addend;

    /// <summary>
    /// Adds uint to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, uint addend) => x + (long)addend;

    /// <summary>
    /// Adds ulong to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, ulong addend) => x + (long)addend;

    /// <summary>
    /// Adds ushort to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static long Add(this long x, ushort addend) => x + (long)addend;

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, byte percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, char percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, decimal percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, double percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, float percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, int percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, long percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, sbyte percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, short percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, uint percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, ulong percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Adds percentage to long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static long AddPercent(this long x, ushort percent) => x + (x * (long)percent / 100);

    /// <summary>
    /// Returns long if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, byte other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, char other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, decimal other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, double other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, float other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, int other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, long other) => x > other ? x : other;

    /// <summary>
    /// Returns long if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, sbyte other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, short other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, uint other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, ulong other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static long ChooseIfHigher(this long x, ushort other) => x > (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, byte other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, char other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, decimal other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, double other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, float other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, int other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, long other) => x < other ? x : other;

    /// <summary>
    /// Returns long if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, sbyte other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, short other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, uint other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, ulong other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Returns long if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static long ChooseIfLower(this long x, ushort other) => x < (long)other ? x : (long)other;

    /// <summary>
    /// Gets absolute difference between long and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, byte other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, char other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, decimal other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, double other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, float other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, int other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, long other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, sbyte other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, short other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, uint other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, ulong other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static long DiferenceFrom(this long x, ushort other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, byte other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, char other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, decimal other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, double other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, float other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, int other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, long other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, sbyte other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, short other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, uint other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, ulong other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Gets absolute difference between long and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static long DifferenceFrom(this long x, ushort other) => x > (long)other ? x - (long)other : x < (long)other ? (long)other - x : 0;

    /// <summary>
    /// Divides long by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, byte divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, char divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, decimal divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, double divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, float divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, int divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, long divisor) => x / divisor;

    /// <summary>
    /// Divides long by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, sbyte divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, short divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, uint divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, ulong divisor) => x / (long)divisor;

    /// <summary>
    /// Divides long by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static long DividedBy(this long x, ushort divisor) => x / (long)divisor;

    /// <summary>
    /// Checks if long is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, byte other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, char other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, decimal other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, double other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, float other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, int other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, long other) => x > other;

    /// <summary>
    /// Checks if long is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, sbyte other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, short other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, uint other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, ulong other) => x > (long)other;

    /// <summary>
    /// Checks if long is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this long x, ushort other) => x > (long)other;

    /// <summary>
    /// Checks if long equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, byte other) => x == (long)other;

    /// <summary>
    /// Checks if long equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, char other) => x == (long)other;

    /// <summary>
    /// Checks if long equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, decimal other) => x == (long)other;

    /// <summary>
    /// Checks if long equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, double other) => x == (long)other;

    /// <summary>
    /// Checks if long equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, float other) => x == (long)other;

    /// <summary>
    /// Checks if long equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, int other) => x == (long)other;

    /// <summary>
    /// Checks if long equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, long other) => x == other;

    /// <summary>
    /// Checks if long equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, sbyte other) => x == (long)other;

    /// <summary>
    /// Checks if long equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, short other) => x == (long)other;

    /// <summary>
    /// Checks if long equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, uint other) => x == (long)other;

    /// <summary>
    /// Checks if long equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, ulong other) => x == (long)other;

    /// <summary>
    /// Checks if long equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this long x, ushort other) => x == (long)other;

    /// <summary>
    /// Gets boolean true if long is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this long x) => x < 0;

    /// <summary>
    /// Checks if long does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, byte other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, char other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, decimal other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, double other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, float other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, int other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, long other) => x != other;

    /// <summary>
    /// Checks if long does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, sbyte other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, short other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, uint other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, ulong other) => x != (long)other;

    /// <summary>
    /// Checks if long does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this long x, ushort other) => x != (long)other;

    /// <summary>
    /// Gets boolean true if long is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this long x) => x > 0;

    /// <summary>
    /// Checks if long is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, byte other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, char other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, decimal other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, double other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, float other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, int other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, long other) => x < other;

    /// <summary>
    /// Checks if long is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, sbyte other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, short other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, uint other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, ulong other) => x < (long)other;

    /// <summary>
    /// Checks if long is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this long x, ushort other) => x < (long)other;

    /// <summary>
    /// Gets remainder of long divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, byte divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, char divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, decimal divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, double divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, float divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, int divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, long divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of long divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, sbyte divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, short divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, uint divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, ulong divisor) => x % (long)divisor;

    /// <summary>
    /// Gets remainder of long divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static long Modulus(this long x, ushort divisor) => x % (long)divisor;

    /// <summary>
    /// Multiplies long with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, byte multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, char multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, decimal multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, double multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, float multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, int multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, long multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies long with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, sbyte multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, short multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, uint multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, ulong multiplier) => x * (long)multiplier;

    /// <summary>
    /// Multiplies long with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static long MultipliedWith(this long x, ushort multiplier) => x * (long)multiplier;

    /// <summary>
    /// Calculates long percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, byte number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, char number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, decimal number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, double number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, float number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, int number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, long number) => x / 100 * number;

    /// <summary>
    /// Calculates long percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, sbyte number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, short number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, uint number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, ulong number) => x / 100 * (long)number;

    /// <summary>
    /// Calculates long percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static long PercentOf(this long x, ushort number) => x / 100 * (long)number;

    /// <summary>
    /// Subtracts byte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, byte subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts char from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, char subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts decimal from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, decimal subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts double from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, double subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts float from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, float subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts int from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, int subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts long from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, long subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, sbyte subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts short from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, short subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts uint from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, uint subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts ulong from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, ulong subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts ushort from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static long Substract(this long x, ushort subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, byte percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, char percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, decimal percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, double percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, float percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, int percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, long percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, sbyte percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, short percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, uint percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, ulong percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static long SubstractPercent(this long x, ushort percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts byte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, byte subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts char from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, char subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts decimal from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, decimal subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts double from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, double subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts float from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, float subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts int from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, int subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts long from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, long subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, sbyte subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts short from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, short subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts uint from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, uint subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts ulong from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, ulong subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts ushort from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static long Subtract(this long x, ushort subtrahend) => x - (long)subtrahend;

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, byte percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, char percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, decimal percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, double percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, float percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, int percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, long percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, sbyte percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, short percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, uint percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, ulong percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Subtracts percentage from long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static long SubtractPercent(this long x, ushort percent) => x - (x * (long)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static long[] DecreaseAllValuesWith(this long[] array, long dec) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static long[] GetFirstHalf(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static long GetFirstValue(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static long GetHighestValue(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static long[] GetLastHalf(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static long GetLastValue(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static long GetLowestValue(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static long[] GetMiddle(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static long GetMiddleValue(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static long[] GetValuesHigherThan(this long[] array, long x) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static long[] GetValuesLowerThan(this long[] array, long x) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static long[] IncreaseAllValuesWith(this long[] array, long add) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static long[] RotateLeft(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static long[] RotateRight(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static long[] SetNewArraySize(this long[] array, int size) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static long[] SortArrayAsc(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static long[] SortArrayDesc(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static long SumAllValues(this long[] array) =>
        MarcusMedinaPro.TypedMath.LongCollections.TypedMathLongCollections.SumAllValues(array);
}
