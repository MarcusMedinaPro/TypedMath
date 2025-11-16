namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UshortCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for ushort collection methods
    /// </summary>
    public class TypedMathUshortCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.DecreaseAllValuesWith(((ushort)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetValuesHigherThan(((ushort)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.GetValuesLowerThan(((ushort)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.IncreaseAllValuesWith(((ushort)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            ushort[] array = [(ushort)1, (ushort)2, (ushort)3, (ushort)4, (ushort)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
