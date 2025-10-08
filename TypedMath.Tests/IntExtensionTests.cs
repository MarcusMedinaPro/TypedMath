using MarcusMedinaPro.TypedMath.IntExtension;
using Xunit;

namespace TypedMath.Tests;

/// <summary>
/// Comprehensive tests for int extension methods
/// </summary>
public class IntExtensionTests
{
    #region Arithmetic Operations

    [Fact]
    public void Add_WithInt_ReturnsCorrectSum()
    {
        var result = 10.Add(5);
        Assert.Equal(15, result);
    }

    [Fact]
    public void Add_WithDouble_ReturnsCorrectSum()
    {
        var result = 10.Add(5.7);
        Assert.Equal(15, result); // Casts to int
    }

    [Fact]
    public void Subtract_WithInt_ReturnsCorrectDifference()
    {
        var result = 10.Subtract(3);
        Assert.Equal(7, result);
    }

    [Fact]
    public void MultipliedWith_WithInt_ReturnsCorrectProduct()
    {
        var result = 10.MultipliedWith(5);
        Assert.Equal(50, result);
    }

    [Fact]
    public void DividedBy_WithInt_ReturnsCorrectQuotient()
    {
        var result = 20.DividedBy(4);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Modulus_WithInt_ReturnsCorrectRemainder()
    {
        var result = 10.Modulus(3);
        Assert.Equal(1, result);
    }

    #endregion

    #region Comparison Operations

    [Fact]
    public void GreaterThan_WhenTrue_ReturnsTrue()
    {
        Assert.True(10.GreaterThan(5));
    }

    [Fact]
    public void GreaterThan_WhenFalse_ReturnsFalse()
    {
        Assert.False(5.GreaterThan(10));
    }

    [Fact]
    public void LessThan_WhenTrue_ReturnsTrue()
    {
        Assert.True(5.LessThan(10));
    }

    [Fact]
    public void LessThan_WhenFalse_ReturnsFalse()
    {
        Assert.False(10.LessThan(5));
    }

    [Fact]
    public void IsEqualTo_WhenEqual_ReturnsTrue()
    {
        Assert.True(10.IsEqualTo(10));
    }

    [Fact]
    public void IsNotEqualTo_WhenNotEqual_ReturnsTrue()
    {
        Assert.True(10.IsNotEqualTo(5));
    }

    #endregion

    #region Sign Tests

    [Fact]
    public void IsPositive_WithPositiveNumber_ReturnsTrue()
    {
        Assert.True(10.IsPositive());
    }

    [Fact]
    public void IsPositive_WithNegativeNumber_ReturnsFalse()
    {
        Assert.False((-10).IsPositive());
    }

    [Fact]
    public void IsNegative_WithNegativeNumber_ReturnsTrue()
    {
        Assert.True((-10).IsNegative());
    }

    [Fact]
    public void IsNegative_WithPositiveNumber_ReturnsFalse()
    {
        Assert.False(10.IsNegative());
    }

    #endregion

    #region Bitwise Operations

    [Fact]
    public void And_WithInt_ReturnsCorrectResult()
    {
        var result = 10.And(2);
        Assert.Equal(2, result); // 1010 & 0010 = 0010
    }

    [Fact]
    public void Or_WithInt_ReturnsCorrectResult()
    {
        var result = 12.Or(2);
        Assert.Equal(14, result); // 1100 | 0010 = 1110
    }

    [Fact]
    public void Xor_WithInt_ReturnsCorrectResult()
    {
        var result = 14.Xor(2);
        Assert.Equal(12, result); // 1110 ^ 0010 = 1100
    }

    [Fact]
    public void Not_ReturnsCorrectResult()
    {
        var result = 16.Not();
        Assert.Equal(-17, result); // ~16 = -17
    }

    [Fact]
    public void ShiftLeft_ReturnsCorrectResult()
    {
        var result = 42.ShiftLeft(1);
        Assert.Equal(84, result); // 42 << 1 = 84
    }

    [Fact]
    public void ShiftRight_ReturnsCorrectResult()
    {
        var result = 24.ShiftRight(1);
        Assert.Equal(12, result); // 24 >> 1 = 12
    }

    #endregion

    #region Percentage Operations

    [Fact]
    public void PercentOf_ReturnsCorrectPercentage()
    {
        var result = 20.PercentOf(1000);
        Assert.Equal(200, result); // 20% of 1000 = 200
    }

    [Fact]
    public void AddPercent_ReturnsCorrectValue()
    {
        var result = 100.AddPercent(50);
        Assert.Equal(150, result); // 100 + 50% = 150
    }

    [Fact]
    public void SubtractPercent_ReturnsCorrectValue()
    {
        var result = 100.SubtractPercent(25);
        Assert.Equal(75, result); // 100 - 25% = 75
    }

    #endregion

    #region Value Selection

    [Fact]
    public void ChooseIfHigher_WithHigherValue_ReturnsOriginal()
    {
        var result = 50.ChooseIfHigher(32);
        Assert.Equal(50, result);
    }

    [Fact]
    public void ChooseIfHigher_WithLowerValue_ReturnsParameter()
    {
        var result = 32.ChooseIfHigher(50);
        Assert.Equal(50, result);
    }

    [Fact]
    public void ChooseIfLower_WithLowerValue_ReturnsOriginal()
    {
        var result = 32.ChooseIfLower(50);
        Assert.Equal(32, result);
    }

    [Fact]
    public void SwapWith_SwapsValues()
    {
        int x = 10;
        int y = 20;
        y.SwapWith(ref x);
        Assert.Equal(20, x);
        Assert.Equal(10, y);
    }

    #endregion

    #region Prime Number Tests

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(7, true)]
    [InlineData(11, true)]
    [InlineData(13, true)]
    [InlineData(17, true)]
    [InlineData(19, true)]
    public void IsPrime_WithPrimeNumber_ReturnsTrue(int value, bool expected)
    {
        Assert.Equal(expected, value.IsPrime());
    }

    [Theory]
    [InlineData(0, false)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    [InlineData(6, false)]
    [InlineData(8, false)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(12, false)]
    public void IsPrime_WithNonPrimeNumber_ReturnsFalse(int value, bool expected)
    {
        Assert.Equal(expected, value.IsPrime());
    }

    #endregion

    #region Difference

    [Fact]
    public void GetDifference_WithLargerValue_ReturnsPositiveDifference()
    {
        var result = 100.GetDifference(129);
        Assert.Equal(29, result);
    }

    [Fact]
    public void GetDifference_WithSmallerValue_ReturnsNegativeDifference()
    {
        var result = 100.GetDifference(35);
        Assert.Equal(-65, result);
    }

    [Fact]
    public void GetDifference_WithEqualValue_ReturnsZero()
    {
        var result = 100.GetDifference(100);
        Assert.Equal(0, result);
    }

    #endregion
}
