namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.LongExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for long extension methods
    /// </summary>
    public class TypedMathLongExtensionTests
    {

        [Fact]
        public void Add_WithLong_Works()
        {
            _ = 10L.Add(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithLong_Works()
        {
            _ = 10L.AddPercent(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithLong_Works()
        {
            _ = 10L.ChooseIfHigher(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithLong_Works()
        {
            _ = 10L.ChooseIfLower(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithLong_Works()
        {
            _ = 10L.DifferenceFrom(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithLong_Works()
        {
            _ = 10L.DividedBy(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithLong_Works()
        {
            _ = 10L.GreaterThan(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithLong_Works()
        {
            _ = 10L.IsEqualTo(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10L.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithLong_Works()
        {
            _ = 10L.IsNotEqualTo(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10L.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithLong_Works()
        {
            _ = 10L.LessThan(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithLong_Works()
        {
            _ = 10L.Modulus(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithLong_Works()
        {
            _ = 10L.MultipliedWith(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithLong_Works()
        {
            _ = 10L.PercentOf(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithLong_Works()
        {
            _ = 10L.Subtract(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithLong_Works()
        {
            _ = 10L.SubtractPercent(10L);
            // Just verify it executes without throwing
        }
    }
}
