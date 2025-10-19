namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.SbyteCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for sbyte collection methods
    /// </summary>
    public class TypedMathSbyteCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.DecreaseAllValuesWith(((sbyte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetValuesHigherThan(((sbyte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.GetValuesLowerThan(((sbyte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.IncreaseAllValuesWith(((sbyte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            sbyte[] array = [(sbyte)1, (sbyte)2, (sbyte)3, (sbyte)4, (sbyte)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
