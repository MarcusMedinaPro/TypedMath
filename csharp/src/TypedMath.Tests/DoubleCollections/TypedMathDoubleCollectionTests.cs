namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.DoubleCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for double collection methods
    /// </summary>
    public class TypedMathDoubleCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.DecreaseAllValuesWith(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetValuesHigherThan(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.GetValuesLowerThan(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.IncreaseAllValuesWith(10.0);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
