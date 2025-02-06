using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class StringAverageTest
    {
        StringAverage stringAverage = new StringAverage();

        [Fact]
        public void ShouldReturnFour()
        {
            string inputString = "zero nine five two";
            var result = stringAverage.findAverage(inputString);
            Assert.Equal("four", result);
        }

        [Fact]
        public void ShouldReturnNAIfEmpty()
        {
            string inputString = "";
            var result = stringAverage.findAverage(inputString);
            Assert.Equal("N/A", result);
        }
    }
}