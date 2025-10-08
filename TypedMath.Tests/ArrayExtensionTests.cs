using MarcusMedinaPro.TypedMath.DoubleExtension;
using Xunit;

namespace TypedMath.Tests;

/// <summary>
/// Tests for array extension methods
/// </summary>
public class ArrayExtensionTests
{
    private readonly double[] _testArray = { 10, 42, 20.13, 91.4, 30, 1, 3, 11, 29, 46 };

    #region Basic Array Operations

    [Fact]
    public void GetAverage_ReturnsCorrectAverage()
    {
        var result = _testArray.GetAverage();
        Assert.Equal(28.353, result, 3);
    }

    [Fact]
    public void GetFirstValue_ReturnsFirstElement()
    {
        var result = _testArray.GetFirstValue();
        Assert.Equal(10, result);
    }

    [Fact]
    public void GetLastValue_ReturnsLastElement()
    {
        var result = _testArray.GetLastValue();
        Assert.Equal(46, result);
    }

    [Fact]
    public void GetMiddleValue_ReturnsMiddleElement()
    {
        var result = _testArray.GetMiddleValue();
        Assert.Equal(30, result); // Index 4 in 10-element array
    }

    #endregion

    #region Min/Max Operations

    [Fact]
    public void GetHighestValue_ReturnsMaximumValue()
    {
        var result = _testArray.GetHighestValue();
        Assert.Equal(91.4, result);
    }

    [Fact]
    public void GetLowestValue_ReturnsMinimumValue()
    {
        var result = _testArray.GetLowestValue();
        Assert.Equal(1, result);
    }

    #endregion

    #region Filtering Operations

    [Fact]
    public void GetValuesHigherThan_ReturnsCorrectElements()
    {
        var result = _testArray.GetValuesHigherThan(30);
        Assert.Equal(3, result.Length); // 42, 91.4, 46
        Assert.Contains(42, result);
        Assert.Contains(91.4, result);
        Assert.Contains(46, result);
    }

    [Fact]
    public void GetValuesLowerThan_ReturnsCorrectElements()
    {
        var result = _testArray.GetValuesLowerThan(10);
        Assert.Equal(2, result.Length); // 1, 3
        Assert.Contains(1, result);
        Assert.Contains(3, result);
    }

    #endregion

    #region Sorting Operations

    [Fact]
    public void SortArrayAsc_SortsInAscendingOrder()
    {
        var result = _testArray.SortArrayAsc();
        Assert.Equal(1, result[0]);
        Assert.Equal(91.4, result[^1]);

        // Verify sorted order
        for (int i = 0; i < result.Length - 1; i++)
        {
            Assert.True(result[i] <= result[i + 1]);
        }
    }

    [Fact]
    public void SortArrayDesc_SortsInDescendingOrder()
    {
        var result = _testArray.SortArrayDesc();
        Assert.Equal(91.4, result[0]);
        Assert.Equal(1, result[^1]);

        // Verify sorted order
        for (int i = 0; i < result.Length - 1; i++)
        {
            Assert.True(result[i] >= result[i + 1]);
        }
    }

    #endregion

    #region Array Manipulation

    [Fact]
    public void SetNewArraySize_ResizesArray()
    {
        var result = _testArray.SetNewArraySize(15);
        Assert.Equal(15, result.Length);

        // Original values should be preserved
        for (int i = 0; i < _testArray.Length; i++)
        {
            Assert.Equal(_testArray[i], result[i]);
        }
    }

    [Fact]
    public void SumAllValues_ReturnsCorrectSum()
    {
        var result = _testArray.SumAllValues();
        Assert.Equal(283.53, result, 2);
    }

    [Fact]
    public void RotateLeft_RotatesArrayLeft()
    {
        var original = new double[] { 1, 2, 3, 4, 5 };
        var result = original.RotateLeft();

        Assert.Equal(2, result[0]);
        Assert.Equal(3, result[1]);
        Assert.Equal(4, result[2]);
        Assert.Equal(5, result[3]);
        Assert.Equal(1, result[4]);
    }

    [Fact]
    public void RotateRight_RotatesArrayRight()
    {
        var original = new double[] { 1, 2, 3, 4, 5 };
        var result = original.RotateRight();

        Assert.Equal(5, result[0]);
        Assert.Equal(1, result[1]);
        Assert.Equal(2, result[2]);
        Assert.Equal(3, result[3]);
        Assert.Equal(4, result[4]);
    }

    #endregion

    #region Value Modification

    [Fact]
    public void IncreaseAllValuesWith_IncreasesAllElements()
    {
        var original = new double[] { 10, 20, 30 };
        var result = original.IncreaseAllValuesWith(5);

        Assert.Equal(15, result[0]);
        Assert.Equal(25, result[1]);
        Assert.Equal(35, result[2]);
    }

    [Fact]
    public void DecreaseAllValuesWith_DecreasesAllElements()
    {
        var original = new double[] { 20, 30, 40 };
        var result = original.DecreaseAllValuesWith(10);

        Assert.Equal(10, result[0]);
        Assert.Equal(20, result[1]);
        Assert.Equal(30, result[2]);
    }

    #endregion

    #region Array Sections

    [Fact]
    public void GetFirstHalf_ReturnsFirstHalfOfArray()
    {
        var original = new double[] { 1, 2, 3, 4, 5, 6 };
        var result = original.GetFirstHalf();

        Assert.Equal(3, result.Length);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
        Assert.Equal(3, result[2]);
    }

    [Fact]
    public void GetLastHalf_ReturnsLastHalfOfArray()
    {
        var original = new double[] { 1, 2, 3, 4, 5, 6 };
        var result = original.GetLastHalf();

        Assert.Equal(3, result.Length);
        Assert.Equal(4, result[0]);
        Assert.Equal(5, result[1]);
        Assert.Equal(6, result[2]);
    }

    [Fact]
    public void GetMiddle_ReturnsMiddleElementsOfArray()
    {
        var original = new double[] { 1, 2, 3, 4, 5, 6 };
        var result = original.GetMiddle();

        // Should return middle elements (excluding first and last)
        Assert.Equal(4, result.Length);
        Assert.Equal(2, result[0]);
        Assert.Equal(5, result[3]);
    }

    #endregion

    #region Type Conversion

    [Fact]
    public void ConvertArrayToInt_ConvertsToIntArray()
    {
        var original = new double[] { 1.7, 2.3, 3.9 };
        var result = original.ConvertArrayToInt();

        Assert.IsType<int[]>(result);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
        Assert.Equal(3, result[2]);
    }

    #endregion
}
