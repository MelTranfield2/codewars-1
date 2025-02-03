using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class WhichAreInTest
    {

        [Fact]
        public void ShouldReturnCorrectArray()
        {
            WhichAreIn whichAreIn = new WhichAreIn();
            string[] testArray1 = ["arp", "live", "strong"];
            string[] testArray2 = ["lively", "alive", "harp", "sharp", "armstrong"];
            var result = whichAreIn.WhichSubstringsAreIn(testArray1, testArray2);
            Assert.Equal(["arp", "live", "strong"], result);
        }
    }
}