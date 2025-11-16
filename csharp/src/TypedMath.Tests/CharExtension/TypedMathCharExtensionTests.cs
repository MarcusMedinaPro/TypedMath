namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.CharExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for char extension methods
    /// </summary>
    public class TypedMathCharExtensionTests
    {

        [Fact]
        public void Add_WithChar_Works()
        {
            _ = ((char)65).Add(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithChar_Works()
        {
            _ = ((char)65).AddPercent(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithChar_Works()
        {
            _ = ((char)65).ChooseIfHigher(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithChar_Works()
        {
            _ = ((char)65).ChooseIfLower(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithChar_Works()
        {
            _ = ((char)65).DifferenceFrom(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithChar_Works()
        {
            _ = ((char)65).DividedBy(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithChar_Works()
        {
            _ = ((char)65).GreaterThan(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithChar_Works()
        {
            _ = ((char)65).IsEqualTo(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((char)65).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithChar_Works()
        {
            _ = ((char)65).IsNotEqualTo(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((char)65).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithChar_Works()
        {
            _ = ((char)65).LessThan(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithChar_Works()
        {
            _ = ((char)65).Modulus(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithChar_Works()
        {
            _ = ((char)65).MultipliedWith(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithChar_Works()
        {
            _ = ((char)65).PercentOf(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithChar_Works()
        {
            _ = ((char)65).Subtract(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithChar_Works()
        {
            _ = ((char)65).SubtractPercent(((char)65));
            // Just verify it executes without throwing
        }
    }
}
