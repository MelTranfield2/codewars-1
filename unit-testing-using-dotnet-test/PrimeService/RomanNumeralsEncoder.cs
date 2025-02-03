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

            Dictionary<int, string> romanNumerals = new() 
            {
                [1] = "I",
                [5] = "V",
                [10] = "X",
                [50] = "L",
                [100] = "C",
                [500] = "D",
                [1000] = "M"
            };

            if (number > 1 && number < 3999) {


            } else {

            }

            string result = "";
            
            for (int i = 0; i < number. ; i++)
            {


            }

            return

        }
    }
}