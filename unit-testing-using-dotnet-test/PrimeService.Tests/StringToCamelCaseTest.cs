using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class StringToCamelCaseTest
    {
        [Fact]
        public void returnCorrectCamelCaseString()
        {
            StringToCamelCase stringToCamelCase = new StringToCamelCase();
            String snakeCase = "the_stealth_warrior";
            int result = stringToCamelCase.convertToCamelCase(snakeCase);
            Assert.Equal("theStealthWarrior", result);
        }
    }
}