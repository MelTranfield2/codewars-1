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
        public void ShouldReturnTrue()
        {
            string inputWord = "amazon";
            var result = areWeAlternate.IsAlt(inputWord);
            Assert.Equal(true, result);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            string inputWord = "apple";
            var result = areWeAlternate.IsAlt(inputWord);
            Assert.Equal(false, result);
        }


        [Fact]
        public void ShouldReturnTrueBanana()
        {
            string inputWord = "banana";
            var result = areWeAlternate.IsAlt(inputWord);
            Assert.Equal(true, result);
        }
    }
}