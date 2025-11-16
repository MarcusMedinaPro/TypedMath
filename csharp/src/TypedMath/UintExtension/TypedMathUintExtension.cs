// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUintExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UintExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for uint
/// </summary>
public static class TypedMathUintExtension
{

    /// <summary>
    /// Adds byte to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, byte addend) => x + (uint)addend;

    /// <summary>
    /// Adds char to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, char addend) => x + (uint)addend;

    /// <summary>
    /// Adds decimal to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, decimal addend) => x + (uint)addend;

    /// <summary>
    /// Adds double to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, double addend) => x + (uint)addend;

    /// <summary>
    /// Adds float to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, float addend) => x + (uint)addend;

    /// <summary>
    /// Adds int to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, int addend) => x + (uint)addend;

    /// <summary>
    /// Adds long to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, long addend) => x + (uint)addend;

    /// <summary>
    /// Adds sbyte to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, sbyte addend) => x + (uint)addend;

    /// <summary>
    /// Adds short to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, short addend) => x + (uint)addend;

    /// <summary>
    /// Adds uint to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, uint addend) => x + addend;

    /// <summary>
    /// Adds ulong to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, ulong addend) => x + (uint)addend;

    /// <summary>
    /// Adds ushort to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static uint Add(this uint x, ushort addend) => x + (uint)addend;

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, byte percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, char percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, decimal percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, double percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, float percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, int percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, long percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, sbyte percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, short percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, uint percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, ulong percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Adds percentage to uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static uint AddPercent(this uint x, ushort percent) => x + (x * (uint)percent / 100);

    /// <summary>
    /// Returns uint if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, byte other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, char other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, decimal other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, double other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, float other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, int other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, long other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, sbyte other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, short other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, uint other) => x > other ? x : other;

    /// <summary>
    /// Returns uint if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, ulong other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static uint ChooseIfHigher(this uint x, ushort other) => x > (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, byte other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, char other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, decimal other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, double other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, float other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, int other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, long other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, sbyte other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, short other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, uint other) => x < other ? x : other;

    /// <summary>
    /// Returns uint if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, ulong other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Returns uint if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static uint ChooseIfLower(this uint x, ushort other) => x < (uint)other ? x : (uint)other;

    /// <summary>
    /// Gets absolute difference between uint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, byte other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, char other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, decimal other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, double other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, float other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, int other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, long other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, sbyte other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, short other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, uint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, ulong other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static uint DiferenceFrom(this uint x, ushort other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, byte other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, char other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, decimal other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, double other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, float other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, int other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, long other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, sbyte other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, short other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, uint other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, ulong other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Gets absolute difference between uint and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static uint DifferenceFrom(this uint x, ushort other) => x > (uint)other ? x - (uint)other : x < (uint)other ? (uint)other - x : 0;

    /// <summary>
    /// Divides uint by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, byte divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, char divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, decimal divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, double divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, float divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, int divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, long divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, sbyte divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, short divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, uint divisor) => x / divisor;

    /// <summary>
    /// Divides uint by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, ulong divisor) => x / (uint)divisor;

    /// <summary>
    /// Divides uint by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static uint DividedBy(this uint x, ushort divisor) => x / (uint)divisor;

    /// <summary>
    /// Checks if uint is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, byte other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, char other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, decimal other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, double other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, float other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, int other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, long other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, sbyte other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, short other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, uint other) => x > other;

    /// <summary>
    /// Checks if uint is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, ulong other) => x > (uint)other;

    /// <summary>
    /// Checks if uint is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this uint x, ushort other) => x > (uint)other;

    /// <summary>
    /// Checks if uint equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, byte other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, char other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, decimal other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, double other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, float other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, int other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, long other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, sbyte other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, short other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, uint other) => x == other;

    /// <summary>
    /// Checks if uint equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, ulong other) => x == (uint)other;

    /// <summary>
    /// Checks if uint equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this uint x, ushort other) => x == (uint)other;

    /// <summary>
    /// Gets boolean true if uint is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this uint x) => x < 0;

    /// <summary>
    /// Checks if uint does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, byte other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, char other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, decimal other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, double other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, float other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, int other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, long other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, sbyte other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, short other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, uint other) => x != other;

    /// <summary>
    /// Checks if uint does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, ulong other) => x != (uint)other;

    /// <summary>
    /// Checks if uint does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this uint x, ushort other) => x != (uint)other;

    /// <summary>
    /// Gets boolean true if uint is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this uint x) => x > 0;

    /// <summary>
    /// Checks if uint is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, byte other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, char other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, decimal other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, double other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, float other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, int other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, long other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, sbyte other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, short other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, uint other) => x < other;

    /// <summary>
    /// Checks if uint is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, ulong other) => x < (uint)other;

    /// <summary>
    /// Checks if uint is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this uint x, ushort other) => x < (uint)other;

    /// <summary>
    /// Gets remainder of uint divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, byte divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, char divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, decimal divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, double divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, float divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, int divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, long divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, sbyte divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, short divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, uint divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of uint divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, ulong divisor) => x % (uint)divisor;

    /// <summary>
    /// Gets remainder of uint divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static uint Modulus(this uint x, ushort divisor) => x % (uint)divisor;

    /// <summary>
    /// Multiplies uint with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, byte multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, char multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, decimal multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, double multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, float multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, int multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, long multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, sbyte multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, short multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, uint multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies uint with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, ulong multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Multiplies uint with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static uint MultipliedWith(this uint x, ushort multiplier) => x * (uint)multiplier;

    /// <summary>
    /// Calculates uint percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, byte number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, char number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, decimal number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, double number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, float number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, int number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, long number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, sbyte number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, short number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, uint number) => x / 100 * number;

    /// <summary>
    /// Calculates uint percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, ulong number) => x / 100 * (uint)number;

    /// <summary>
    /// Calculates uint percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static uint PercentOf(this uint x, ushort number) => x / 100 * (uint)number;

    /// <summary>
    /// Subtracts byte from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, byte subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts char from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, char subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts decimal from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, decimal subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts double from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, double subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts float from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, float subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts int from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, int subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts long from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, long subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts sbyte from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, sbyte subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts short from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, short subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts uint from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, uint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ulong from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, ulong subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts ushort from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static uint Substract(this uint x, ushort subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, byte percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, char percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, decimal percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, double percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, float percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, int percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, long percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, sbyte percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, short percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, uint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, ulong percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static uint SubstractPercent(this uint x, ushort percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts byte from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, byte subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts char from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, char subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts decimal from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, decimal subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts double from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, double subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts float from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, float subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts int from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, int subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts long from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, long subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts sbyte from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, sbyte subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts short from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, short subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts uint from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, uint subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts ulong from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, ulong subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts ushort from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static uint Subtract(this uint x, ushort subtrahend) => x - (uint)subtrahend;

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, byte percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, char percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, decimal percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, double percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, float percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, int percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, long percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, sbyte percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, short percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, uint percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, ulong percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Subtracts percentage from uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static uint SubtractPercent(this uint x, ushort percent) => x - (x * (uint)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static uint[] DecreaseAllValuesWith(this uint[] array, uint dec) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static uint[] GetFirstHalf(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static uint GetFirstValue(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static uint GetHighestValue(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static uint[] GetLastHalf(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static uint GetLastValue(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static uint GetLowestValue(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static uint[] GetMiddle(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static uint GetMiddleValue(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static uint[] GetValuesHigherThan(this uint[] array, uint x) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static uint[] GetValuesLowerThan(this uint[] array, uint x) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static uint[] IncreaseAllValuesWith(this uint[] array, uint add) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static uint[] RotateLeft(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static uint[] RotateRight(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static uint[] SetNewArraySize(this uint[] array, int size) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static uint[] SortArrayAsc(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static uint[] SortArrayDesc(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static uint SumAllValues(this uint[] array) =>
        MarcusMedinaPro.TypedMath.UintCollections.TypedMathUintCollections.SumAllValues(array);
}
