using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{

    //     You are given a string of numbers between 0-9. Find the average of these numbers 
    //and return it as a floored whole number (ie: no decimal places) written out as a string. Eg:

    // "zero nine five two" -> "four"

    // If the string is empty or includes a number greater than 9, return "n/a"

    // input.Split()
    // .Where(word)

    // input.Split()
    // .Select(ch => ch).Where(ch.IsDigit)
    // .Contains(ch >)

    //map all numbers to the int value, then total that using LINQ Sum, divided by the number of strings in input string
    //then map the result to text


    public class StringAverage
    {
        public string findAverage(string input)
        {
            Dictionary<string, int> stringIntDict = new()
            {
                ["zero"] = 0,
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5,
                ["six"] = 6,
                ["seven"] = 7,
                ["eight"] = 8,
                ["nine"] = 9
            };

            if (string.IsNullOrEmpty(input))
            {
                return "N/A";
            }

            var words = input.Split();
            if (words.Any(word => !stringIntDict.ContainsKey(word)))
            {
                return "N/A";
            }

            var stringToInt = input.Split()
            .Where(word => stringIntDict.TryGetValue(word, out int _))
            .Select(word =>
            {
                stringIntDict.TryGetValue(word, out int value);
                return value;
            })
            .ToList();

            if (stringToInt.Count == 0 || stringToInt.Any(value => value > 9))
            {
                return "N/A";
            }

            int average = stringToInt.Sum() / stringToInt.Count();

            var reversedStringIntDict = stringIntDict.ToDictionary(number => number.Value, word => word.Key);

            return reversedStringIntDict[average];
        }
    }
}