namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.LongCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for long collection methods
    /// </summary>
    public class TypedMathLongCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.DecreaseAllValuesWith(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetValuesHigherThan(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.GetValuesLowerThan(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.IncreaseAllValuesWith(10L);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            long[] array = [1L, 2L, 3L, 4L, 5L];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
