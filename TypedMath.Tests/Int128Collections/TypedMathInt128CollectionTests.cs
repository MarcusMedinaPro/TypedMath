namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.Int128Collections;
    using Xunit;

    /// <summary>
    /// Smoke tests for Int128 collection methods
    /// </summary>
    public class TypedMathInt128CollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.DecreaseAllValuesWith(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetValuesHigherThan(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.GetValuesLowerThan(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.IncreaseAllValuesWith(((Int128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            Int128[] array = [(Int128)1, (Int128)2, (Int128)3, (Int128)4, (Int128)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
