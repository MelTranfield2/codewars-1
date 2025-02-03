using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PrimeService
{
    public class WhichAreIn
    {
        public string[] WhichSubstringsAreIn(string[] array1, string[] array2)
        {
            return array1
                .Where(str1 => array2.Any(str2 => str2.Contains(str1)))
                .Distinct()
                .OrderBy(str => str)
                .ToArray();
        }
    }
}