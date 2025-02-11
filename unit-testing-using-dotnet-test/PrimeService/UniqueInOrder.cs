using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class UniqueInOrder
    {
        // function unique_in_order which takes as argument a sequence 
        // and returns a list of items without any elements with the same value 
        // next to each other and preserving the original order of elements.

        //loop through the arrays
        //isDistinct - remove duplicate values?
        //but loop from 1 and ignore others

        //array/HashSet as return value, won't allow duplicate values
        //loop through input IEnumerable<T> 
        //or could use LINQ isDistinct to remove duplicates but it would remove original value too

        public IEnumerable<T> returnOrder<T>(IEnumerable<T> iterable)
        {
            HashSet<T> noDuplicates = new HashSet<T>();

            foreach (T i in iterable)
            {
                noDuplicates.Add(i);
            }
            return noDuplicates;
        }
    }
}