namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.NuintCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for nuint collection methods
    /// </summary>
    public class TypedMathNuintCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.DecreaseAllValuesWith(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetValuesHigherThan(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.GetValuesLowerThan(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.IncreaseAllValuesWith(((nuint)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            nuint[] array = [(nuint)1, (nuint)2, (nuint)3, (nuint)4, (nuint)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
