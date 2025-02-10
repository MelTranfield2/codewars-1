using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class TwoSum
    {
        //iterate through array, add items to a new array
        //put items in a dictionary
        //loop through array and try to sum each item in array with the corresponding item in dictionary
        //check if it gives target value, then return the key value pair
        //loop through each item in the array, using LINQ or for loop
        //use zip to match them
        //store target value
        //sum each item in the array, use skip in linq, and then compare the result against target sum
        // return numbers.Select((n, i) => new { Number = n, Index = i })
        // .Zip(numbers.Skip(1).Select((n, i) => new { Number = n, Index = i + 1 }))
        // .Where(pair => pair.First.Number + pair.Second.Number == target)
        // .SelectMany(pair => new[] { pair.First.Index, pair.Second.Index })
        // .ToArray();
        public int[] returnSum(int[] numbers, int target)
        {

            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }

            return result.ToArray();
        }
    }
}