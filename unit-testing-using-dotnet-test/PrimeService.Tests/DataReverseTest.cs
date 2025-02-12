using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class DataReverseTest
    {
        DataReverse dataReverse = new DataReverse();

        [Fact]
        public void ShouldEqualData2()
        {
            int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
            int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
            var result = dataReverse.DataReverser(data1);
            Assert.Equal(data2, result);
        }

        [Fact]
        public void ShouldEqualData4()
        {
            int[] data3 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
            int[] data4 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
            var result = dataReverse.DataReverser(data3);
            Assert.Equal(data4, result);
        }
    }
}