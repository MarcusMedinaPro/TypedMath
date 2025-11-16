// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDecimalCollections.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.DecimalCollections;

using System;
using System.Linq;

/// <summary>
/// Collection extensions for decimal arrays
/// </summary>
public static class TypedMathDecimalCollections
{

    /// <summary>
    /// Decreases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="dec">The amount to subtract</param>
    /// <returns>Array with all values decreased</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Select(x => x - dec).ToArray()
    /// </remarks>
    public static decimal[] DecreaseAllValuesWith(this decimal[] array, decimal dec) => [.. array.Select(x => x - dec)];

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    public static double GetAverage(this decimal[] array) => array.Average(x => (double)x);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Take(array.Length / 2).ToArray()
    /// </remarks>
    public static decimal[] GetFirstHalf(this decimal[] array) => [.. array.Take(array.Length / 2)];

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    public static decimal GetFirstValue(this decimal[] array) => array.First();

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    public static decimal GetHighestValue(this decimal[] array) => array.Max();

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 2).ToArray()
    /// </remarks>
    public static decimal[] GetLastHalf(this decimal[] array) => [.. array.Skip(array.Length / 2).Take(array.Length / 2)];

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Last() or array[^1]
    /// </remarks>
    public static decimal GetLastValue(this decimal[] array) => array.Last();

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    public static decimal GetLowestValue(this decimal[] array) => array.Min();

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 4).Take(array.Length / 2).ToArray()
    /// </remarks>
    public static decimal[] GetMiddle(this decimal[] array) => [.. array.Skip(array.Length / 4).Take(array.Length / 2)];

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    /// <remarks>
    /// This can also be done with Linq: array[array.Length / 2]
    /// </remarks>
    public static decimal GetMiddleValue(this decimal[] array) => array[array.Length / 2];

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    public static decimal[] GetValuesHigherThan(this decimal[] array, decimal x) => [.. array.Where(y => y >= x)];

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    public static decimal[] GetValuesLowerThan(this decimal[] array, decimal x) => [.. array.Where(y => y <= x)];

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Select(x => x + add).ToArray()
    /// </remarks>
    public static decimal[] IncreaseAllValuesWith(this decimal[] array, decimal add) => [.. array.Select(x => x + add)];

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    public static decimal[] RotateLeft(this decimal[] array)
    {
        var first = array[0];
        Array.Copy(array, 1, array, 0, array.Length - 1);
        array[^1] = first;
        return array;
    }

    /// <summary>
    /// Rotates the numbers to the right
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    public static decimal[] RotateRight(this decimal[] array)
    {
        var last = array[^1];
        Array.Copy(array, 0, array, 1, array.Length - 1);
        array[0] = last;
        return array;
    }

    /// <summary>
    /// Sets a new size for the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="size">The new size</param>
    /// <returns>Array with new size</returns>
    public static decimal[] SetNewArraySize(this decimal[] array, int size)
    {
        var newArr = new decimal[size];
        Array.Copy(array, 0, newArr, 0, array.Length);
        return newArr;
    }

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    public static decimal[] SortArrayAsc(this decimal[] array) => [.. array.OrderBy(x => x)];

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    public static decimal[] SortArrayDesc(this decimal[] array) => [.. array.OrderByDescending(x => x)];

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    public static decimal SumAllValues(this decimal[] array) => array.Sum();
}
