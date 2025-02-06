using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class ReverseOrRotateTest
    {

        ReverseOrRotate reverseOrRotate = new ReverseOrRotate();

        [Fact]
        public void ShouldReturn234561876549()
        {
            string inputString = "123456987654";
            int inputSz = 6;
            var result = reverseOrRotate.RevRot(inputString, inputSz);
            Assert.Equal("234561876549", result);
        }

        [Fact]
        public void ShouldReturnEmptyString()
        {
            string inputString = "";
            int inputSz = 8;
            var result = reverseOrRotate.RevRot(inputString, inputSz);
            Assert.Equal("", result);

        }

        [Fact]
        public void ShouldReturn0365065073456944()
        {
            string inputString = "563000655734469485";
            int inputSz = 4;
            var result = reverseOrRotate.RevRot(inputString, inputSz);
            Assert.Equal("0365065073456944", result);

        }
    }
}