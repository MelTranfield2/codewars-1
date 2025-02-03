using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class RomanNumeralsEncoder
    {
        public string RomanNumeralsGenerator(int number)
        {
            // Create a function taking a positive integer between 1 and 3999 
            // (both included) as its parameter and returning a string 
            // containing the Roman Numeral representation of that integer.

            // Modern Roman numerals are written by expressing each digit 
            // separately starting with the leftmost digit and skipping any 
            // digit with a value of zero. There cannot be more than 3 identical 
            // symbols in a row.
            // switch statement, if to skip digit with value of zero
            // try/catch, if to prevent 3 identical symbols in a row
            // loop through every value

            //DESCENDING ORDER
            Dictionary<int, string> romanNumerals = new()
            {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [400] = "CD",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [40] = "XL",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };

            if (number < 1 || number > 3999)
            {
                throw new InvalidDataException("Number is invalid");
            }

            string result = "";



            foreach (KeyValuePair<int, string> pair in romanNumerals)
            {
                while (number >= pair.Key)
                {
                    result += pair.Value;
                    number -= pair.Key;
                }

            }
            return result;
        }
    }
}