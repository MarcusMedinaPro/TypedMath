namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.DecimalCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for decimal collection methods
    /// </summary>
    public class TypedMathDecimalCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.DecreaseAllValuesWith(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetValuesHigherThan(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.GetValuesLowerThan(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.IncreaseAllValuesWith(10.0m);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            decimal[] array = [1.0m, 2.0m, 3.0m, 4.0m, 5.0m];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
