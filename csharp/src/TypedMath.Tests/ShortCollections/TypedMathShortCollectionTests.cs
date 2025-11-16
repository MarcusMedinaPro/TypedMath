namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.ShortCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for short collection methods
    /// </summary>
    public class TypedMathShortCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.DecreaseAllValuesWith(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetValuesHigherThan(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.GetValuesLowerThan(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.IncreaseAllValuesWith(((short)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            short[] array = [(short)1, (short)2, (short)3, (short)4, (short)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
