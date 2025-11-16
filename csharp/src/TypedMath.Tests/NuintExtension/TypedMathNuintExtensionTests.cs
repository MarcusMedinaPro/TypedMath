namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.NuintExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for nuint extension methods
    /// </summary>
    public class TypedMathNuintExtensionTests
    {

        [Fact]
        public void Add_WithNuint_Works()
        {
            _ = ((nuint)10).Add(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithNuint_Works()
        {
            _ = ((nuint)10).AddPercent(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithNuint_Works()
        {
            _ = ((nuint)10).ChooseIfHigher(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithNuint_Works()
        {
            _ = ((nuint)10).ChooseIfLower(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithNuint_Works()
        {
            _ = ((nuint)10).DifferenceFrom(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithNuint_Works()
        {
            _ = ((nuint)10).DividedBy(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithNuint_Works()
        {
            _ = ((nuint)10).GreaterThan(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithNuint_Works()
        {
            _ = ((nuint)10).IsEqualTo(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((nuint)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithNuint_Works()
        {
            _ = ((nuint)10).IsNotEqualTo(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((nuint)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithNuint_Works()
        {
            _ = ((nuint)10).LessThan(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithNuint_Works()
        {
            _ = ((nuint)10).Modulus(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithNuint_Works()
        {
            _ = ((nuint)10).MultipliedWith(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithNuint_Works()
        {
            _ = ((nuint)10).PercentOf(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithNuint_Works()
        {
            _ = ((nuint)10).Subtract(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithNuint_Works()
        {
            _ = ((nuint)10).SubtractPercent(((nuint)10));
            // Just verify it executes without throwing
        }
    }
}
