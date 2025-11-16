// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUlongExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UlongExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for ulong
/// </summary>
public static class TypedMathUlongExtension
{

    /// <summary>
    /// Adds byte to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, byte addend) => x + (ulong)addend;

    /// <summary>
    /// Adds char to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, char addend) => x + (ulong)addend;

    /// <summary>
    /// Adds decimal to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, decimal addend) => x + (ulong)addend;

    /// <summary>
    /// Adds double to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, double addend) => x + (ulong)addend;

    /// <summary>
    /// Adds float to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, float addend) => x + (ulong)addend;

    /// <summary>
    /// Adds int to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, int addend) => x + (ulong)addend;

    /// <summary>
    /// Adds long to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, long addend) => x + (ulong)addend;

    /// <summary>
    /// Adds sbyte to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, sbyte addend) => x + (ulong)addend;

    /// <summary>
    /// Adds short to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, short addend) => x + (ulong)addend;

    /// <summary>
    /// Adds uint to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, uint addend) => x + (ulong)addend;

    /// <summary>
    /// Adds ulong to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, ulong addend) => x + addend;

    /// <summary>
    /// Adds ushort to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static ulong Add(this ulong x, ushort addend) => x + (ulong)addend;

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, byte percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, char percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, decimal percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, double percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, float percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, int percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, long percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, sbyte percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, short percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, uint percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, ulong percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static ulong AddPercent(this ulong x, ushort percent) => x + (x * (ulong)percent / 100);

    /// <summary>
    /// Returns ulong if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, byte other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, char other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, decimal other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, double other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, float other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, int other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, long other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, sbyte other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, short other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, uint other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, ulong other) => x > other ? x : other;

    /// <summary>
    /// Returns ulong if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static ulong ChooseIfHigher(this ulong x, ushort other) => x > (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, byte other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, char other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, decimal other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, double other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, float other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, int other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, long other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, sbyte other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, short other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, uint other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Returns ulong if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, ulong other) => x < other ? x : other;

    /// <summary>
    /// Returns ulong if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static ulong ChooseIfLower(this ulong x, ushort other) => x < (ulong)other ? x : (ulong)other;

    /// <summary>
    /// Gets absolute difference between ulong and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, byte other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, char other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, decimal other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, double other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, float other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, int other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, long other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, sbyte other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, short other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, uint other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, ulong other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static ulong DiferenceFrom(this ulong x, ushort other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, byte other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, char other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, decimal other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, double other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, float other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, int other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, long other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, sbyte other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, short other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, uint other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, ulong other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between ulong and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static ulong DifferenceFrom(this ulong x, ushort other) => x > (ulong)other ? x - (ulong)other : x < (ulong)other ? (ulong)other - x : 0;

    /// <summary>
    /// Divides ulong by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, byte divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, char divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, decimal divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, double divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, float divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, int divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, long divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, sbyte divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, short divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, uint divisor) => x / (ulong)divisor;

    /// <summary>
    /// Divides ulong by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, ulong divisor) => x / divisor;

    /// <summary>
    /// Divides ulong by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static ulong DividedBy(this ulong x, ushort divisor) => x / (ulong)divisor;

    /// <summary>
    /// Checks if ulong is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, byte other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, char other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, decimal other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, double other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, float other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, int other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, long other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, sbyte other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, short other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, uint other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, ulong other) => x > other;

    /// <summary>
    /// Checks if ulong is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this ulong x, ushort other) => x > (ulong)other;

    /// <summary>
    /// Checks if ulong equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, byte other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, char other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, decimal other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, double other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, float other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, int other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, long other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, sbyte other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, short other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, uint other) => x == (ulong)other;

    /// <summary>
    /// Checks if ulong equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, ulong other) => x == other;

    /// <summary>
    /// Checks if ulong equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this ulong x, ushort other) => x == (ulong)other;

    /// <summary>
    /// Gets boolean true if ulong is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this ulong x) => x < 0;

    /// <summary>
    /// Checks if ulong does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, byte other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, char other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, decimal other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, double other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, float other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, int other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, long other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, sbyte other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, short other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, uint other) => x != (ulong)other;

    /// <summary>
    /// Checks if ulong does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, ulong other) => x != other;

    /// <summary>
    /// Checks if ulong does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this ulong x, ushort other) => x != (ulong)other;

    /// <summary>
    /// Gets boolean true if ulong is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this ulong x) => x > 0;

    /// <summary>
    /// Checks if ulong is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, byte other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, char other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, decimal other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, double other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, float other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, int other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, long other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, sbyte other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, short other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, uint other) => x < (ulong)other;

    /// <summary>
    /// Checks if ulong is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, ulong other) => x < other;

    /// <summary>
    /// Checks if ulong is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this ulong x, ushort other) => x < (ulong)other;

    /// <summary>
    /// Gets remainder of ulong divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, byte divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, char divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, decimal divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, double divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, float divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, int divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, long divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, sbyte divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, short divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, uint divisor) => x % (ulong)divisor;

    /// <summary>
    /// Gets remainder of ulong divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, ulong divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of ulong divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static ulong Modulus(this ulong x, ushort divisor) => x % (ulong)divisor;

    /// <summary>
    /// Multiplies ulong with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, byte multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, char multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, decimal multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, double multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, float multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, int multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, long multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, sbyte multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, short multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, uint multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Multiplies ulong with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, ulong multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies ulong with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static ulong MultipliedWith(this ulong x, ushort multiplier) => x * (ulong)multiplier;

    /// <summary>
    /// Calculates ulong percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, byte number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, char number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, decimal number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, double number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, float number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, int number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, long number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, sbyte number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, short number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, uint number) => x / 100 * (ulong)number;

    /// <summary>
    /// Calculates ulong percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, ulong number) => x / 100 * number;

    /// <summary>
    /// Calculates ulong percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static ulong PercentOf(this ulong x, ushort number) => x / 100 * (ulong)number;

    /// <summary>
    /// Subtracts byte from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, byte subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts char from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, char subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts decimal from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, decimal subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts double from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, double subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts float from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, float subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts int from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, int subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts long from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, long subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts sbyte from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, sbyte subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts short from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, short subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts uint from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, uint subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts ulong from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, ulong subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ushort from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static ulong Substract(this ulong x, ushort subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, byte percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, char percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, decimal percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, double percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, float percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, int percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, long percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, sbyte percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, short percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, uint percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, ulong percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static ulong SubstractPercent(this ulong x, ushort percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts byte from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, byte subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts char from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, char subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts decimal from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, decimal subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts double from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, double subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts float from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, float subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts int from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, int subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts long from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, long subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts sbyte from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, sbyte subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts short from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, short subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts uint from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, uint subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts ulong from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, ulong subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ushort from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static ulong Subtract(this ulong x, ushort subtrahend) => x - (ulong)subtrahend;

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, byte percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, char percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, decimal percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, double percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, float percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, int percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, long percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, sbyte percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, short percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, uint percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, ulong percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static ulong SubtractPercent(this ulong x, ushort percent) => x - (x * (ulong)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static ulong[] DecreaseAllValuesWith(this ulong[] array, ulong dec) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static ulong[] GetFirstHalf(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static ulong GetFirstValue(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static ulong GetHighestValue(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static ulong[] GetLastHalf(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static ulong GetLastValue(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static ulong GetLowestValue(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static ulong[] GetMiddle(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static ulong GetMiddleValue(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static ulong[] GetValuesHigherThan(this ulong[] array, ulong x) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static ulong[] GetValuesLowerThan(this ulong[] array, ulong x) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static ulong[] IncreaseAllValuesWith(this ulong[] array, ulong add) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static ulong[] RotateLeft(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static ulong[] RotateRight(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static ulong[] SetNewArraySize(this ulong[] array, int size) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static ulong[] SortArrayAsc(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static ulong[] SortArrayDesc(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static ulong SumAllValues(this ulong[] array) =>
        MarcusMedinaPro.TypedMath.UlongCollections.TypedMathUlongCollections.SumAllValues(array);
}
