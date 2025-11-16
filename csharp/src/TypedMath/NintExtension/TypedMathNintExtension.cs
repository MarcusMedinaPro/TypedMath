// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathNintExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.NintExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for nint
/// </summary>
public static class TypedMathNintExtension
{

    /// <summary>
    /// Adds byte to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, byte addend) => x + (nint)addend;

    /// <summary>
    /// Adds char to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, char addend) => x + (nint)addend;

    /// <summary>
    /// Adds decimal to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, decimal addend) => x + (nint)addend;

    /// <summary>
    /// Adds double to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, double addend) => x + (nint)addend;

    /// <summary>
    /// Adds float to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, float addend) => x + (nint)addend;

    /// <summary>
    /// Adds int to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, int addend) => x + (nint)addend;

    /// <summary>
    /// Adds long to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, long addend) => x + (nint)addend;

    /// <summary>
    /// Adds nint to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, nint addend) => x + addend;

    /// <summary>
    /// Adds sbyte to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, sbyte addend) => x + (nint)addend;

    /// <summary>
    /// Adds short to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, short addend) => x + (nint)addend;

    /// <summary>
    /// Adds uint to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, uint addend) => x + (nint)addend;

    /// <summary>
    /// Adds ulong to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, ulong addend) => x + (nint)addend;

    /// <summary>
    /// Adds ushort to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static nint Add(this nint x, ushort addend) => x + (nint)addend;

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, byte percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, char percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, decimal percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, double percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, float percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, int percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, long percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, nint percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, sbyte percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, short percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, uint percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, ulong percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Adds percentage to nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static nint AddPercent(this nint x, ushort percent) => x + (x * (nint)percent / 100);

    /// <summary>
    /// Returns nint if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, byte other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, char other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, decimal other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, double other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, float other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, int other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, long other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than nint, otherwise nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, nint other) => x > other ? x : other;

    /// <summary>
    /// Returns nint if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, sbyte other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, short other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, uint other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, ulong other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static nint ChooseIfHigher(this nint x, ushort other) => x > (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, byte other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, char other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, decimal other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, double other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, float other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, int other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, long other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than nint, otherwise nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, nint other) => x < other ? x : other;

    /// <summary>
    /// Returns nint if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, sbyte other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, short other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, uint other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, ulong other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Returns nint if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static nint ChooseIfLower(this nint x, ushort other) => x < (nint)other ? x : (nint)other;

    /// <summary>
    /// Gets absolute difference between nint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, byte other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, char other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, decimal other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, double other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, float other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, int other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, long other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, nint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, sbyte other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, short other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, uint other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, ulong other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static nint DiferenceFrom(this nint x, ushort other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, byte other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, char other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, decimal other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, double other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, float other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, int other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, long other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, nint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, sbyte other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, short other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, uint other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, ulong other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between nint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static nint DifferenceFrom(this nint x, ushort other) => x > (nint)other ? x - (nint)other : x < (nint)other ? (nint)other - x : 0;

    /// <summary>
    /// Divides nint by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, byte divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, char divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, decimal divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, double divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, float divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, int divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, long divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, nint divisor) => x / divisor;

    /// <summary>
    /// Divides nint by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, sbyte divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, short divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, uint divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, ulong divisor) => x / (nint)divisor;

    /// <summary>
    /// Divides nint by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static nint DividedBy(this nint x, ushort divisor) => x / (nint)divisor;

    /// <summary>
    /// Checks if nint is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, byte other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, char other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, decimal other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, double other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, float other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, int other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, long other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, nint other) => x > other;

    /// <summary>
    /// Checks if nint is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, sbyte other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, short other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, uint other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, ulong other) => x > (nint)other;

    /// <summary>
    /// Checks if nint is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this nint x, ushort other) => x > (nint)other;

    /// <summary>
    /// Checks if nint equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, byte other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, char other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, decimal other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, double other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, float other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, int other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, long other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, nint other) => x == other;

    /// <summary>
    /// Checks if nint equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, sbyte other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, short other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, uint other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, ulong other) => x == (nint)other;

    /// <summary>
    /// Checks if nint equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this nint x, ushort other) => x == (nint)other;

    /// <summary>
    /// Gets boolean true if nint is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this nint x) => x < 0;

    /// <summary>
    /// Checks if nint does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, byte other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, char other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, decimal other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, double other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, float other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, int other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, long other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, nint other) => x != other;

    /// <summary>
    /// Checks if nint does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, sbyte other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, short other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, uint other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, ulong other) => x != (nint)other;

    /// <summary>
    /// Checks if nint does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this nint x, ushort other) => x != (nint)other;

    /// <summary>
    /// Gets boolean true if nint is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this nint x) => x > 0;

    /// <summary>
    /// Checks if nint is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, byte other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, char other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, decimal other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, double other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, float other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, int other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, long other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, nint other) => x < other;

    /// <summary>
    /// Checks if nint is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, sbyte other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, short other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, uint other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, ulong other) => x < (nint)other;

    /// <summary>
    /// Checks if nint is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this nint x, ushort other) => x < (nint)other;

    /// <summary>
    /// Gets remainder of nint divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, byte divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, char divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, decimal divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, double divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, float divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, int divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, long divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, nint divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of nint divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, sbyte divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, short divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, uint divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, ulong divisor) => x % (nint)divisor;

    /// <summary>
    /// Gets remainder of nint divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static nint Modulus(this nint x, ushort divisor) => x % (nint)divisor;

    /// <summary>
    /// Multiplies nint with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, byte multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, char multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, decimal multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, double multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, float multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, int multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, long multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, nint multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies nint with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, sbyte multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, short multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, uint multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, ulong multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Multiplies nint with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static nint MultipliedWith(this nint x, ushort multiplier) => x * (nint)multiplier;

    /// <summary>
    /// Calculates nint percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, byte number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, char number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, decimal number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, double number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, float number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, int number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, long number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, nint number) => x / 100 * number;

    /// <summary>
    /// Calculates nint percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, sbyte number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, short number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, uint number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, ulong number) => x / 100 * (nint)number;

    /// <summary>
    /// Calculates nint percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static nint PercentOf(this nint x, ushort number) => x / 100 * (nint)number;

    /// <summary>
    /// Subtracts byte from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, byte subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts char from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, char subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts decimal from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, decimal subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts double from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, double subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts float from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, float subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts int from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, int subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts long from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, long subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts nint from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, nint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, sbyte subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts short from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, short subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts uint from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, uint subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts ulong from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, ulong subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts ushort from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static nint Substract(this nint x, ushort subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, byte percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, char percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, decimal percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, double percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, float percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, int percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, long percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, nint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, sbyte percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, short percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, uint percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, ulong percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage of nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static nint SubstractPercent(this nint x, ushort percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts byte from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, byte subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts char from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, char subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts decimal from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, decimal subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts double from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, double subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts float from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, float subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts int from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, int subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts long from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, long subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts nint from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, nint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts sbyte from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, sbyte subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts short from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, short subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts uint from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, uint subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts ulong from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, ulong subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts ushort from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static nint Subtract(this nint x, ushort subtrahend) => x - (nint)subtrahend;

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, byte percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, char percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, decimal percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, double percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, float percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, int percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, long percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, nint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, sbyte percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, short percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, uint percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, ulong percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Subtracts percentage from nint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static nint SubtractPercent(this nint x, ushort percent) => x - (x * (nint)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static nint[] DecreaseAllValuesWith(this nint[] array, nint dec) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static nint[] GetFirstHalf(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static nint GetFirstValue(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static nint GetHighestValue(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static nint[] GetLastHalf(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static nint GetLastValue(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static nint GetLowestValue(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static nint[] GetMiddle(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static nint GetMiddleValue(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static nint[] GetValuesHigherThan(this nint[] array, nint x) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static nint[] GetValuesLowerThan(this nint[] array, nint x) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static nint[] IncreaseAllValuesWith(this nint[] array, nint add) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static nint[] RotateLeft(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static nint[] RotateRight(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static nint[] SetNewArraySize(this nint[] array, int size) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static nint[] SortArrayAsc(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static nint[] SortArrayDesc(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static nint SumAllValues(this nint[] array) =>
        MarcusMedinaPro.TypedMath.NintCollections.TypedMathNintCollections.SumAllValues(array);
}
