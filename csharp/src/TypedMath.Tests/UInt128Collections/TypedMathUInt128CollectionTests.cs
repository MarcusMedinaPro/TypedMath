namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.UInt128Collections;
    using Xunit;

    /// <summary>
    /// Smoke tests for UInt128 collection methods
    /// </summary>
    public class TypedMathUInt128CollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.DecreaseAllValuesWith(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetValuesHigherThan(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.GetValuesLowerThan(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.IncreaseAllValuesWith(((UInt128)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            UInt128[] array = [(UInt128)1, (UInt128)2, (UInt128)3, (UInt128)4, (UInt128)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
