namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UintCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for uint collection methods
    /// </summary>
    public class TypedMathUintCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.DecreaseAllValuesWith(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetValuesHigherThan(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.GetValuesLowerThan(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.IncreaseAllValuesWith(10u);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            uint[] array = [1u, 2u, 3u, 4u, 5u];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
