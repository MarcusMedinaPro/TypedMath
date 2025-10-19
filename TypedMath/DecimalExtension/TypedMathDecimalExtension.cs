// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDecimalExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.DecimalExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for decimal
/// </summary>
public static class TypedMathDecimalExtension
{

    /// <summary>
    /// Adds byte to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, byte addend) => x + (decimal)addend;

    /// <summary>
    /// Adds char to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, char addend) => x + (decimal)addend;

    /// <summary>
    /// Adds decimal to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, decimal addend) => x + addend;

    /// <summary>
    /// Adds double to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, double addend) => x + (decimal)addend;

    /// <summary>
    /// Adds float to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, float addend) => x + (decimal)addend;

    /// <summary>
    /// Adds int to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, int addend) => x + (decimal)addend;

    /// <summary>
    /// Adds long to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, long addend) => x + (decimal)addend;

    /// <summary>
    /// Adds sbyte to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, sbyte addend) => x + (decimal)addend;

    /// <summary>
    /// Adds short to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, short addend) => x + (decimal)addend;

    /// <summary>
    /// Adds uint to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, uint addend) => x + (decimal)addend;

    /// <summary>
    /// Adds ulong to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, ulong addend) => x + (decimal)addend;

    /// <summary>
    /// Adds ushort to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static decimal Add(this decimal x, ushort addend) => x + (decimal)addend;

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, byte percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, char percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, decimal percent) => x + (x * percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, double percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, float percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, int percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, long percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, sbyte percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, short percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, uint percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, ulong percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Adds percentage to decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static decimal AddPercent(this decimal x, ushort percent) => x + (x * (decimal)percent / 100);

    /// <summary>
    /// Returns decimal if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, byte other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, char other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, decimal other) => x > other ? x : other;

    /// <summary>
    /// Returns decimal if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, double other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, float other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, int other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, long other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, sbyte other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, short other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, uint other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, ulong other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static decimal ChooseIfHigher(this decimal x, ushort other) => x > (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, byte other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, char other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, decimal other) => x < other ? x : other;

    /// <summary>
    /// Returns decimal if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, double other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, float other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, int other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, long other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, sbyte other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, short other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, uint other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, ulong other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Returns decimal if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static decimal ChooseIfLower(this decimal x, ushort other) => x < (decimal)other ? x : (decimal)other;

    /// <summary>
    /// Gets absolute difference between decimal and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, byte other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, char other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, decimal other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, double other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, float other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, int other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, long other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, sbyte other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, short other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, uint other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, ulong other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static decimal DiferenceFrom(this decimal x, ushort other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, byte other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, char other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, decimal other) => x > other ? x - other : x < other ? other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, double other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, float other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, int other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, long other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, sbyte other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, short other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, uint other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, ulong other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Gets absolute difference between decimal and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static decimal DifferenceFrom(this decimal x, ushort other) => x > (decimal)other ? x - (decimal)other : x < (decimal)other ? (decimal)other - x : 0;

    /// <summary>
    /// Divides decimal by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, byte divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, char divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, decimal divisor) => x / divisor;

    /// <summary>
    /// Divides decimal by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, double divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, float divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, int divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, long divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, sbyte divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, short divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, uint divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, ulong divisor) => x / (decimal)divisor;

    /// <summary>
    /// Divides decimal by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static decimal DividedBy(this decimal x, ushort divisor) => x / (decimal)divisor;

    /// <summary>
    /// Checks if decimal is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, byte other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, char other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, decimal other) => x > other;

    /// <summary>
    /// Checks if decimal is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, double other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, float other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, int other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, long other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, sbyte other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, short other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, uint other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, ulong other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this decimal x, ushort other) => x > (decimal)other;

    /// <summary>
    /// Checks if decimal equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, byte other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, char other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, decimal other) => x == other;

    /// <summary>
    /// Checks if decimal equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, double other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, float other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, int other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, long other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, sbyte other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, short other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, uint other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, ulong other) => x == (decimal)other;

    /// <summary>
    /// Checks if decimal equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this decimal x, ushort other) => x == (decimal)other;

    /// <summary>
    /// Gets boolean true if decimal is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this decimal x) => x < 0;

    /// <summary>
    /// Checks if decimal does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, byte other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, char other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, decimal other) => x != other;

    /// <summary>
    /// Checks if decimal does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, double other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, float other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, int other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, long other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, sbyte other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, short other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, uint other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, ulong other) => x != (decimal)other;

    /// <summary>
    /// Checks if decimal does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this decimal x, ushort other) => x != (decimal)other;

    /// <summary>
    /// Gets boolean true if decimal is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this decimal x) => x > 0;

    /// <summary>
    /// Checks if decimal is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, byte other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, char other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, decimal other) => x < other;

    /// <summary>
    /// Checks if decimal is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, double other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, float other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, int other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, long other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, sbyte other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, short other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, uint other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, ulong other) => x < (decimal)other;

    /// <summary>
    /// Checks if decimal is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this decimal x, ushort other) => x < (decimal)other;

    /// <summary>
    /// Gets remainder of decimal divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, byte divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, char divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, decimal divisor) => x % divisor;

    /// <summary>
    /// Gets remainder of decimal divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, double divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, float divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, int divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, long divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, sbyte divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, short divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, uint divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, ulong divisor) => x % (decimal)divisor;

    /// <summary>
    /// Gets remainder of decimal divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static decimal Modulus(this decimal x, ushort divisor) => x % (decimal)divisor;

    /// <summary>
    /// Multiplies decimal with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, byte multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, char multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, decimal multiplier) => x * multiplier;

    /// <summary>
    /// Multiplies decimal with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, double multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, float multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, int multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, long multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, sbyte multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, short multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, uint multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, ulong multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Multiplies decimal with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static decimal MultipliedWith(this decimal x, ushort multiplier) => x * (decimal)multiplier;

    /// <summary>
    /// Calculates decimal percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, byte number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, char number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, decimal number) => x / 100 * number;

    /// <summary>
    /// Calculates decimal percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, double number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, float number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, int number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, long number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, sbyte number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, short number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, uint number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, ulong number) => x / 100 * (decimal)number;

    /// <summary>
    /// Calculates decimal percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static decimal PercentOf(this decimal x, ushort number) => x / 100 * (decimal)number;

    /// <summary>
    /// Subtracts byte from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, byte subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts char from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, char subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts decimal from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, decimal subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts double from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, double subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts float from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, float subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts int from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, int subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts long from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, long subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts sbyte from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, sbyte subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts short from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, short subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts uint from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, uint subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts ulong from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, ulong subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts ushort from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static decimal Substract(this decimal x, ushort subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, byte percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, char percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, decimal percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, double percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, float percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, int percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, long percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, sbyte percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, short percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, uint percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, ulong percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static decimal SubstractPercent(this decimal x, ushort percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts byte from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, byte subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts char from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, char subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts decimal from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, decimal subtrahend) => x - subtrahend;

    /// <summary>
    /// Subtracts double from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, double subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts float from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, float subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts int from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, int subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts long from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, long subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts sbyte from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, sbyte subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts short from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, short subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts uint from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, uint subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts ulong from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, ulong subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts ushort from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static decimal Subtract(this decimal x, ushort subtrahend) => x - (decimal)subtrahend;

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, byte percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, char percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, decimal percent) => x - (x * percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, double percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, float percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, int percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, long percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, sbyte percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, short percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, uint percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, ulong percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Subtracts percentage from decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static decimal SubtractPercent(this decimal x, ushort percent) => x - (x * (decimal)percent / 100);

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static decimal[] DecreaseAllValuesWith(this decimal[] array, decimal dec) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static decimal[] GetFirstHalf(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static decimal GetFirstValue(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static decimal GetHighestValue(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static decimal[] GetLastHalf(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static decimal GetLastValue(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static decimal GetLowestValue(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static decimal[] GetMiddle(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static decimal GetMiddleValue(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static decimal[] GetValuesHigherThan(this decimal[] array, decimal x) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static decimal[] GetValuesLowerThan(this decimal[] array, decimal x) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static decimal[] IncreaseAllValuesWith(this decimal[] array, decimal add) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static decimal[] RotateLeft(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static decimal[] RotateRight(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static decimal[] SetNewArraySize(this decimal[] array, int size) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static decimal[] SortArrayAsc(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static decimal[] SortArrayDesc(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static decimal SumAllValues(this decimal[] array) =>
        MarcusMedinaPro.TypedMath.DecimalCollections.TypedMathDecimalCollections.SumAllValues(array);
}
