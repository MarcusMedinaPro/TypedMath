// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUshortExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UshortExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for ushort
/// </summary>
public static class TypedMathUshortExtension
{

    /// <summary>
    /// Adds byte to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, byte addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds char to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, char addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds decimal to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, decimal addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds double to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, double addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds float to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, float addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds int to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, int addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds long to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, long addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds sbyte to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, sbyte addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds short to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, short addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds uint to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, uint addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds ulong to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, ulong addend) => (ushort)(x + (ushort)addend);

    /// <summary>
    /// Adds ushort to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ushort Add(this ushort x, ushort addend) => (ushort)(x + addend);

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, byte percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, char percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, decimal percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, double percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, float percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, int percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, long percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, sbyte percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, short percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, uint percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, ulong percent) => (ushort)(x + (x * (ushort)percent / 100));

    /// <summary>
    /// Adds percentage to ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ushort AddPercent(this ushort x, ushort percent) => (ushort)(x + (x * percent / 100));

    /// <summary>
    /// Returns ushort if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, byte other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, char other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, decimal other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, double other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, float other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, int other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, long other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, sbyte other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, short other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, uint other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, ulong other) => (ushort)(x > (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ushort ChooseIfHigher(this ushort x, ushort other) => (ushort)(x > other ? x : other);

    /// <summary>
    /// Returns ushort if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, byte other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, char other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, decimal other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, double other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, float other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, int other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, long other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, sbyte other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, short other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, uint other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, ulong other) => (ushort)(x < (ushort)other ? x : (ushort)other);

    /// <summary>
    /// Returns ushort if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ushort ChooseIfLower(this ushort x, ushort other) => (ushort)(x < other ? x : other);

    /// <summary>
    /// Gets absolute difference between ushort and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, byte other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, char other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, decimal other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, double other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, float other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, int other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, long other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, sbyte other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, short other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, uint other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, ulong other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ushort DiferenceFrom(this ushort x, ushort other) => (ushort)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, byte other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, char other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, decimal other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, double other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, float other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, int other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, long other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, sbyte other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, short other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, uint other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, ulong other) => (ushort)(x > (ushort)other ? x - (ushort)other : x < (ushort)other ? (ushort)other - x : 0);

    /// <summary>
    /// Gets absolute difference between ushort and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ushort DifferenceFrom(this ushort x, ushort other) => (ushort)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Divides ushort by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, byte divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, char divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, decimal divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, double divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, float divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, int divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, long divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, sbyte divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, short divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, uint divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, ulong divisor) => (ushort)(x / (ushort)divisor);

    /// <summary>
    /// Divides ushort by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ushort DividedBy(this ushort x, ushort divisor) => (ushort)(x / divisor);

    /// <summary>
    /// Checks if ushort is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, byte other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, char other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, decimal other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, double other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, float other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, int other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, long other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, sbyte other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, short other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, uint other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, ulong other) => x > (ushort)other;

    /// <summary>
    /// Checks if ushort is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ushort x, ushort other) => x > other;

    /// <summary>
    /// Checks if ushort equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, byte other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, char other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, decimal other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, double other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, float other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, int other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, long other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, sbyte other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, short other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, uint other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, ulong other) => x == (ushort)other;

    /// <summary>
    /// Checks if ushort equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ushort x, ushort other) => x == other;

    /// <summary>
    /// Gets boolean true if ushort is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this ushort x) => x < 0;

    /// <summary>
    /// Checks if ushort does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, byte other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, char other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, decimal other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, double other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, float other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, int other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, long other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, sbyte other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, short other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, uint other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, ulong other) => x != (ushort)other;

    /// <summary>
    /// Checks if ushort does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ushort x, ushort other) => x != other;

    /// <summary>
    /// Gets boolean true if ushort is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this ushort x) => x > 0;

    /// <summary>
    /// Checks if ushort is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, byte other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, char other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, decimal other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, double other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, float other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, int other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, long other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, sbyte other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, short other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, uint other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, ulong other) => x < (ushort)other;

    /// <summary>
    /// Checks if ushort is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ushort x, ushort other) => x < other;

    /// <summary>
    /// Gets remainder of ushort divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, byte divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, char divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, decimal divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, double divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, float divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, int divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, long divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, sbyte divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, short divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, uint divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, ulong divisor) => (ushort)(x % (ushort)divisor);

    /// <summary>
    /// Gets remainder of ushort divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ushort Modulus(this ushort x, ushort divisor) => (ushort)(x % divisor);

    /// <summary>
    /// Multiplies ushort with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, byte multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, char multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, decimal multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, double multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, float multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, int multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, long multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, sbyte multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, short multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, uint multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, ulong multiplier) => (ushort)(x * (ushort)multiplier);

    /// <summary>
    /// Multiplies ushort with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ushort MultipliedWith(this ushort x, ushort multiplier) => (ushort)(x * multiplier);

    /// <summary>
    /// Calculates ushort percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, byte number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, char number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, decimal number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, double number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, float number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, int number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, long number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, sbyte number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, short number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, uint number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, ulong number) => (ushort)(x / 100 * (ushort)number);

    /// <summary>
    /// Calculates ushort percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ushort PercentOf(this ushort x, ushort number) => (ushort)(x / 100 * number);

    /// <summary>
    /// Subtracts byte from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, byte subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts char from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, char subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts decimal from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, decimal subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts double from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, double subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts float from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, float subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts int from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, int subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts long from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, long subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts sbyte from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, sbyte subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts short from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, short subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts uint from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, uint subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts ulong from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, ulong subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts ushort from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ushort Substract(this ushort x, ushort subtrahend) => (ushort)(x - subtrahend);

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, byte percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, char percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, decimal percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, double percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, float percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, int percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, long percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, sbyte percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, short percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, uint percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, ulong percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ushort SubstractPercent(this ushort x, ushort percent) => (ushort)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts byte from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, byte subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts char from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, char subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts decimal from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, decimal subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts double from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, double subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts float from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, float subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts int from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, int subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts long from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, long subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts sbyte from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, sbyte subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts short from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, short subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts uint from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, uint subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts ulong from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, ulong subtrahend) => (ushort)(x - (ushort)subtrahend);

    /// <summary>
    /// Subtracts ushort from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ushort Subtract(this ushort x, ushort subtrahend) => (ushort)(x - subtrahend);

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, byte percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, char percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, decimal percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, double percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, float percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, int percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, long percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, sbyte percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, short percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, uint percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, ulong percent) => (ushort)(x - (x * (ushort)percent / 100));

    /// <summary>
    /// Subtracts percentage from ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ushort SubtractPercent(this ushort x, ushort percent) => (ushort)(x - (x * percent / 100));

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static ushort[] DecreaseAllValuesWith(this ushort[] array, ushort dec) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static ushort[] GetFirstHalf(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static ushort GetFirstValue(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static ushort GetHighestValue(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static ushort[] GetLastHalf(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static ushort GetLastValue(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static ushort GetLowestValue(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static ushort[] GetMiddle(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static ushort GetMiddleValue(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static ushort[] GetValuesHigherThan(this ushort[] array, ushort x) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static ushort[] GetValuesLowerThan(this ushort[] array, ushort x) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static ushort[] IncreaseAllValuesWith(this ushort[] array, ushort add) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static ushort[] RotateLeft(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static ushort[] RotateRight(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static ushort[] SetNewArraySize(this ushort[] array, int size) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static ushort[] SortArrayAsc(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static ushort[] SortArrayDesc(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static ushort SumAllValues(this ushort[] array) =>
        MarcusMedinaPro.TypedMath.UshortCollections.TypedMathUshortCollections.SumAllValues(array);
}
