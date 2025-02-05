using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    public class StringToCamelCaseTest
    {

        StringToCamelCase stringToCamelCase = new StringToCamelCase();

        [Fact]
        public void returnCorrectCamelCaseString()
        {
            String snakeCase = "the_stealth_warrior";
            string result = stringToCamelCase.ConvertToCamelCase(snakeCase);
            Assert.Equal("theStealthWarrior", result);
        }

        [Fact]
        public void returnCorrectCamelCaseStringHyphens()
        {
            String hyphensString = "The-Stealth-Warrior";
            string result = stringToCamelCase.ConvertToCamelCase(hyphensString);
            Assert.Equal("TheStealthWarrior", result);
        }

        [Fact]
        public void returnCorrectCamelCaseStringHyphenUnderscore()
        {
            String hyphensUnderscoreString = "The-Stealth_Warrior";
            string result = stringToCamelCase.ConvertToCamelCase(hyphensUnderscoreString);
            Assert.Equal("TheStealthWarrior", result);
        }
    }
}