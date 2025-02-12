using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class DataReverse
    {

        // A stream of data is received and needs to be reversed.
        // Each segment is 8 bits long, meaning the order of these segments needs to be reversed, for example:
        //create new empty array
        //loop through input array
        //could use reverse in linq?

        public int[] DataReverser(int[] data)
        {
            return data
            .Chunk(8)
            .Reverse()
            .SelectMany(d => d)
            .ToArray();
        }
    }
}