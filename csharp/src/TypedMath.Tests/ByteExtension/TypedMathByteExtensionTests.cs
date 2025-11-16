namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.ByteExtension;
    using Xunit;

    /// <summary>
    /// Smoke tests for byte extension methods
    /// </summary>
    public class TypedMathByteExtensionTests
    {

        [Fact]
        public void Add_WithByte_Works()
        {
            _ = ((byte)10).Add(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void AddPercent_WithByte_Works()
        {
            _ = ((byte)10).AddPercent(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfHigher_WithByte_Works()
        {
            _ = ((byte)10).ChooseIfHigher(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void ChooseIfLower_WithByte_Works()
        {
            _ = ((byte)10).ChooseIfLower(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DifferenceFrom_WithByte_Works()
        {
            _ = ((byte)10).DifferenceFrom(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void DividedBy_WithByte_Works()
        {
            _ = ((byte)10).DividedBy(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GreaterThan_WithByte_Works()
        {
            _ = ((byte)10).GreaterThan(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsEqualTo_WithByte_Works()
        {
            _ = ((byte)10).IsEqualTo(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNegative_Works()
        {
            _ = ((byte)10).IsNegative();
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsNotEqualTo_WithByte_Works()
        {
            _ = ((byte)10).IsNotEqualTo(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IsPositive_Works()
        {
            _ = ((byte)10).IsPositive();
            // Just verify it executes without throwing
        }

        [Fact]
        public void LessThan_WithByte_Works()
        {
            _ = ((byte)10).LessThan(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Modulus_WithByte_Works()
        {
            _ = ((byte)10).Modulus(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void MultipliedWith_WithByte_Works()
        {
            _ = ((byte)10).MultipliedWith(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void PercentOf_WithByte_Works()
        {
            _ = ((byte)10).PercentOf(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void Subtract_WithByte_Works()
        {
            _ = ((byte)10).Subtract(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void SubtractPercent_WithByte_Works()
        {
            _ = ((byte)10).SubtractPercent(((byte)10));
            // Just verify it executes without throwing
        }
    }
}
