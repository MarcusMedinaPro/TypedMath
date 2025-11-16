namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.FloatCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for float collection methods
    /// </summary>
    public class TypedMathFloatCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.DecreaseAllValuesWith(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetValuesHigherThan(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.GetValuesLowerThan(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.IncreaseAllValuesWith(10.0f);
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            float[] array = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
