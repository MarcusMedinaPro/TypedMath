// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathShortCollections.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ShortCollections;

using System;
using System.Linq;

/// <summary>
/// Collection extensions for short arrays
/// </summary>
public static class TypedMathShortCollections
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
    public static short[] DecreaseAllValuesWith(this short[] array, short dec) => [.. array.Select(x => (short)(x - dec))];

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    public static double GetAverage(this short[] array) => array.Average(x => (double)x);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Take(array.Length / 2).ToArray()
    /// </remarks>
    public static short[] GetFirstHalf(this short[] array) => [.. array.Take(array.Length / 2)];

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    public static short GetFirstValue(this short[] array) => array.First();

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    public static short GetHighestValue(this short[] array) => array.Max();

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 2).ToArray()
    /// </remarks>
    public static short[] GetLastHalf(this short[] array) => [.. array.Skip(array.Length / 2).Take(array.Length / 2)];

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Last() or array[^1]
    /// </remarks>
    public static short GetLastValue(this short[] array) => array.Last();

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    public static short GetLowestValue(this short[] array) => array.Min();

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 4).Take(array.Length / 2).ToArray()
    /// </remarks>
    public static short[] GetMiddle(this short[] array) => [.. array.Skip(array.Length / 4).Take(array.Length / 2)];

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    /// <remarks>
    /// This can also be done with Linq: array[array.Length / 2]
    /// </remarks>
    public static short GetMiddleValue(this short[] array) => array[array.Length / 2];

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    public static short[] GetValuesHigherThan(this short[] array, short x) => [.. array.Where(y => y >= x)];

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    public static short[] GetValuesLowerThan(this short[] array, short x) => [.. array.Where(y => y <= x)];

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Select(x => x + add).ToArray()
    /// </remarks>
    public static short[] IncreaseAllValuesWith(this short[] array, short add) => [.. array.Select(x => (short)(x + add))];

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    public static short[] RotateLeft(this short[] array)
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
    public static short[] RotateRight(this short[] array)
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
    public static short[] SetNewArraySize(this short[] array, int size)
    {
        var newArr = new short[size];
        Array.Copy(array, 0, newArr, 0, array.Length);
        return newArr;
    }

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    public static short[] SortArrayAsc(this short[] array) => [.. array.OrderBy(x => x)];

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    public static short[] SortArrayDesc(this short[] array) => [.. array.OrderByDescending(x => x)];

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    public static short SumAllValues(this short[] array) => (short)array.Sum(x => (int)x);
}
