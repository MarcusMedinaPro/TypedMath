namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.NintCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for nint collection methods
    /// </summary>
    public class TypedMathNintCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.DecreaseAllValuesWith(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetValuesHigherThan(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.GetValuesLowerThan(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.IncreaseAllValuesWith(((nint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            nint[] array = [(nint)1, (nint)2, (nint)3, (nint)4, (nint)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
