// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathHalfExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.HalfExtension;

using System;
using System.Linq;

/// <summary>
/// Extension for Half
/// </summary>
public static class TypedMathHalfExtension
{

    /// <summary>
    /// Adds decimal to Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Half Add(this Half x, decimal addend) => (Half)((float)x + (float)addend);

    /// <summary>
    /// Adds Half to Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="addend">The value to add</param>
    /// <returns>The sum of both values</returns>
    public static Half Add(this Half x, Half addend) => (Half)((float)x + (float)addend);

    /// <summary>
    /// Adds percentage to Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Half AddPercent(this Half x, decimal percent) => (Half)((float)x + ((float)x * (float)percent / 100f));

    /// <summary>
    /// Adds percentage to Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to add</param>
    /// <returns>The value after adding the percentage</returns>
    public static Half AddPercent(this Half x, Half percent) => (Half)((float)x + ((float)x * (float)percent / 100f));

    /// <summary>
    /// Returns Half if higher than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Half ChooseIfHigher(this Half x, decimal other) => (Half)((float)x > (float)other ? (float)x : (float)other);

    /// <summary>
    /// Returns Half if higher than Half, otherwise Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The higher of the two values</returns>
    public static Half ChooseIfHigher(this Half x, Half other) => (Half)((float)x > (float)other ? (float)x : (float)other);

    /// <summary>
    /// Returns Half if lower than decimal, otherwise decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Half ChooseIfLower(this Half x, decimal other) => (Half)((float)x < (float)other ? (float)x : (float)other);

    /// <summary>
    /// Returns Half if lower than Half, otherwise Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The lower of the two values</returns>
    public static Half ChooseIfLower(this Half x, Half other) => (Half)((float)x < (float)other ? (float)x : (float)other);

    /// <summary>
    /// Gets absolute difference between Half and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Half DiferenceFrom(this Half x, decimal other) => (Half)((float)x > (float)other ? (float)x - (float)other : (float)x < (float)other ? (float)other - (float)x : 0f);

    /// <summary>
    /// Gets absolute difference between Half and Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use DifferenceFrom() instead.")]
    public static Half DiferenceFrom(this Half x, Half other) => (Half)((float)x > (float)other ? (float)x - (float)other : (float)x < (float)other ? (float)other - (float)x : 0f);

    /// <summary>
    /// Gets absolute difference between Half and decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Half DifferenceFrom(this Half x, decimal other) => (Half)((float)x > (float)other ? (float)x - (float)other : (float)x < (float)other ? (float)other - (float)x : 0f);

    /// <summary>
    /// Gets absolute difference between Half and Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>The absolute difference between the values</returns>
    public static Half DifferenceFrom(this Half x, Half other) => (Half)((float)x > (float)other ? (float)x - (float)other : (float)x < (float)other ? (float)other - (float)x : 0f);

    /// <summary>
    /// Divides Half by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Half DividedBy(this Half x, decimal divisor) => (Half)((float)x / (float)divisor);

    /// <summary>
    /// Divides Half by Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The result of the division</returns>
    public static Half DividedBy(this Half x, Half divisor) => (Half)((float)x / (float)divisor);

    /// <summary>
    /// Checks if Half is greater than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Half x, decimal other) => x > (Half)other;

    /// <summary>
    /// Checks if Half is greater than Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is greater than the other value</returns>
    public static bool GreaterThan(this Half x, Half other) => x > other;

    /// <summary>
    /// Checks if Half equals decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Half x, decimal other) => x == (Half)other;

    /// <summary>
    /// Checks if Half equals Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are equal</returns>
    public static bool IsEqualTo(this Half x, Half other) => x == other;

    /// <summary>
    /// Gets boolean true if Half is less than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is negative</returns>
    public static bool IsNegative(this Half x) => x < (Half)0;

    /// <summary>
    /// Checks if Half does not equal decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Half x, decimal other) => x != (Half)other;

    /// <summary>
    /// Checks if Half does not equal Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if values are not equal</returns>
    public static bool IsNotEqualTo(this Half x, Half other) => x != other;

    /// <summary>
    /// Gets boolean true if Half is more than zero
    /// </summary>
    /// <param name="x">The original value</param>
    /// <returns>True if the value is positive</returns>
    public static bool IsPositive(this Half x) => x > (Half)0;

    /// <summary>
    /// Checks if Half is less than decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Half x, decimal other) => x < (Half)other;

    /// <summary>
    /// Checks if Half is less than Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="other">The value to compare with</param>
    /// <returns>True if this value is less than the other value</returns>
    public static bool LessThan(this Half x, Half other) => x < other;

    /// <summary>
    /// Gets remainder of Half divided by decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Half Modulus(this Half x, decimal divisor) => (Half)((float)x % (float)divisor);

    /// <summary>
    /// Gets remainder of Half divided by Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="divisor">The divisor value</param>
    /// <returns>The remainder of the division</returns>
    public static Half Modulus(this Half x, Half divisor) => (Half)((float)x % (float)divisor);

    /// <summary>
    /// Multiplies Half with decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Half MultipliedWith(this Half x, decimal multiplier) => (Half)((float)x * (float)multiplier);

    /// <summary>
    /// Multiplies Half with Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="multiplier">The multiplier value</param>
    /// <returns>The result of the multiplication</returns>
    public static Half MultipliedWith(this Half x, Half multiplier) => (Half)((float)x * (float)multiplier);

    /// <summary>
    /// Calculates Half percent of decimal
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Half PercentOf(this Half x, decimal number) => (Half)((float)x / 100f * (float)number);

    /// <summary>
    /// Calculates Half percent of Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="number">The value to calculate percentage of</param>
    /// <returns>The percentage of the value</returns>
    public static Half PercentOf(this Half x, Half number) => (Half)((float)x / 100f * (float)number);

    /// <summary>
    /// Subtracts decimal from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Half Substract(this Half x, decimal subtrahend) => (Half)((float)x - (float)subtrahend);

    /// <summary>
    /// Subtracts Half from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use Subtract() instead.")]
    public static Half Substract(this Half x, Half subtrahend) => (Half)((float)x - (float)subtrahend);

    /// <summary>
    /// Subtracts percentage of Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Half SubstractPercent(this Half x, decimal percent) => (Half)((float)x - ((float)x * (float)percent / 100f));

    /// <summary>
    /// Subtracts percentage of Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    [Obsolete("This method will be removed in v2.0 due to typo in name. Use SubtractPercent() instead.")]
    public static Half SubstractPercent(this Half x, Half percent) => (Half)((float)x - ((float)x * (float)percent / 100f));

    /// <summary>
    /// Subtracts decimal from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Half Subtract(this Half x, decimal subtrahend) => (Half)((float)x - (float)subtrahend);

    /// <summary>
    /// Subtracts Half from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="subtrahend">The value to subtract</param>
    /// <returns>The difference between the values</returns>
    public static Half Subtract(this Half x, Half subtrahend) => (Half)((float)x - (float)subtrahend);

    /// <summary>
    /// Subtracts percentage from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Half SubtractPercent(this Half x, decimal percent) => (Half)((float)x - ((float)x * (float)percent / 100f));

    /// <summary>
    /// Subtracts percentage from Half
    /// </summary>
    /// <param name="x">The original value</param>
    /// <param name="percent">The percentage to subtract</param>
    /// <returns>The value after subtracting the percentage</returns>
    public static Half SubtractPercent(this Half x, Half percent) => (Half)((float)x - ((float)x * (float)percent / 100f));

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.DecreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static Half[] DecreaseAllValuesWith(this Half[] array, Half dec) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.DecreaseAllValuesWith(array, dec);

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetAverage(). This method will be removed in v2.0.", false)]
    public static double GetAverage(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetAverage(array);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetFirstHalf(). This method will be removed in v2.0.", false)]
    public static Half[] GetFirstHalf(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetFirstHalf(array);

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetFirstValue(). This method will be removed in v2.0.", false)]
    public static Half GetFirstValue(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetFirstValue(array);

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetHighestValue(). This method will be removed in v2.0.", false)]
    public static Half GetHighestValue(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetHighestValue(array);

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLastHalf(). This method will be removed in v2.0.", false)]
    public static Half[] GetLastHalf(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLastHalf(array);

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLastValue(). This method will be removed in v2.0.", false)]
    public static Half GetLastValue(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLastValue(array);

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLowestValue(). This method will be removed in v2.0.", false)]
    public static Half GetLowestValue(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetLowestValue(array);

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetMiddle(). This method will be removed in v2.0.", false)]
    public static Half[] GetMiddle(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetMiddle(array);

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetMiddleValue(). This method will be removed in v2.0.", false)]
    public static Half GetMiddleValue(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetMiddleValue(array);

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetValuesHigherThan(). This method will be removed in v2.0.", false)]
    public static Half[] GetValuesHigherThan(this Half[] array, Half x) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetValuesHigherThan(array, x);

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetValuesLowerThan(). This method will be removed in v2.0.", false)]
    public static Half[] GetValuesLowerThan(this Half[] array, Half x) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.GetValuesLowerThan(array, x);

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.IncreaseAllValuesWith(). This method will be removed in v2.0.", false)]
    public static Half[] IncreaseAllValuesWith(this Half[] array, Half add) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.IncreaseAllValuesWith(array, add);

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.RotateLeft(). This method will be removed in v2.0.", false)]
    public static Half[] RotateLeft(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.RotateLeft(array);

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.RotateRight(). This method will be removed in v2.0.", false)]
    public static Half[] RotateRight(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.RotateRight(array);

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SetNewArraySize(). This method will be removed in v2.0.", false)]
    public static Half[] SetNewArraySize(this Half[] array, int size) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SetNewArraySize(array, size);

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SortArrayAsc(). This method will be removed in v2.0.", false)]
    public static Half[] SortArrayAsc(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SortArrayAsc(array);

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SortArrayDesc(). This method will be removed in v2.0.", false)]
    public static Half[] SortArrayDesc(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SortArrayDesc(array);

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    [Obsolete("Moved to MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SumAllValues(). This method will be removed in v2.0.", false)]
    public static Half SumAllValues(this Half[] array) =>
        MarcusMedinaPro.TypedMath.HalfCollections.TypedMathHalfCollections.SumAllValues(array);
}
