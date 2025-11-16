namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.IntCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for int collection methods
    /// </summary>
    public class TypedMathIntCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.DecreaseAllValuesWith(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetValuesHigherThan(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.GetValuesLowerThan(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.IncreaseAllValuesWith(10);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            int[] array = [1, 2, 3, 4, 5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
