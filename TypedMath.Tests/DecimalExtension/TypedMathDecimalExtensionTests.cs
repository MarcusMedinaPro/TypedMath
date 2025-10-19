namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.DecimalExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for decimal extension methods
    /// </summary>
    public class TypedMathDecimalExtensionTests
    {

        [Fact]
        public void Add_WithDecimal_Works()
        {
            _ = 10.0m.Add(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithDecimal_Works()
        {
            _ = 10.0m.AddPercent(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithDecimal_Works()
        {
            _ = 10.0m.ChooseIfHigher(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithDecimal_Works()
        {
            _ = 10.0m.ChooseIfLower(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithDecimal_Works()
        {
            _ = 10.0m.DifferenceFrom(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithDecimal_Works()
        {
            _ = 10.0m.DividedBy(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithDecimal_Works()
        {
            _ = 10.0m.GreaterThan(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithDecimal_Works()
        {
            _ = 10.0m.IsEqualTo(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10.0m.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithDecimal_Works()
        {
            _ = 10.0m.IsNotEqualTo(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10.0m.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithDecimal_Works()
        {
            _ = 10.0m.LessThan(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithDecimal_Works()
        {
            _ = 10.0m.Modulus(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithDecimal_Works()
        {
            _ = 10.0m.MultipliedWith(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithDecimal_Works()
        {
            _ = 10.0m.PercentOf(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithDecimal_Works()
        {
            _ = 10.0m.Subtract(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithDecimal_Works()
        {
            _ = 10.0m.SubtractPercent(10.0m);
            // Just verify it executes without throwing
        }
    }
}
