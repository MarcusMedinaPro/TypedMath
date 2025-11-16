namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.CharCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for char collection methods
    /// </summary>
    public class TypedMathCharCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.DecreaseAllValuesWith(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetValuesHigherThan(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.GetValuesLowerThan(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.IncreaseAllValuesWith(((char)65));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            char[] array = [(char)65, (char)66, (char)67, (char)68, (char)69];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
