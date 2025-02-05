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
        public void ShouldReturnStringRotatedToLeft()
        {
            string inputString = "123456987654";
            int inputSz = 6;
            var result = reverseOrRotate.RevRot(inputString, inputSz);
            Assert.Equal("234561876549", result);

        }
    }
}