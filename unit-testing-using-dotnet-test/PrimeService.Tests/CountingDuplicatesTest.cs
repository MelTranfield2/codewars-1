using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class CountingDuplicatesTest
    {
        public CountingDuplicates countingDuplicates = new CountingDuplicates();

        [Fact]
        public void ShouldReturn0EmptyString()
        {
            string inputString = "";
            var result = countingDuplicates.getDuplicates(inputString);
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturn0()
        {
            string inputString = "abcde";
            var result = countingDuplicates.getDuplicates(inputString);
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturn2()
        {
            string inputString = "aabbcde";
            var result = countingDuplicates.getDuplicates(inputString);
            Assert.Equal(2, result);
        }

        [Fact]
        public void ShouldIgnoreCase()
        {
            string inputString = "aabBcde";
            var result = countingDuplicates.getDuplicates(inputString);
            Assert.Equal(2, result);
        }
    }
}