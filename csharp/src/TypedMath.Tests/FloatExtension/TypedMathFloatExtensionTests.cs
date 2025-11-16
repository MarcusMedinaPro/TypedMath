namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.FloatExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for float extension methods
    /// </summary>
    public class TypedMathFloatExtensionTests
    {

        [Fact]
        public void Add_WithFloat_Works()
        {
            _ = 10.0f.Add(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithFloat_Works()
        {
            _ = 10.0f.AddPercent(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithFloat_Works()
        {
            _ = 10.0f.ChooseIfHigher(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithFloat_Works()
        {
            _ = 10.0f.ChooseIfLower(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithFloat_Works()
        {
            _ = 10.0f.DifferenceFrom(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithFloat_Works()
        {
            _ = 10.0f.DividedBy(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithFloat_Works()
        {
            _ = 10.0f.GreaterThan(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithFloat_Works()
        {
            _ = 10.0f.IsEqualTo(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10.0f.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithFloat_Works()
        {
            _ = 10.0f.IsNotEqualTo(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10.0f.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithFloat_Works()
        {
            _ = 10.0f.LessThan(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithFloat_Works()
        {
            _ = 10.0f.Modulus(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithFloat_Works()
        {
            _ = 10.0f.MultipliedWith(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithFloat_Works()
        {
            _ = 10.0f.PercentOf(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithFloat_Works()
        {
            _ = 10.0f.Subtract(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithFloat_Works()
        {
            _ = 10.0f.SubtractPercent(10.0f);
            // Just verify it executes without throwing
        }
    }
}
