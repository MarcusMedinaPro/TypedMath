namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.IntExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for int extension methods
    /// </summary>
    public class TypedMathIntExtensionTests
    {

        [Fact]
        public void Add_WithInt_Works()
        {
            _ = 10.Add(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithInt_Works()
        {
            _ = 10.AddPercent(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithInt_Works()
        {
            _ = 10.ChooseIfHigher(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithInt_Works()
        {
            _ = 10.ChooseIfLower(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithInt_Works()
        {
            _ = 10.DifferenceFrom(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithInt_Works()
        {
            _ = 10.DividedBy(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithInt_Works()
        {
            _ = 10.GreaterThan(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithInt_Works()
        {
            _ = 10.IsEqualTo(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = 10.IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithInt_Works()
        {
            _ = 10.IsNotEqualTo(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = 10.IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithInt_Works()
        {
            _ = 10.LessThan(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithInt_Works()
        {
            _ = 10.Modulus(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithInt_Works()
        {
            _ = 10.MultipliedWith(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithInt_Works()
        {
            _ = 10.PercentOf(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithInt_Works()
        {
            _ = 10.Subtract(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithInt_Works()
        {
            _ = 10.SubtractPercent(10);
            // Just verify it executes without throwing
        }
    }
}
