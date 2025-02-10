using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class AreWeAlternateTest
    {

        AreWeAlternate areWeAlternate = new AreWeAlternate();

        [Fact]
        public void ShouldReturnInd02()
        {
            string inputWord = "amazon";
            var result = areWeAlternate.IsAlt(inputWord);
            Assert.Equal(true, result);
        }
    }
}