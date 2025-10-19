// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathInt128Extension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.Int128Extension;

using System;
using System.Linq;

/// <summary>
/// Extension for Int128
/// </summary>
public static class TypedMathInt128Extension
{

    /// <summary>
    /// Adds byte to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, byte addend) => x + (Int128)addend;

    /// <summary>
    /// Adds char to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, char addend) => x + (Int128)addend;

    /// <summary>
    /// Adds int to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, int addend) => x + (Int128)addend;

    /// <summary>
    /// Adds Int128 to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, Int128 addend) => x + addend;

    /// <summary>
    /// Adds long to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, long addend) => x + (Int128)addend;

    /// <summary>
    /// Adds sbyte to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, sbyte addend) => x + (Int128)addend;

    /// <summary>
    /// Adds short to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, short addend) => x + (Int128)addend;

    /// <summary>
    /// Adds uint to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, uint addend) => x + (Int128)addend;

    /// <summary>
    /// Adds ulong to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, ulong addend) => x + (Int128)addend;

    /// <summary>
    /// Adds ushort to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Int128 Add(this Int128 x, ushort addend) => x + (Int128)addend;

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, byte percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, char percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, int percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, Int128 percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, long percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, sbyte percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, short percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, uint percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, ulong percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Adds percentage to Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Int128 AddPercent(this Int128 x, ushort percent) => x + (x * (Int128)percent / 100);

    /// <summary>
    /// Returns Int128 if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, byte other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, char other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, int other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than Int128, otherwise Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, Int128 other) => x > other ? x : other;

    /// <summary>
    /// Returns Int128 if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, long other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, sbyte other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, short other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, uint other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, ulong other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Int128 ChooseIfHigher(this Int128 x, ushort other) => x > (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, byte other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, char other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, int other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than Int128, otherwise Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, Int128 other) => x < other ? x : other;

    /// <summary>
    /// Returns Int128 if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, long other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, sbyte other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, short other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, uint other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, ulong other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Returns Int128 if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Int128 ChooseIfLower(this Int128 x, ushort other) => x < (Int128)other ? x : (Int128)other;

    /// <summary>
    /// Gets absolute difference between Int128 and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, byte other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, char other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, int other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, Int128 other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, long other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, sbyte other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, short other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, uint other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, ulong other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Int128 DiferenceFrom(this Int128 x, ushort other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, byte other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, char other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, int other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, Int128 other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, long other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, sbyte other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, short other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, uint other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, ulong other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between Int128 and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Int128 DifferenceFrom(this Int128 x, ushort other) => x > (Int128)other ? x - (Int128)other : x < (Int128)other ? (Int128)other - x : 0;

    /// <summary>
    /// Divides Int128 by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, byte divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, char divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, int divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, Int128 divisor) => x / divisor;

    /// <summary>
    /// Divides Int128 by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, long divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, sbyte divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, short divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, uint divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, ulong divisor) => x / (Int128)divisor;

    /// <summary>
    /// Divides Int128 by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Int128 DividedBy(this Int128 x, ushort divisor) => x / (Int128)divisor;

    /// <summary>
    /// Checks if Int128 is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, byte other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, char other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, int other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, Int128 other) => x > other;

    /// <summary>
    /// Checks if Int128 is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, long other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, sbyte other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, short other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, uint other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, ulong other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Int128 x, ushort other) => x > (Int128)other;

    /// <summary>
    /// Checks if Int128 equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, byte other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, char other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, int other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, Int128 other) => x == other;

    /// <summary>
    /// Checks if Int128 equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, long other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, sbyte other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, short other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, uint other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, ulong other) => x == (Int128)other;

    /// <summary>
    /// Checks if Int128 equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Int128 x, ushort other) => x == (Int128)other;

    /// <summary>
    /// Gets boolean true if Int128 is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this Int128 x) => x < 0;

    /// <summary>
    /// Checks if Int128 does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, byte other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, char other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, int other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, Int128 other) => x != other;

    /// <summary>
    /// Checks if Int128 does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, long other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, sbyte other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, short other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, uint other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, ulong other) => x != (Int128)other;

    /// <summary>
    /// Checks if Int128 does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Int128 x, ushort other) => x != (Int128)other;

    /// <summary>
    /// Gets boolean true if Int128 is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this Int128 x) => x > 0;

    /// <summary>
    /// Checks if Int128 is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, byte other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, char other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, int other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, Int128 other) => x < other;

    /// <summary>
    /// Checks if Int128 is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, long other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, sbyte other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, short other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, uint other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, ulong other) => x < (Int128)other;

    /// <summary>
    /// Checks if Int128 is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Int128 x, ushort other) => x < (Int128)other;

    /// <summary>
    /// Gets remainder of Int128 divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, byte divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, char divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, int divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, Int128 divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, long divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, sbyte divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, short divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, uint divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, ulong divisor) => x % (Int128)divisor;

    /// <summary>
    /// Gets remainder of Int128 divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Int128 Modulus(this Int128 x, ushort divisor) => x % (Int128)divisor;

    /// <summary>
    /// Multiplies Int128 with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, byte multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, char multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, int multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, Int128 multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies Int128 with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, long multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, sbyte multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, short multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, uint multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, ulong multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Multiplies Int128 with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Int128 MultipliedWith(this Int128 x, ushort multiplier) => x * (Int128)multiplier;

    /// <summary>
    /// Calculates Int128 percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, byte number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, char number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, int number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, Int128 number) => x / 100 * number;

    /// <summary>
    /// Calculates Int128 percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, long number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, sbyte number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, short number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, uint number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, ulong number) => x / 100 * (Int128)number;

    /// <summary>
    /// Calculates Int128 percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Int128 PercentOf(this Int128 x, ushort number) => x / 100 * (Int128)number;

    /// <summary>
    /// Subtracts byte from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, byte subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts char from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, char subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts int from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, int subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts Int128 from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, Int128 subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts long from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, long subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts sbyte from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, sbyte subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts short from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, short subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts uint from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, uint subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts ulong from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, ulong subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts ushort from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Int128 Substract(this Int128 x, ushort subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, byte percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, char percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, int percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, Int128 percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, long percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, sbyte percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, short percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, uint percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, ulong percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage of Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Int128 SubstractPercent(this Int128 x, ushort percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts byte from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, byte subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts char from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, char subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts int from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, int subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts Int128 from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, Int128 subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts long from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, long subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts sbyte from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, sbyte subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts short from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, short subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts uint from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, uint subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts ulong from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, ulong subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts ushort from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Int128 Subtract(this Int128 x, ushort subtrahend) => x - (Int128)subtrahend;

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, byte percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, char percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, int percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, Int128 percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, long percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, sbyte percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, short percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, uint percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, ulong percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Subtracts percentage from Int128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Int128 SubtractPercent(this Int128 x, ushort percent) => x - (x * (Int128)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static Int128[] DecreaseAllValuesWith(this Int128[] array, Int128 dec) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static Int128[] GetFirstHalf(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static Int128 GetFirstValue(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static Int128 GetHighestValue(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static Int128[] GetLastHalf(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static Int128 GetLastValue(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static Int128 GetLowestValue(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static Int128[] GetMiddle(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static Int128 GetMiddleValue(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static Int128[] GetValuesHigherThan(this Int128[] array, Int128 x) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static Int128[] GetValuesLowerThan(this Int128[] array, Int128 x) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static Int128[] IncreaseAllValuesWith(this Int128[] array, Int128 add) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static Int128[] RotateLeft(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.RotateRight(). This method will be removed in v2.0.", false)]
    public static Int128[] RotateRight(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static Int128[] SetNewArraySize(this Int128[] array, int size) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static Int128[] SortArrayAsc(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static Int128[] SortArrayDesc(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static Int128 SumAllValues(this Int128[] array) =>
        MarcusMedinaPro.TypedMath.Int128Collections.TypedMathInt128Collections.SumAllValues(array);
}
