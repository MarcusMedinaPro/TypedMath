// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathFloatExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.FloatExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for float
/// </summary>
public static class TypedMathFloatExtension
{

    /// <summary>
    /// Adds byte to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, byte addend) => x + (float)addend;

    /// <summary>
    /// Adds char to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, char addend) => x + (float)addend;

    /// <summary>
    /// Adds decimal to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, decimal addend) => x + (float)addend;

    /// <summary>
    /// Adds double to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, double addend) => x + (float)addend;

    /// <summary>
    /// Adds float to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, float addend) => x + addend;

    /// <summary>
    /// Adds int to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, int addend) => x + (float)addend;

    /// <summary>
    /// Adds long to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, long addend) => x + (float)addend;

    /// <summary>
    /// Adds sbyte to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, sbyte addend) => x + (float)addend;

    /// <summary>
    /// Adds short to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, short addend) => x + (float)addend;

    /// <summary>
    /// Adds uint to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, uint addend) => x + (float)addend;

    /// <summary>
    /// Adds ulong to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, ulong addend) => x + (float)addend;

    /// <summary>
    /// Adds ushort to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static float Add(this float x, ushort addend) => x + (float)addend;

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, byte percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, char percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, decimal percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, double percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, float percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, int percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, long percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, sbyte percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, short percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, uint percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, ulong percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Adds percentage to float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static float AddPercent(this float x, ushort percent) => x + (x * (float)percent / 100);

    /// <summary>
    /// Returns float if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, byte other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, char other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, decimal other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, double other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, float other) => x > other ? x : other;

    /// <summary>
    /// Returns float if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, int other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, long other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, sbyte other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, short other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, uint other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, ulong other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static float ChooseIfHigher(this float x, ushort other) => x > (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, byte other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, char other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, decimal other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, double other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, float other) => x < other ? x : other;

    /// <summary>
    /// Returns float if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, int other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, long other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, sbyte other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, short other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, uint other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, ulong other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Returns float if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static float ChooseIfLower(this float x, ushort other) => x < (float)other ? x : (float)other;

    /// <summary>
    /// Gets absolute difference between float and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, byte other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, char other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, decimal other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, double other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, float other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, int other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, long other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, sbyte other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, short other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, uint other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, ulong other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static float DiferenceFrom(this float x, ushort other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, byte other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, char other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, decimal other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, double other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, float other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, int other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, long other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, sbyte other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, short other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, uint other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, ulong other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Gets absolute difference between float and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static float DifferenceFrom(this float x, ushort other) => x > (float)other ? x - (float)other : x < (float)other ? (float)other - x : 0;

    /// <summary>
    /// Divides float by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, byte divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, char divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, decimal divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, double divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, float divisor) => x / divisor;

    /// <summary>
    /// Divides float by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, int divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, long divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, sbyte divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, short divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, uint divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, ulong divisor) => x / (float)divisor;

    /// <summary>
    /// Divides float by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static float DividedBy(this float x, ushort divisor) => x / (float)divisor;

    /// <summary>
    /// Checks if float is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, byte other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, char other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, decimal other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, double other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, float other) => x > other;

    /// <summary>
    /// Checks if float is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, int other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, long other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, sbyte other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, short other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, uint other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, ulong other) => x > (float)other;

    /// <summary>
    /// Checks if float is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this float x, ushort other) => x > (float)other;

    /// <summary>
    /// Checks if float equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, byte other) => x == (float)other;

    /// <summary>
    /// Checks if float equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, char other) => x == (float)other;

    /// <summary>
    /// Checks if float equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, decimal other) => x == (float)other;

    /// <summary>
    /// Checks if float equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, double other) => x == (float)other;

    /// <summary>
    /// Checks if float equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, float other) => x == other;

    /// <summary>
    /// Checks if float equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, int other) => x == (float)other;

    /// <summary>
    /// Checks if float equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, long other) => x == (float)other;

    /// <summary>
    /// Checks if float equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, sbyte other) => x == (float)other;

    /// <summary>
    /// Checks if float equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, short other) => x == (float)other;

    /// <summary>
    /// Checks if float equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, uint other) => x == (float)other;

    /// <summary>
    /// Checks if float equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, ulong other) => x == (float)other;

    /// <summary>
    /// Checks if float equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this float x, ushort other) => x == (float)other;

    /// <summary>
    /// Gets boolean true if float is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this float x) => x < 0;

    /// <summary>
    /// Checks if float does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, byte other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, char other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, decimal other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, double other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, float other) => x != other;

    /// <summary>
    /// Checks if float does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, int other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, long other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, sbyte other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, short other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, uint other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, ulong other) => x != (float)other;

    /// <summary>
    /// Checks if float does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this float x, ushort other) => x != (float)other;

    /// <summary>
    /// Gets boolean true if float is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this float x) => x > 0;

    /// <summary>
    /// Checks if float is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, byte other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, char other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, decimal other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, double other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, float other) => x < other;

    /// <summary>
    /// Checks if float is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, int other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, long other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, sbyte other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, short other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, uint other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, ulong other) => x < (float)other;

    /// <summary>
    /// Checks if float is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this float x, ushort other) => x < (float)other;

    /// <summary>
    /// Gets remainder of float divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, byte divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, char divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, decimal divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, double divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, float divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of float divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, int divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, long divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, sbyte divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, short divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, uint divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, ulong divisor) => x % (float)divisor;

    /// <summary>
    /// Gets remainder of float divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static float Modulus(this float x, ushort divisor) => x % (float)divisor;

    /// <summary>
    /// Multiplies float with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, byte multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, char multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, decimal multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, double multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, float multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies float with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, int multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, long multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, sbyte multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, short multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, uint multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, ulong multiplier) => x * (float)multiplier;

    /// <summary>
    /// Multiplies float with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static float MultipliedWith(this float x, ushort multiplier) => x * (float)multiplier;

    /// <summary>
    /// Calculates float percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, byte number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, char number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, decimal number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, double number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, float number) => x / 100 * number;

    /// <summary>
    /// Calculates float percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, int number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, long number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, sbyte number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, short number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, uint number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, ulong number) => x / 100 * (float)number;

    /// <summary>
    /// Calculates float percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static float PercentOf(this float x, ushort number) => x / 100 * (float)number;

    /// <summary>
    /// Subtracts byte from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, byte subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts char from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, char subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts decimal from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, decimal subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts double from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, double subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts float from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, float subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts int from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, int subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts long from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, long subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts sbyte from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, sbyte subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts short from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, short subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts uint from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, uint subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts ulong from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, ulong subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts ushort from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static float Substract(this float x, ushort subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, byte percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, char percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, decimal percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, double percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, float percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, int percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, long percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, sbyte percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, short percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, uint percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, ulong percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static float SubstractPercent(this float x, ushort percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts byte from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, byte subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts char from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, char subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts decimal from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, decimal subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts double from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, double subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts float from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, float subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts int from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, int subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts long from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, long subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts sbyte from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, sbyte subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts short from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, short subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts uint from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, uint subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts ulong from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, ulong subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts ushort from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static float Subtract(this float x, ushort subtrahend) => x - (float)subtrahend;

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, byte percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, char percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, decimal percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, double percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, float percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, int percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, long percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, sbyte percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, short percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, uint percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, ulong percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Subtracts percentage from float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static float SubtractPercent(this float x, ushort percent) => x - (x * (float)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static float[] DecreaseAllValuesWith(this float[] array, float dec) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static float[] GetFirstHalf(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static float GetFirstValue(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static float GetHighestValue(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static float[] GetLastHalf(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static float GetLastValue(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static float GetLowestValue(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static float[] GetMiddle(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static float GetMiddleValue(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static float[] GetValuesHigherThan(this float[] array, float x) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static float[] GetValuesLowerThan(this float[] array, float x) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static float[] IncreaseAllValuesWith(this float[] array, float add) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static float[] RotateLeft(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static float[] RotateRight(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static float[] SetNewArraySize(this float[] array, int size) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static float[] SortArrayAsc(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static float[] SortArrayDesc(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static float SumAllValues(this float[] array) =>
        MarcusMedinaPro.TypedMath.FloatCollections.TypedMathFloatCollections.SumAllValues(array);
}
