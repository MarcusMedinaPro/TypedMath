// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathCharCollections.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.CharCollections;

using System;
using System.Linq;

/// <summary>
/// Collection extensions for char arrays
/// </summary>
public static class TypedMathCharCollections
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
    public static char[] DecreaseAllValuesWith(this char[] array, char dec) => [.. array.Select(x => (char)(x - dec))];

    /// <summary>
    /// Peeks the average value of the numbers in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The average value</returns>
    public static double GetAverage(this char[] array) => array.Average(x => (double)x);

    /// <summary>
    /// Gets the first half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Take(array.Length / 2).ToArray()
    /// </remarks>
    public static char[] GetFirstHalf(this char[] array) => [.. array.Take(array.Length / 2)];

    /// <summary>
    /// Gets the first value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The first value</returns>
    public static char GetFirstValue(this char[] array) => array.First();

    /// <summary>
    /// Gets the highest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The highest value</returns>
    public static char GetHighestValue(this char[] array) => array.Max();

    /// <summary>
    /// Gets the last half of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last half of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 2).ToArray()
    /// </remarks>
    public static char[] GetLastHalf(this char[] array) => [.. array.Skip(array.Length / 2).Take(array.Length / 2)];

    /// <summary>
    /// Gets the last value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The last value</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Last() or array[^1]
    /// </remarks>
    public static char GetLastValue(this char[] array) => array.Last();

    /// <summary>
    /// Gets the lowest value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The lowest value</returns>
    public static char GetLowestValue(this char[] array) => array.Min();

    /// <summary>
    /// Gets the middle portion of the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle portion of the array</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Skip(array.Length / 4).Take(array.Length / 2).ToArray()
    /// </remarks>
    public static char[] GetMiddle(this char[] array) => [.. array.Skip(array.Length / 4).Take(array.Length / 2)];

    /// <summary>
    /// Gets the middle value in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The middle value</returns>
    /// <remarks>
    /// This can also be done with Linq: array[array.Length / 2]
    /// </remarks>
    public static char GetMiddleValue(this char[] array) => array[array.Length / 2];

    /// <summary>
    /// Gets all values higher than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values higher than or equal to threshold</returns>
    public static char[] GetValuesHigherThan(this char[] array, char x) => [.. array.Where(y => y >= x)];

    /// <summary>
    /// Gets all values lower than or equal to the specified value
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="x">The threshold value</param>
    /// <returns>Array of values lower than or equal to threshold</returns>
    public static char[] GetValuesLowerThan(this char[] array, char x) => [.. array.Where(y => y <= x)];

    /// <summary>
    /// Increases all values in the array by the specified amount
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="add">The amount to add</param>
    /// <returns>Array with all values increased</returns>
    /// <remarks>
    /// This can also be done with Linq: array.Select(x => x + add).ToArray()
    /// </remarks>
    public static char[] IncreaseAllValuesWith(this char[] array, char add) => [.. array.Select(x => (char)(x + add))];

    /// <summary>
    /// Rotates the numbers to the left
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The rotated array</returns>
    public static char[] RotateLeft(this char[] array)
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
    public static char[] RotateRight(this char[] array)
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
    public static char[] SetNewArraySize(this char[] array, int size)
    {
        var newArr = new char[size];
        Array.Copy(array, 0, newArr, 0, array.Length);
        return newArr;
    }

    /// <summary>
    /// Sorts the array in ascending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in ascending order</returns>
    public static char[] SortArrayAsc(this char[] array) => [.. array.OrderBy(x => x)];

    /// <summary>
    /// Sorts the array in descending order
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>Array sorted in descending order</returns>
    public static char[] SortArrayDesc(this char[] array) => [.. array.OrderByDescending(x => x)];

    /// <summary>
    /// Sums all values in the array
    /// </summary>
    /// <param name="array">The array</param>
    /// <returns>The sum of all values</returns>
    public static char SumAllValues(this char[] array) => (char)array.Sum(x => (int)x);
}
