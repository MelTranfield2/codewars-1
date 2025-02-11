using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class UniqueInOrderTest
    {

        UniqueInOrder uniqueInOrder = new UniqueInOrder();

        [Fact]
        public void ShouldBeEmptyString()
        {
            string iterable = "";
            var result = uniqueInOrder.returnOrder(iterable.ToCharArray());
            Assert.Equal("", string.Join("", result));
        }
    }
}