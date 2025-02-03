using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PrimeService.Tests
{
    public class RomanNumeralsEncoderTest
    {

        [Fact]
        public void ShouldReturnRomanNumeralRepresentationFor1000()
        {
            RomanNumeralsEncoder romanNumeralsEncoder = new RomanNumeralsEncoder();
            var result = romanNumeralsEncoder.RomanNumeralsGenerator(1000);
            Assert.Equal("M", result);

        }

        [Fact]
        public void ShouldReturnRomanNumeralRepresentationFor100()
        {
            RomanNumeralsEncoder romanNumeralsEncoder = new RomanNumeralsEncoder();
            var result = romanNumeralsEncoder.RomanNumeralsGenerator(100);
            Assert.Equal("C", result);

        }

    }
}