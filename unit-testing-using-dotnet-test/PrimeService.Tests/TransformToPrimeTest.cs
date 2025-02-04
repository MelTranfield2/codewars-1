using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class TransformToPrimeTest
    {
        [Fact]
        public void returnCorrectNonNegativeInt()
        {
            TransformToPrime transformToPrime = new TransformToPrime();
            int[] numbers = [3, 1, 2];
            int result = transformToPrime.transformArrayToPrime(numbers);
            Assert.Equal(1, result);
        }

    }
}