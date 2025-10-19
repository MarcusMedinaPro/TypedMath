namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.ShortExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for short extension methods
    /// </summary>
    public class TypedMathShortExtensionTests
    {

        [Fact]
        public void Add_WithShort_Works()
        {
            _ = ((short)10).Add(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithShort_Works()
        {
            _ = ((short)10).AddPercent(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithShort_Works()
        {
            _ = ((short)10).ChooseIfHigher(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithShort_Works()
        {
            _ = ((short)10).ChooseIfLower(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithShort_Works()
        {
            _ = ((short)10).DifferenceFrom(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithShort_Works()
        {
            _ = ((short)10).DividedBy(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithShort_Works()
        {
            _ = ((short)10).GreaterThan(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithShort_Works()
        {
            _ = ((short)10).IsEqualTo(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((short)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithShort_Works()
        {
            _ = ((short)10).IsNotEqualTo(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((short)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithShort_Works()
        {
            _ = ((short)10).LessThan(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithShort_Works()
        {
            _ = ((short)10).Modulus(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithShort_Works()
        {
            _ = ((short)10).MultipliedWith(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithShort_Works()
        {
            _ = ((short)10).PercentOf(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithShort_Works()
        {
            _ = ((short)10).Subtract(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithShort_Works()
        {
            _ = ((short)10).SubtractPercent(((short)10));
            // Just verify it executes without throwing
        }
    }
}
