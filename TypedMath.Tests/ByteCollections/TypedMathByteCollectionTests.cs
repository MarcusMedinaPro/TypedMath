namespace TypedMath.Tests
{
    using MarcusMedinaPro.TypedMath.ByteCollections;
    using Xunit;

    /// <summary>
    /// Smoke tests for byte collection methods
    /// </summary>
    public class TypedMathByteCollectionTests
    {

        [Fact]
        public void DecreaseAllValuesWith_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.DecreaseAllValuesWith(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetAverage_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetAverage();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstHalf_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetFirstHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetFirstValue_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetFirstValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetHighestValue_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetHighestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastHalf_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetLastHalf();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLastValue_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetLastValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetLowestValue_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetLowestValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddle_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetMiddle();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetMiddleValue_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetMiddleValue();
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesHigherThan_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetValuesHigherThan(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void GetValuesLowerThan_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.GetValuesLowerThan(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void IncreaseAllValuesWith_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.IncreaseAllValuesWith(((byte)10));
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateLeft_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.RotateLeft();
            // Just verify it executes without throwing
        }

        [Fact]
        public void RotateRight_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.RotateRight();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SetNewArraySize_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.SetNewArraySize(5);
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayAsc_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.SortArrayAsc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SortArrayDesc_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.SortArrayDesc();
            // Just verify it executes without throwing
        }

        [Fact]
        public void SumAllValues_Works()
        {
            byte[] array = [(byte)1, (byte)2, (byte)3, (byte)4, (byte)5];
            _ = array.SumAllValues();
            // Just verify it executes without throwing
        }
    }
}
