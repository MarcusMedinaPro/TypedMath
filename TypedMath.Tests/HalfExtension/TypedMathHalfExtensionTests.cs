namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.HalfExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for Half extension methods
    /// </summary>
    public class TypedMathHalfExtensionTests
    {

        [Fact]
        public void Add_WithHalf_Works()
        {
            _ = ((Half)10.0f).Add(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithHalf_Works()
        {
            _ = ((Half)10.0f).AddPercent(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithHalf_Works()
        {
            _ = ((Half)10.0f).ChooseIfHigher(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithHalf_Works()
        {
            _ = ((Half)10.0f).ChooseIfLower(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithHalf_Works()
        {
            _ = ((Half)10.0f).DifferenceFrom(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithHalf_Works()
        {
            _ = ((Half)10.0f).DividedBy(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithHalf_Works()
        {
            _ = ((Half)10.0f).GreaterThan(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithHalf_Works()
        {
            _ = ((Half)10.0f).IsEqualTo(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((Half)10.0f).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithHalf_Works()
        {
            _ = ((Half)10.0f).IsNotEqualTo(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((Half)10.0f).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithHalf_Works()
        {
            _ = ((Half)10.0f).LessThan(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithHalf_Works()
        {
            _ = ((Half)10.0f).Modulus(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithHalf_Works()
        {
            _ = ((Half)10.0f).MultipliedWith(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithHalf_Works()
        {
            _ = ((Half)10.0f).PercentOf(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithHalf_Works()
        {
            _ = ((Half)10.0f).Subtract(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithHalf_Works()
        {
            _ = ((Half)10.0f).SubtractPercent(((Half)10.0f));
            // Just verify it executes without throwing
        }
    }
}
