namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.Int128Extension;
    using Xunit;

    /// <summary>
    /// Smoke tests for Int128 extension methods
    /// </summary>
    public class TypedMathInt128ExtensionTests
    {

        [Fact]
        public void Add_WithInt128_Works()
        {
            _ = ((Int128)10).Add(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithInt128_Works()
        {
            _ = ((Int128)10).AddPercent(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithInt128_Works()
        {
            _ = ((Int128)10).ChooseIfHigher(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithInt128_Works()
        {
            _ = ((Int128)10).ChooseIfLower(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithInt128_Works()
        {
            _ = ((Int128)10).DifferenceFrom(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithInt128_Works()
        {
            _ = ((Int128)10).DividedBy(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithInt128_Works()
        {
            _ = ((Int128)10).GreaterThan(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithInt128_Works()
        {
            _ = ((Int128)10).IsEqualTo(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((Int128)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithInt128_Works()
        {
            _ = ((Int128)10).IsNotEqualTo(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((Int128)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithInt128_Works()
        {
            _ = ((Int128)10).LessThan(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithInt128_Works()
        {
            _ = ((Int128)10).Modulus(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithInt128_Works()
        {
            _ = ((Int128)10).MultipliedWith(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithInt128_Works()
        {
            _ = ((Int128)10).PercentOf(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithInt128_Works()
        {
            _ = ((Int128)10).Subtract(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithInt128_Works()
        {
            _ = ((Int128)10).SubtractPercent(((Int128)10));
            // Just verify it executes without throwing
        }
    }
}
