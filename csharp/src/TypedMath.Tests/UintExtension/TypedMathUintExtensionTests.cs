namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UintExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for uint extension methods
    /// </summary>
    public class TypedMathUintExtensionTests
    {

        [Fact]
        public void Add_WithUint_Works()
        {
            _ = 10u.Add(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithUint_Works()
        {
            _ = 10u.AddPercent(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithUint_Works()
        {
            _ = 10u.ChooseIfHigher(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithUint_Works()
        {
            _ = 10u.ChooseIfLower(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithUint_Works()
        {
            _ = 10u.DifferenceFrom(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithUint_Works()
        {
            _ = 10u.DividedBy(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithUint_Works()
        {
            _ = 10u.GreaterThan(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithUint_Works()
        {
            _ = 10u.IsEqualTo(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10u.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithUint_Works()
        {
            _ = 10u.IsNotEqualTo(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10u.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithUint_Works()
        {
            _ = 10u.LessThan(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithUint_Works()
        {
            _ = 10u.Modulus(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithUint_Works()
        {
            _ = 10u.MultipliedWith(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithUint_Works()
        {
            _ = 10u.PercentOf(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithUint_Works()
        {
            _ = 10u.Subtract(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithUint_Works()
        {
            _ = 10u.SubtractPercent(10u);
            // Just verify it executes without throwing
        }
    }
}
