using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PrimeService
{
    public class OddInt
    {
        public int FindOddInt(int[] numberArray)
        {
            Dictionary<int, int> NumbersCount = new() { };

            int result = 0;

            foreach (int number in numberArray)
            {
                if (NumbersCount.ContainsKey(number))
                {
                    NumbersCount[number]++;
                }
                else
                {
                    NumbersCount.Add(number, 1);
                }
            }

            foreach (KeyValuePair<int, int> pair in NumbersCount)
            {
                if (pair.Value % 2 != 0)
                {
                    result = pair.Key;
                }
            }
            return result;
        }
    }
}