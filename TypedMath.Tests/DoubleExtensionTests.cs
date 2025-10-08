using MarcusMedinaPro.TypedMath.DoubleExtension;
using Xunit;

namespace TypedMath.Tests;

/// <summary>
/// Tests for double extension methods
/// </summary>
public class DoubleExtensionTests
{
    #region Arithmetic Operations

    [Fact]
    public void Add_WithDouble_ReturnsCorrectSum()
    {
        var result = 10.5.Add(5.3);
        Assert.Equal(15.8, result, 10);
    }

    [Fact]
    public void Subtract_WithDouble_ReturnsCorrectDifference()
    {
        var result = 10.7.Subtract(3.2);
        Assert.Equal(7.5, result, 10);
    }

    [Fact]
    public void MultipliedWith_WithDouble_ReturnsCorrectProduct()
    {
        var result = 10.5.MultipliedWith(2.0);
        Assert.Equal(21.0, result, 10);
    }

    [Fact]
    public void DividedBy_WithDouble_ReturnsCorrectQuotient()
    {
        var result = 21.0.DividedBy(3.0);
        Assert.Equal(7.0, result, 10);
    }

    #endregion

    #region Comparison Operations

    [Fact]
    public void GreaterThan_WhenTrue_ReturnsTrue()
    {
        Assert.True(10.5.GreaterThan(5.3));
    }

    [Fact]
    public void GreaterThan_WhenFalse_ReturnsFalse()
    {
        Assert.False(5.3.GreaterThan(10.5));
    }

    [Fact]
    public void LessThan_WhenTrue_ReturnsTrue()
    {
        Assert.True(5.3.LessThan(10.5));
    }

    [Fact]
    public void LessThan_WhenFalse_ReturnsFalse()
    {
        Assert.False(10.5.LessThan(5.3));
    }

    [Fact]
    public void IsEqualTo_WhenEqual_ReturnsTrue()
    {
        Assert.True(10.5.IsEqualTo(10.5));
    }

    [Fact]
    public void IsNotEqualTo_WhenNotEqual_ReturnsTrue()
    {
        Assert.True(10.5.IsNotEqualTo(5.3));
    }

    #endregion

    #region Sign Tests

    [Fact]
    public void IsPositive_WithPositiveNumber_ReturnsTrue()
    {
        Assert.True(10.5.IsPositive());
    }

    [Fact]
    public void IsPositive_WithNegativeNumber_ReturnsFalse()
    {
        Assert.False((-10.5).IsPositive());
    }

    [Fact]
    public void IsNegative_WithNegativeNumber_ReturnsTrue()
    {
        Assert.True((-10.5).IsNegative());
    }

    [Fact]
    public void IsNegative_WithPositiveNumber_ReturnsFalse()
    {
        Assert.False(10.5.IsNegative());
    }

    [Fact]
    public void IsPositive_WithZero_ReturnsFalse()
    {
        Assert.False(0.0.IsPositive());
    }

    #endregion

    #region Percentage Operations

    [Fact]
    public void PercentOf_ReturnsCorrectPercentage()
    {
        var result = 15.2.PercentOf(1500.5);
        Assert.Equal(228.076, result, 2);
    }

    [Fact]
    public void AddPercent_ReturnsCorrectValue()
    {
        var result = 1500.5.AddPercent(20);
        Assert.Equal(1800.6, result, 2);
    }

    [Fact]
    public void SubtractPercent_ReturnsCorrectValue()
    {
        var result = 1500.5.SubtractPercent(20);
        Assert.Equal(1200.4, result, 2);
    }

    #endregion

    #region Type Casting

    [Fact]
    public void CastDoubleToInt_CastsCorrectly()
    {
        var result = 13.37.CastDoubleToInt();
        Assert.Equal(13, result);
        Assert.IsType<int>(result);
    }

    [Fact]
    public void CastDoubleToDecimal_CastsCorrectly()
    {
        var result = 13.37.CastDoubleToDecimal();
        Assert.Equal(13.37m, result, 2);
        Assert.IsType<decimal>(result);
    }

    [Fact]
    public void CastDoubleToByte_CastsCorrectly()
    {
        var result = 13.37.CastDoubleToByte();
        Assert.Equal((byte)13, result);
        Assert.IsType<byte>(result);
    }

    [Fact]
    public void CastDoubleToLong_CastsCorrectly()
    {
        var result = 13.37.CastDoubleToLong();
        Assert.Equal(13L, result);
        Assert.IsType<long>(result);
    }

    #endregion

    #region Value Selection

    [Fact]
    public void ChooseIfHigher_WithHigherValue_ReturnsOriginal()
    {
        var result = 50.5.ChooseIfHigher(32.3);
        Assert.Equal(50.5, result);
    }

    [Fact]
    public void ChooseIfHigher_WithLowerValue_ReturnsParameter()
    {
        var result = 32.3.ChooseIfHigher(50.5);
        Assert.Equal(50.5, result);
    }

    [Fact]
    public void ChooseIfLower_WithLowerValue_ReturnsOriginal()
    {
        var result = 32.3.ChooseIfLower(50.5);
        Assert.Equal(32.3, result);
    }

    [Fact]
    public void SwapWith_SwapsValues()
    {
        double x = 10.5;
        double y = 20.7;
        y.SwapWith(ref x);
        Assert.Equal(20.7, x);
        Assert.Equal(10.5, y);
    }

    #endregion

    #region Difference

    [Fact]
    public void GetDifference_WithLargerValue_ReturnsPositiveDifference()
    {
        var result = 100.5.GetDifference(129.8);
        Assert.Equal(29.3, result, 10);
    }

    [Fact]
    public void GetDifference_WithSmallerValue_ReturnsNegativeDifference()
    {
        var result = 100.5.GetDifference(35.2);
        Assert.Equal(-65.3, result, 10);
    }

    [Fact]
    public void GetDifference_WithEqualValue_ReturnsZero()
    {
        var result = 100.5.GetDifference(100.5);
        Assert.Equal(0, result, 10);
    }

    #endregion

    #region Mixed Type Operations

    [Fact]
    public void Add_WithInt_ReturnsCorrectSum()
    {
        var result = 10.5.Add(5);
        Assert.Equal(15.5, result, 10);
    }

    [Fact]
    public void Multiply_WithInt_ReturnsCorrectProduct()
    {
        var result = 10.5.MultipliedWith(2);
        Assert.Equal(21.0, result, 10);
    }

    #endregion
}
