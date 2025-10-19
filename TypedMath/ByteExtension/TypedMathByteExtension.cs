// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathByteExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ByteExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for byte
/// </summary>
public static class TypedMathByteExtension
{

    /// <summary>
    /// Adds byte to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, byte addend) => (byte)(x + addend);

    /// <summary>
    /// Adds char to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, char addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds decimal to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, decimal addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds double to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, double addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds float to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, float addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds int to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, int addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds long to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, long addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds sbyte to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, sbyte addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds short to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, short addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds uint to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, uint addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds ulong to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, ulong addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds ushort to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static byte Add(this byte x, ushort addend) => (byte)(x + (byte)addend);

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, byte percent) => (byte)(x + (x * percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, char percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, decimal percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, double percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, float percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, int percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, long percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, sbyte percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, short percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, uint percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, ulong percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Adds percentage to byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static byte AddPercent(this byte x, ushort percent) => (byte)(x + (x * (byte)percent / 100));

    /// <summary>
    /// Returns byte if higher than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, byte other) => (byte)(x > other ? x : other);

    /// <summary>
    /// Returns byte if higher than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, char other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, decimal other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, double other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, float other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, int other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, long other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, sbyte other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, short other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, uint other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, ulong other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if higher than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static byte ChooseIfHigher(this byte x, ushort other) => (byte)(x > (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than byte, otherwise byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, byte other) => (byte)(x < other ? x : other);

    /// <summary>
    /// Returns byte if lower than char, otherwise char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, char other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, decimal other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than double, otherwise double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, double other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than float, otherwise float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, float other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than int, otherwise int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, int other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than long, otherwise long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, long other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than sbyte, otherwise sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, sbyte other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than short, otherwise short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, short other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than uint, otherwise uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, uint other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than ulong, otherwise ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, ulong other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Returns byte if lower than ushort, otherwise ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static byte ChooseIfLower(this byte x, ushort other) => (byte)(x < (byte)other ? x : (byte)other);

    /// <summary>
    /// Gets absolute difference between byte and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, byte other) => (byte)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, char other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, decimal other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, double other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, float other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, int other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, long other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, sbyte other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, short other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, uint other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, ulong other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static byte DiferenceFrom(this byte x, ushort other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, byte other) => (byte)(x > other ? x - other : x < other ? other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, char other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, decimal other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, double other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, float other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, int other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, long other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, sbyte other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, short other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, uint other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, ulong other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Gets absolute difference between byte and ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static byte DifferenceFrom(this byte x, ushort other) => (byte)(x > (byte)other ? x - (byte)other : x < (byte)other ? (byte)other - x : 0);

    /// <summary>
    /// Divides byte by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, byte divisor) => (byte)(x / divisor);

    /// <summary>
    /// Divides byte by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, char divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, decimal divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, double divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, float divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, int divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, long divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, sbyte divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, short divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, uint divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, ulong divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Divides byte by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static byte DividedBy(this byte x, ushort divisor) => (byte)(x / (byte)divisor);

    /// <summary>
    /// Checks if byte is greater than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, byte other) => x > other;

    /// <summary>
    /// Checks if byte is greater than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, char other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, decimal other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, double other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, float other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, int other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, long other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, sbyte other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, short other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, uint other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, ulong other) => x > (byte)other;

    /// <summary>
    /// Checks if byte is greater than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this byte x, ushort other) => x > (byte)other;

    /// <summary>
    /// Checks if byte equals byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, byte other) => x == other;

    /// <summary>
    /// Checks if byte equals char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, char other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, decimal other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, double other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, float other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, int other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, long other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, sbyte other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, short other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, uint other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, ulong other) => x == (byte)other;

    /// <summary>
    /// Checks if byte equals ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this byte x, ushort other) => x == (byte)other;

    /// <summary>
    /// Gets boolean true if byte is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this byte x) => x < 0;

    /// <summary>
    /// Checks if byte does not equal byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, byte other) => x != other;

    /// <summary>
    /// Checks if byte does not equal char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, char other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, decimal other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, double other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, float other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, int other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, long other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, sbyte other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, short other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, uint other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, ulong other) => x != (byte)other;

    /// <summary>
    /// Checks if byte does not equal ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this byte x, ushort other) => x != (byte)other;

    /// <summary>
    /// Gets boolean true if byte is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this byte x) => x > 0;

    /// <summary>
    /// Checks if byte is less than byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, byte other) => x < other;

    /// <summary>
    /// Checks if byte is less than char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, char other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, decimal other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, double other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, float other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, int other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, long other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, sbyte other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, short other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, uint other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, ulong other) => x < (byte)other;

    /// <summary>
    /// Checks if byte is less than ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this byte x, ushort other) => x < (byte)other;

    /// <summary>
    /// Gets remainder of byte divided by byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, byte divisor) => (byte)(x % divisor);

    /// <summary>
    /// Gets remainder of byte divided by char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, char divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, decimal divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, double divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, float divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, int divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, long divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, sbyte divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, short divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, uint divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, ulong divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Gets remainder of byte divided by ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static byte Modulus(this byte x, ushort divisor) => (byte)(x % (byte)divisor);

    /// <summary>
    /// Multiplies byte with byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, byte multiplier) => (byte)(x * multiplier);

    /// <summary>
    /// Multiplies byte with char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, char multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, decimal multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, double multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, float multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, int multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, long multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, sbyte multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, short multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, uint multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, ulong multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Multiplies byte with ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static byte MultipliedWith(this byte x, ushort multiplier) => (byte)(x * (byte)multiplier);

    /// <summary>
    /// Calculates byte percent of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, byte number) => (byte)(x / 100 * number);

    /// <summary>
    /// Calculates byte percent of char
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, char number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, decimal number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of double
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, double number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of float
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, float number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of int
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, int number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of long
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, long number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of sbyte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, sbyte number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of short
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, short number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of uint
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, uint number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of ulong
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, ulong number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Calculates byte percent of ushort
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static byte PercentOf(this byte x, ushort number) => (byte)(x / 100 * (byte)number);

    /// <summary>
    /// Subtracts byte from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, byte subtrahend) => (byte)(x - subtrahend);

    /// <summary>
    /// Subtracts char from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, char subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts decimal from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, decimal subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts double from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, double subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts float from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, float subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts int from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, int subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts long from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, long subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts sbyte from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, sbyte subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts short from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, short subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts uint from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, uint subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts ulong from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, ulong subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts ushort from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static byte Substract(this byte x, ushort subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, byte percent) => (byte)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, char percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, decimal percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, double percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, float percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, int percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, long percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, sbyte percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, short percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, uint percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, ulong percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage of byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static byte SubstractPercent(this byte x, ushort percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts byte from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, byte subtrahend) => (byte)(x - subtrahend);

    /// <summary>
    /// Subtracts char from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, char subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts decimal from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, decimal subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts double from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, double subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts float from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, float subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts int from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, int subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts long from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, long subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts sbyte from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, sbyte subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts short from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, short subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts uint from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, uint subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts ulong from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, ulong subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts ushort from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static byte Subtract(this byte x, ushort subtrahend) => (byte)(x - (byte)subtrahend);

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, byte percent) => (byte)(x - (x * percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, char percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, decimal percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, double percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, float percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, int percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, long percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, sbyte percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, short percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, uint percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, ulong percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Subtracts percentage from byte
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static byte SubtractPercent(this byte x, ushort percent) => (byte)(x - (x * (byte)percent / 100));

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static byte[] DecreaseAllValuesWith(this byte[] array, byte dec) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static byte[] GetFirstHalf(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static byte GetFirstValue(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static byte GetHighestValue(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static byte[] GetLastHalf(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static byte GetLastValue(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static byte GetLowestValue(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static byte[] GetMiddle(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static byte GetMiddleValue(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static byte[] GetValuesHigherThan(this byte[] array, byte x) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static byte[] GetValuesLowerThan(this byte[] array, byte x) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static byte[] IncreaseAllValuesWith(this byte[] array, byte add) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static byte[] RotateLeft(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static byte[] RotateRight(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static byte[] SetNewArraySize(this byte[] array, int size) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static byte[] SortArrayAsc(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static byte[] SortArrayDesc(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static byte SumAllValues(this byte[] array) =>
        MarcusMedinaPro.TypedMath.ByteCollections.TypedMathByteCollections.SumAllValues(array);
}
