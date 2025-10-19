namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.NintExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for nint extension methods
    /// </summary>
    public class TypedMathNintExtensionTests
    {

        [Fact]
        public void Add_WithNint_Works()
        {
            _ = ((nint)10).Add(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithNint_Works()
        {
            _ = ((nint)10).AddPercent(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithNint_Works()
        {
            _ = ((nint)10).ChooseIfHigher(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithNint_Works()
        {
            _ = ((nint)10).ChooseIfLower(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithNint_Works()
        {
            _ = ((nint)10).DifferenceFrom(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithNint_Works()
        {
            _ = ((nint)10).DividedBy(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithNint_Works()
        {
            _ = ((nint)10).GreaterThan(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithNint_Works()
        {
            _ = ((nint)10).IsEqualTo(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((nint)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithNint_Works()
        {
            _ = ((nint)10).IsNotEqualTo(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((nint)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithNint_Works()
        {
            _ = ((nint)10).LessThan(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithNint_Works()
        {
            _ = ((nint)10).Modulus(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithNint_Works()
        {
            _ = ((nint)10).MultipliedWith(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithNint_Works()
        {
            _ = ((nint)10).PercentOf(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithNint_Works()
        {
            _ = ((nint)10).Subtract(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithNint_Works()
        {
            _ = ((nint)10).SubtractPercent(((nint)10));
            // Just verify it executes without throwing
        }
    }
}
