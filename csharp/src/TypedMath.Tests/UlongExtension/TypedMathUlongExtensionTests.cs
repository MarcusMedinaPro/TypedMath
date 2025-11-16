namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UlongExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for ulong extension methods
    /// </summary>
    public class TypedMathUlongExtensionTests
    {

        [Fact]
        public void Add_WithUlong_Works()
        {
            _ = 10UL.Add(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithUlong_Works()
        {
            _ = 10UL.AddPercent(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithUlong_Works()
        {
            _ = 10UL.ChooseIfHigher(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithUlong_Works()
        {
            _ = 10UL.ChooseIfLower(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithUlong_Works()
        {
            _ = 10UL.DifferenceFrom(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithUlong_Works()
        {
            _ = 10UL.DividedBy(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithUlong_Works()
        {
            _ = 10UL.GreaterThan(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithUlong_Works()
        {
            _ = 10UL.IsEqualTo(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10UL.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithUlong_Works()
        {
            _ = 10UL.IsNotEqualTo(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10UL.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithUlong_Works()
        {
            _ = 10UL.LessThan(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithUlong_Works()
        {
            _ = 10UL.Modulus(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithUlong_Works()
        {
            _ = 10UL.MultipliedWith(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithUlong_Works()
        {
            _ = 10UL.PercentOf(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithUlong_Works()
        {
            _ = 10UL.Subtract(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithUlong_Works()
        {
            _ = 10UL.SubtractPercent(10UL);
            // Just verify it executes without throwing
        }
    }
}
