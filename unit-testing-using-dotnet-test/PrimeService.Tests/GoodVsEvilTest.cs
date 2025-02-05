using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class GoodVsEvilTest
    {
        GoodVsEvil goodVsEvil = new GoodVsEvil();

        [Fact]
         public void ShouldReturnGoodOverEvil()
        {
            String countGood = "0 0 0 0 0 10";
            String countEvil = "0 1 1 1 1 0 0";
            var result = goodVsEvil.returnGoodVsEvil(countGood, countEvil);
            Assert.Equal("Battle Result: Good triumphs over Evil", result);
        }
    }
}