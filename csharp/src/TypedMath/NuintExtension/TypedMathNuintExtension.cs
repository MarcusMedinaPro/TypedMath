// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathNuintExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.NuintExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for nuint
/// </summary>
public static class TypedMathNuintExtension
{

    /// <summary>
    /// Adds byte to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, byte addend) => x + (nuint)addend;

    /// <summary>
    /// Adds char to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, char addend) => x + (nuint)addend;

    /// <summary>
    /// Adds decimal to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, decimal addend) => x + (nuint)addend;

    /// <summary>
    /// Adds double to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, double addend) => x + (nuint)addend;

    /// <summary>
    /// Adds float to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, float addend) => x + (nuint)addend;

    /// <summary>
    /// Adds int to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, int addend) => x + (nuint)addend;

    /// <summary>
    /// Adds long to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, long addend) => x + (nuint)addend;

    /// <summary>
    /// Adds nuint to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, nuint addend) => x + addend;

    /// <summary>
    /// Adds sbyte to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, sbyte addend) => x + (nuint)addend;

    /// <summary>
    /// Adds short to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, short addend) => x + (nuint)addend;

    /// <summary>
    /// Adds uint to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, uint addend) => x + (nuint)addend;

    /// <summary>
    /// Adds ulong to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, ulong addend) => x + (nuint)addend;

    /// <summary>
    /// Adds ushort to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nuint Add(this nuint x, ushort addend) => x + (nuint)addend;

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, byte percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, char percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, decimal percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, double percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, float percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, int percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, long percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, nuint percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, sbyte percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, short percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, uint percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, ulong percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Adds percentage to nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nuint AddPercent(this nuint x, ushort percent) => x + (x * (nuint)percent / 100);

    /// <summary>
    /// Returns nuint if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, byte other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, char other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, decimal other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, double other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, float other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, int other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, long other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than nuint, otherwise nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, nuint other) => x > other ? x : other;

    /// <summary>
    /// Returns nuint if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, sbyte other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, short other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, uint other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, ulong other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nuint ChooseIfHigher(this nuint x, ushort other) => x > (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, byte other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, char other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, decimal other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, double other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, float other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, int other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, long other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than nuint, otherwise nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, nuint other) => x < other ? x : other;

    /// <summary>
    /// Returns nuint if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, sbyte other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, short other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, uint other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, ulong other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Returns nuint if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nuint ChooseIfLower(this nuint x, ushort other) => x < (nuint)other ? x : (nuint)other;

    /// <summary>
    /// Gets absolute difference between nuint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, byte other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, char other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, decimal other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, double other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, float other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, int other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, long other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, nuint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, sbyte other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, short other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, uint other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, ulong other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nuint DiferenceFrom(this nuint x, ushort other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, byte other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, char other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, decimal other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, double other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, float other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, int other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, long other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, nuint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, sbyte other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, short other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, uint other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, ulong other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nuint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nuint DifferenceFrom(this nuint x, ushort other) => x > (nuint)other ? x - (nuint)other : x < (nuint)other ? (nuint)other - x : 0;

    /// <summary>
    /// Divides nuint by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, byte divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, char divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, decimal divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, double divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, float divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, int divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, long divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, nuint divisor) => x / divisor;

    /// <summary>
    /// Divides nuint by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, sbyte divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, short divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, uint divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, ulong divisor) => x / (nuint)divisor;

    /// <summary>
    /// Divides nuint by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nuint DividedBy(this nuint x, ushort divisor) => x / (nuint)divisor;

    /// <summary>
    /// Checks if nuint is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, byte other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, char other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, decimal other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, double other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, float other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, int other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, long other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, nuint other) => x > other;

    /// <summary>
    /// Checks if nuint is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, sbyte other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, short other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, uint other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, ulong other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nuint x, ushort other) => x > (nuint)other;

    /// <summary>
    /// Checks if nuint equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, byte other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, char other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, decimal other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, double other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, float other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, int other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, long other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, nuint other) => x == other;

    /// <summary>
    /// Checks if nuint equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, sbyte other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, short other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, uint other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, ulong other) => x == (nuint)other;

    /// <summary>
    /// Checks if nuint equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nuint x, ushort other) => x == (nuint)other;

    /// <summary>
    /// Gets boolean true if nuint is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this nuint x) => x < 0;

    /// <summary>
    /// Checks if nuint does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, byte other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, char other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, decimal other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, double other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, float other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, int other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, long other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, nuint other) => x != other;

    /// <summary>
    /// Checks if nuint does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, sbyte other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, short other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, uint other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, ulong other) => x != (nuint)other;

    /// <summary>
    /// Checks if nuint does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nuint x, ushort other) => x != (nuint)other;

    /// <summary>
    /// Gets boolean true if nuint is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this nuint x) => x > 0;

    /// <summary>
    /// Checks if nuint is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, byte other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, char other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, decimal other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, double other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, float other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, int other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, long other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, nuint other) => x < other;

    /// <summary>
    /// Checks if nuint is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, sbyte other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, short other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, uint other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, ulong other) => x < (nuint)other;

    /// <summary>
    /// Checks if nuint is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nuint x, ushort other) => x < (nuint)other;

    /// <summary>
    /// Gets remainder of nuint divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, byte divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, char divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, decimal divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, double divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, float divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, int divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, long divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, nuint divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of nuint divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, sbyte divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, short divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, uint divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, ulong divisor) => x % (nuint)divisor;

    /// <summary>
    /// Gets remainder of nuint divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nuint Modulus(this nuint x, ushort divisor) => x % (nuint)divisor;

    /// <summary>
    /// Multiplies nuint with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, byte multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, char multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, decimal multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, double multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, float multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, int multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, long multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, nuint multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies nuint with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, sbyte multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, short multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, uint multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, ulong multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Multiplies nuint with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nuint MultipliedWith(this nuint x, ushort multiplier) => x * (nuint)multiplier;

    /// <summary>
    /// Calculates nuint percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, byte number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, char number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, decimal number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, double number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, float number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, int number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, long number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, nuint number) => x / 100 * number;

    /// <summary>
    /// Calculates nuint percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, sbyte number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, short number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, uint number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, ulong number) => x / 100 * (nuint)number;

    /// <summary>
    /// Calculates nuint percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nuint PercentOf(this nuint x, ushort number) => x / 100 * (nuint)number;

    /// <summary>
    /// Subtracts byte from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, byte subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts char from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, char subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts decimal from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, decimal subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts double from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, double subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts float from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, float subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts int from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, int subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts long from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, long subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts nuint from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, nuint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, sbyte subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts short from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, short subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts uint from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, uint subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts ulong from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, ulong subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts ushort from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nuint Substract(this nuint x, ushort subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, byte percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, char percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, decimal percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, double percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, float percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, int percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, long percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, nuint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, sbyte percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, short percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, uint percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, ulong percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nuint SubstractPercent(this nuint x, ushort percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts byte from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, byte subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts char from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, char subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts decimal from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, decimal subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts double from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, double subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts float from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, float subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts int from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, int subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts long from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, long subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts nuint from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, nuint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, sbyte subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts short from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, short subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts uint from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, uint subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts ulong from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, ulong subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts ushort from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nuint Subtract(this nuint x, ushort subtrahend) => x - (nuint)subtrahend;

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, byte percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, char percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, decimal percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, double percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, float percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, int percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, long percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, nuint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, sbyte percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, short percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, uint percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, ulong percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nuint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nuint SubtractPercent(this nuint x, ushort percent) => x - (x * (nuint)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static nuint[] DecreaseAllValuesWith(this nuint[] array, nuint dec) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static nuint[] GetFirstHalf(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static nuint GetFirstValue(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static nuint GetHighestValue(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static nuint[] GetLastHalf(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static nuint GetLastValue(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static nuint GetLowestValue(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static nuint[] GetMiddle(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static nuint GetMiddleValue(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static nuint[] GetValuesHigherThan(this nuint[] array, nuint x) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static nuint[] GetValuesLowerThan(this nuint[] array, nuint x) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static nuint[] IncreaseAllValuesWith(this nuint[] array, nuint add) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static nuint[] RotateLeft(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static nuint[] RotateRight(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static nuint[] SetNewArraySize(this nuint[] array, int size) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static nuint[] SortArrayAsc(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static nuint[] SortArrayDesc(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static nuint SumAllValues(this nuint[] array) =>
        MarcusMedinaPro.TypedMath.NuintCollections.TypedMathNuintCollections.SumAllValues(array);
}
