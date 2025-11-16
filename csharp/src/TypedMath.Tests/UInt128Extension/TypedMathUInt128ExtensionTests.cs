namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UInt128Extension;
    using Xunit;

    /// <summary>
    /// Smoke tests for UInt128 extension methods
    /// </summary>
    public class TypedMathUInt128ExtensionTests
    {

        [Fact]
        public void Add_WithUInt128_Works()
        {
            _ = ((UInt128)10).Add(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithUInt128_Works()
        {
            _ = ((UInt128)10).AddPercent(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithUInt128_Works()
        {
            _ = ((UInt128)10).ChooseIfHigher(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithUInt128_Works()
        {
            _ = ((UInt128)10).ChooseIfLower(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithUInt128_Works()
        {
            _ = ((UInt128)10).DifferenceFrom(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithUInt128_Works()
        {
            _ = ((UInt128)10).DividedBy(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithUInt128_Works()
        {
            _ = ((UInt128)10).GreaterThan(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithUInt128_Works()
        {
            _ = ((UInt128)10).IsEqualTo(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((UInt128)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithUInt128_Works()
        {
            _ = ((UInt128)10).IsNotEqualTo(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((UInt128)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithUInt128_Works()
        {
            _ = ((UInt128)10).LessThan(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithUInt128_Works()
        {
            _ = ((UInt128)10).Modulus(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithUInt128_Works()
        {
            _ = ((UInt128)10).MultipliedWith(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithUInt128_Works()
        {
            _ = ((UInt128)10).PercentOf(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithUInt128_Works()
        {
            _ = ((UInt128)10).Subtract(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithUInt128_Works()
        {
            _ = ((UInt128)10).SubtractPercent(((UInt128)10));
            // Just verify it executes without throwing
        }
    }
}
