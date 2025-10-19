// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUInt128Extension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UInt128Extension;

using System;
using System.Linq;

/// <summary>
/// Extension for UInt128
/// </summary>
public static class TypedMathUInt128Extension
{

    /// <summary>
    /// Adds byte to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, byte addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds char to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, char addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds int to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, int addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds long to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, long addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds sbyte to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, sbyte addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds short to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, short addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds uint to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, uint addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds UInt128 to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, UInt128 addend) => x + addend;

    /// <summary>
    /// Adds ulong to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, ulong addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds ushort to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static UInt128 Add(this UInt128 x, ushort addend) => x + (UInt128)addend;

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, byte percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, char percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, int percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, long percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, sbyte percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, short percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, uint percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, UInt128 percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, ulong percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Adds percentage to UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static UInt128 AddPercent(this UInt128 x, ushort percent) => x + (x * (UInt128)percent / 100);

    /// <summary>
    /// Returns UInt128 if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, byte other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, char other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, int other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, long other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, sbyte other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, short other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, uint other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than UInt128, otherwise UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, UInt128 other) => x > other ? x : other;

    /// <summary>
    /// Returns UInt128 if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, ulong other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static UInt128 ChooseIfHigher(this UInt128 x, ushort other) => x > (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, byte other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, char other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, int other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, long other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, sbyte other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, short other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, uint other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than UInt128, otherwise UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, UInt128 other) => x < other ? x : other;

    /// <summary>
    /// Returns UInt128 if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, ulong other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Returns UInt128 if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static UInt128 ChooseIfLower(this UInt128 x, ushort other) => x < (UInt128)other ? x : (UInt128)other;

    /// <summary>
    /// Gets absolute difference between UInt128 and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, byte other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, char other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, int other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, long other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, sbyte other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, short other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, uint other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, UInt128 other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, ulong other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static UInt128 DiferenceFrom(this UInt128 x, ushort other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, byte other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, char other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, int other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, long other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, sbyte other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, short other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, uint other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, UInt128 other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, ulong other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Gets absolute difference between UInt128 and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static UInt128 DifferenceFrom(this UInt128 x, ushort other) => x > (UInt128)other ? x - (UInt128)other : x < (UInt128)other ? (UInt128)other - x : 0;

    /// <summary>
    /// Divides UInt128 by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, byte divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, char divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, int divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, long divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, sbyte divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, short divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, uint divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, UInt128 divisor) => x / divisor;

    /// <summary>
    /// Divides UInt128 by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, ulong divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Divides UInt128 by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static UInt128 DividedBy(this UInt128 x, ushort divisor) => x / (UInt128)divisor;

    /// <summary>
    /// Checks if UInt128 is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, byte other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, char other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, int other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, long other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, sbyte other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, short other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, uint other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, UInt128 other) => x > other;

    /// <summary>
    /// Checks if UInt128 is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, ulong other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this UInt128 x, ushort other) => x > (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, byte other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, char other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, int other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, long other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, sbyte other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, short other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, uint other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, UInt128 other) => x == other;

    /// <summary>
    /// Checks if UInt128 equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, ulong other) => x == (UInt128)other;

    /// <summary>
    /// Checks if UInt128 equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this UInt128 x, ushort other) => x == (UInt128)other;

    /// <summary>
    /// Gets boolean true if UInt128 is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this UInt128 x) => x < 0;

    /// <summary>
    /// Checks if UInt128 does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, byte other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, char other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, int other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, long other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, sbyte other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, short other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, uint other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, UInt128 other) => x != other;

    /// <summary>
    /// Checks if UInt128 does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, ulong other) => x != (UInt128)other;

    /// <summary>
    /// Checks if UInt128 does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this UInt128 x, ushort other) => x != (UInt128)other;

    /// <summary>
    /// Gets boolean true if UInt128 is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this UInt128 x) => x > 0;

    /// <summary>
    /// Checks if UInt128 is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, byte other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, char other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, int other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, long other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, sbyte other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, short other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, uint other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, UInt128 other) => x < other;

    /// <summary>
    /// Checks if UInt128 is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, ulong other) => x < (UInt128)other;

    /// <summary>
    /// Checks if UInt128 is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this UInt128 x, ushort other) => x < (UInt128)other;

    /// <summary>
    /// Gets remainder of UInt128 divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, byte divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, char divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, int divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, long divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, sbyte divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, short divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, uint divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, UInt128 divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, ulong divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Gets remainder of UInt128 divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static UInt128 Modulus(this UInt128 x, ushort divisor) => x % (UInt128)divisor;

    /// <summary>
    /// Multiplies UInt128 with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, byte multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, char multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, int multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, long multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, sbyte multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, short multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, uint multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, UInt128 multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies UInt128 with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, ulong multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Multiplies UInt128 with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static UInt128 MultipliedWith(this UInt128 x, ushort multiplier) => x * (UInt128)multiplier;

    /// <summary>
    /// Calculates UInt128 percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, byte number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, char number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, int number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, long number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, sbyte number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, short number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, uint number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, UInt128 number) => x / 100 * number;

    /// <summary>
    /// Calculates UInt128 percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, ulong number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Calculates UInt128 percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static UInt128 PercentOf(this UInt128 x, ushort number) => x / 100 * (UInt128)number;

    /// <summary>
    /// Subtracts byte from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, byte subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts char from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, char subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts int from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, int subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts long from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, long subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts sbyte from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, sbyte subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts short from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, short subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts uint from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, uint subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts UInt128 from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, UInt128 subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ulong from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, ulong subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts ushort from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static UInt128 Substract(this UInt128 x, ushort subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, byte percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, char percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, int percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, long percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, sbyte percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, short percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, uint percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, UInt128 percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, ulong percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage of UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static UInt128 SubstractPercent(this UInt128 x, ushort percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts byte from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, byte subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts char from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, char subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts int from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, int subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts long from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, long subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts sbyte from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, sbyte subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts short from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, short subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts uint from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, uint subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts UInt128 from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, UInt128 subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ulong from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, ulong subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts ushort from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static UInt128 Subtract(this UInt128 x, ushort subtrahend) => x - (UInt128)subtrahend;

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, byte percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, char percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, int percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, long percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, sbyte percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, short percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, uint percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, UInt128 percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, ulong percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Subtracts percentage from UInt128
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static UInt128 SubtractPercent(this UInt128 x, ushort percent) => x - (x * (UInt128)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static UInt128[] DecreaseAllValuesWith(this UInt128[] array, UInt128 dec) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static UInt128[] GetFirstHalf(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static UInt128 GetFirstValue(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static UInt128 GetHighestValue(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static UInt128[] GetLastHalf(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static UInt128 GetLastValue(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static UInt128 GetLowestValue(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static UInt128[] GetMiddle(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static UInt128 GetMiddleValue(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static UInt128[] GetValuesHigherThan(this UInt128[] array, UInt128 x) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static UInt128[] GetValuesLowerThan(this UInt128[] array, UInt128 x) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static UInt128[] IncreaseAllValuesWith(this UInt128[] array, UInt128 add) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static UInt128[] RotateLeft(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.RotateRight(). This method will be removed in v2.0.", false)]
    public static UInt128[] RotateRight(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static UInt128[] SetNewArraySize(this UInt128[] array, int size) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static UInt128[] SortArrayAsc(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static UInt128[] SortArrayDesc(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static UInt128 SumAllValues(this UInt128[] array) =>
        MarcusMedinaPro.TypedMath.UInt128Collections.TypedMathUInt128Collections.SumAllValues(array);
}
