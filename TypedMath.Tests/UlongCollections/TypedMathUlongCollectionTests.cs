namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UlongCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for ulong collection methods
    /// </summary>
    public class TypedMathUlongCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.DecreaseAllValuesWith(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetValuesHigherThan(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.GetValuesLowerThan(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.IncreaseAllValuesWith(10UL);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            ulong[] array = [1UL, 2UL, 3UL, 4UL, 5UL];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
