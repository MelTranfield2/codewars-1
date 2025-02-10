using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class TwoSum
    {
        TwoSum twoSums = new TwoSum();

        [Fact]
        public void ShouldReturnInd02()
        {
            int[] inputArray = { 1, 2, 3 };
            int inputTarget = 4;
            var result = twoSums.returnSum(inputString, inputTarget);
            Assert.Equal({ 0, 2}, result);
        }

        [Fact]
        public void ShouldReturnInd12()
        {
            int[] inputArray = { 1234, 5678, 9012 };
            int inputTarget = 14690;
            var result = twoSums.returnSum(inputString, inputTarget);
            Assert.Equal({ 1, 2}, result);
        }
    }
}