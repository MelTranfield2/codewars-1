using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class CountingDuplicates
    {
        // Write a function that will return the count of distinct case-insensitive
        // alphabetic characters and numeric digits that occur more than once in the input string.
        // The input string can be assumed to contain only alphabets (both uppercase and 
        // lowercase) and numeric digits.
        public int getDuplicates(string inputString)
        {
            //iterate through, do contains check in LINQ or Any
            var chars = inputString.ToLower();
            var nonDuplicates = chars.Distinct();

            var duplicateGroups = chars.GroupBy(ch => ch)
            .Where(gr => gr.Count() > 1);
            return duplicateGroups.Count();
        }
    }
}