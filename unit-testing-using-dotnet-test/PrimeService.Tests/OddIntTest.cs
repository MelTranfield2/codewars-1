using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class OddIntTest
    {
        [Fact]
        public void ShouldReturn7()
        {
            OddInt oddInt = new OddInt();
            var result = oddInt.FindOddInt([7]);
            Assert.Equal(7, result);
        }

        // [Fact]
        // public void ShouldReturn8()
        // {
        //     RomanNumeralsEncoder romanNumeralsEncoder = new RomanNumeralsEncoder();
        //     var result = romanNumeralsEncoder.RomanNumeralsGenerator(1000);
        //     Assert.Equal("M", result);
        // }
    }
}