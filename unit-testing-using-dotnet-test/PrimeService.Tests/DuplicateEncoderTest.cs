using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class DuplicateEncoderTest
    {
        DuplicateEncoder duplicateEncoder = new DuplicateEncoder();

        [Fact]
        public void ShouldBeThreeBrackets()
        {
            string word = "din";
            var result = duplicateEncoder.DuplicateEncode(word);
            Assert.Equal("(((", result);
        }
    }
}