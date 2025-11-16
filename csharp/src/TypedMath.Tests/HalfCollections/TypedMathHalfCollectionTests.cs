namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.HalfCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for Half collection methods
    /// </summary>
    public class TypedMathHalfCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.DecreaseAllValuesWith(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetValuesHigherThan(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.GetValuesLowerThan(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.IncreaseAllValuesWith(((Half)10.0f));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            Half[] array = [(Half)1.0f, (Half)2.0f, (Half)3.0f, (Half)4.0f, (Half)5.0f];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
