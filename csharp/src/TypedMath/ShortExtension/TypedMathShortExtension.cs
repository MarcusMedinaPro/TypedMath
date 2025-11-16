// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathShortExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ShortExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for short
/// </summary>
public static class TypedMathShortExtension
{

    /// <summary>
    /// Adds byte to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, byte addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds char to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, char addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds decimal to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, decimal addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds double to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, double addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds float to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, float addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds int to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, int addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds long to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, long addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds sbyte to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, sbyte addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds short to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, short addend) => (short)(x + addend);

    /// <summary>
    /// Adds uint to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, uint addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds ulong to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, ulong addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds ushort to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static short Add(this short x, ushort addend) => (short)(x + (short)addend);

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, byte percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, char percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, decimal percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, double percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, float percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, int percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, long percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, sbyte percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, short percent) => (short)(x + (x * percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, uint percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, ulong percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Adds percentage to short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static short AddPercent(this short x, ushort percent) => (short)(x + (x * (short)percent / 100));

    /// <summary>
    /// Returns short if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, byte other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, char other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, decimal other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, double other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, float other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, int other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, long other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, sbyte other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, short other) => (short)(x > other ? x : other);

    /// <summary>
    /// Returns short if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, uint other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, ulong other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static short ChooseIfHigher(this short x, ushort other) => (short)(x > (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, byte other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, char other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, decimal other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, double other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, float other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, int other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, long other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, sbyte other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, short other) => (short)(x < other ? x : other);

    /// <summary>
    /// Returns short if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, uint other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, ulong other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Returns short if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static short ChooseIfLower(this short x, ushort other) => (short)(x < (short)other ? x : (short)other);

    /// <summary>
    /// Gets absolute difference between short and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, byte other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, char other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, decimal other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, double other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, float other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, int other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, long other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, sbyte other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, short other) => (short)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, uint other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, ulong other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static short DiferenceFrom(this short x, ushort other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, byte other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, char other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, decimal other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, double other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, float other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, int other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, long other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, sbyte other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, short other) => (short)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, uint other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, ulong other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Gets absolute difference between short and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static short DifferenceFrom(this short x, ushort other) => (short)(x > (short)other ? x - (short)other : x < (short)other ? (short)other - x : 0);

    /// <summary>
    /// Divides short by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, byte divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, char divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, decimal divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, double divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, float divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, int divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, long divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, sbyte divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, short divisor) => (short)(x / divisor);

    /// <summary>
    /// Divides short by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, uint divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, ulong divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Divides short by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static short DividedBy(this short x, ushort divisor) => (short)(x / (short)divisor);

    /// <summary>
    /// Checks if short is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, byte other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, char other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, decimal other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, double other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, float other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, int other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, long other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, sbyte other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, short other) => x > other;

    /// <summary>
    /// Checks if short is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, uint other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, ulong other) => x > (short)other;

    /// <summary>
    /// Checks if short is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this short x, ushort other) => x > (short)other;

    /// <summary>
    /// Checks if short equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, byte other) => x == (short)other;

    /// <summary>
    /// Checks if short equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, char other) => x == (short)other;

    /// <summary>
    /// Checks if short equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, decimal other) => x == (short)other;

    /// <summary>
    /// Checks if short equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, double other) => x == (short)other;

    /// <summary>
    /// Checks if short equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, float other) => x == (short)other;

    /// <summary>
    /// Checks if short equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, int other) => x == (short)other;

    /// <summary>
    /// Checks if short equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, long other) => x == (short)other;

    /// <summary>
    /// Checks if short equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, sbyte other) => x == (short)other;

    /// <summary>
    /// Checks if short equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, short other) => x == other;

    /// <summary>
    /// Checks if short equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, uint other) => x == (short)other;

    /// <summary>
    /// Checks if short equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, ulong other) => x == (short)other;

    /// <summary>
    /// Checks if short equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this short x, ushort other) => x == (short)other;

    /// <summary>
    /// Gets boolean true if short is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this short x) => x < 0;

    /// <summary>
    /// Checks if short does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, byte other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, char other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, decimal other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, double other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, float other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, int other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, long other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, sbyte other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, short other) => x != other;

    /// <summary>
    /// Checks if short does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, uint other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, ulong other) => x != (short)other;

    /// <summary>
    /// Checks if short does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this short x, ushort other) => x != (short)other;

    /// <summary>
    /// Gets boolean true if short is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this short x) => x > 0;

    /// <summary>
    /// Checks if short is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, byte other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, char other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, decimal other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, double other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, float other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, int other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, long other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, sbyte other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, short other) => x < other;

    /// <summary>
    /// Checks if short is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, uint other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, ulong other) => x < (short)other;

    /// <summary>
    /// Checks if short is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this short x, ushort other) => x < (short)other;

    /// <summary>
    /// Gets remainder of short divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, byte divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, char divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, decimal divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, double divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, float divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, int divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, long divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, sbyte divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, short divisor) => (short)(x % divisor);

    /// <summary>
    /// Gets remainder of short divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, uint divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, ulong divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Gets remainder of short divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static short Modulus(this short x, ushort divisor) => (short)(x % (short)divisor);

    /// <summary>
    /// Multiplies short with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, byte multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, char multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, decimal multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, double multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, float multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, int multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, long multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, sbyte multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, short multiplier) => (short)(x * multiplier);

    /// <summary>
    /// Multiplies short with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, uint multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, ulong multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Multiplies short with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static short MultipliedWith(this short x, ushort multiplier) => (short)(x * (short)multiplier);

    /// <summary>
    /// Calculates short percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, byte number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, char number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, decimal number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, double number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, float number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, int number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, long number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, sbyte number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, short number) => (short)(x / 100 * number);

    /// <summary>
    /// Calculates short percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, uint number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, ulong number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Calculates short percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static short PercentOf(this short x, ushort number) => (short)(x / 100 * (short)number);

    /// <summary>
    /// Subtracts byte from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, byte subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts char from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, char subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts decimal from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, decimal subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts double from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, double subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts float from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, float subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts int from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, int subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts long from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, long subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts sbyte from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, sbyte subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts short from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, short subtrahend) => (short)(x - subtrahend);

    /// <summary>
    /// Subtracts uint from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, uint subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts ulong from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, ulong subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts ushort from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static short Substract(this short x, ushort subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, byte percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, char percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, decimal percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, double percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, float percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, int percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, long percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, sbyte percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, short percent) => (short)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, uint percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, ulong percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static short SubstractPercent(this short x, ushort percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts byte from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, byte subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts char from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, char subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts decimal from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, decimal subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts double from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, double subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts float from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, float subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts int from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, int subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts long from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, long subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts sbyte from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, sbyte subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts short from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, short subtrahend) => (short)(x - subtrahend);

    /// <summary>
    /// Subtracts uint from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, uint subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts ulong from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, ulong subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts ushort from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static short Subtract(this short x, ushort subtrahend) => (short)(x - (short)subtrahend);

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, byte percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, char percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, decimal percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, double percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, float percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, int percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, long percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, sbyte percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, short percent) => (short)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, uint percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, ulong percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Subtracts percentage from short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static short SubtractPercent(this short x, ushort percent) => (short)(x - (x * (short)percent / 100));

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static short[] DecreaseAllValuesWith(this short[] array, short dec) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static short[] GetFirstHalf(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static short GetFirstValue(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static short GetHighestValue(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static short[] GetLastHalf(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static short GetLastValue(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static short GetLowestValue(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static short[] GetMiddle(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static short GetMiddleValue(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static short[] GetValuesHigherThan(this short[] array, short x) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static short[] GetValuesLowerThan(this short[] array, short x) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static short[] IncreaseAllValuesWith(this short[] array, short add) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static short[] RotateLeft(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static short[] RotateRight(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static short[] SetNewArraySize(this short[] array, int size) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static short[] SortArrayAsc(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static short[] SortArrayDesc(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static short SumAllValues(this short[] array) =>
        MarcusMedinaPro.TypedMath.ShortCollections.TypedMathShortCollections.SumAllValues(array);
}
