namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.DoubleExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for double extension methods
    /// </summary>
    public class TypedMathDoubleExtensionTests
    {

        [Fact]
        public void Add_WithDouble_Works()
        {
            _ = 10.0.Add(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithDouble_Works()
        {
            _ = 10.0.AddPercent(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithDouble_Works()
        {
            _ = 10.0.ChooseIfHigher(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithDouble_Works()
        {
            _ = 10.0.ChooseIfLower(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithDouble_Works()
        {
            _ = 10.0.DifferenceFrom(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithDouble_Works()
        {
            _ = 10.0.DividedBy(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithDouble_Works()
        {
            _ = 10.0.GreaterThan(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithDouble_Works()
        {
            _ = 10.0.IsEqualTo(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10.0.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithDouble_Works()
        {
            _ = 10.0.IsNotEqualTo(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10.0.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithDouble_Works()
        {
            _ = 10.0.LessThan(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithDouble_Works()
        {
            _ = 10.0.Modulus(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithDouble_Works()
        {
            _ = 10.0.MultipliedWith(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithDouble_Works()
        {
            _ = 10.0.PercentOf(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithDouble_Works()
        {
            _ = 10.0.Subtract(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithDouble_Works()
        {
            _ = 10.0.SubtractPercent(10.0);
            // Just verify it executes without throwing
        }
    }
}
