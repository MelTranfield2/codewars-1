using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrimeService
{
    public class TransformToPrime
    {

        private static bool IsPrime(int number)
        {
            switch (number)
            {
                case < 2: return false;
                case 2: return true;
                default:
                    if (number % 2 == 0) return false;

                    for (int i = 3; i <= Math.Sqrt(number); i += 2)
                    {
                        if (number % i == 0) return false;
                    }
                    return true;
            }
        }

        public int transformArrayToPrime(int[] numbers)
        {
            //use LINQ to iterate through each element in the array
            //maybe Where() each element is meeting req of being a prime number e.g divisible by itself and 1 only
            //or OfType() - meeting those conditions
            //or All() to check if all elements satisfy those conditions
            //First to ind the first one that matches


            int sum = numbers.Sum();

            return System.Linq.Enumerable.Range(0, 100)
                .First(x => IsPrime(sum + x));
        }
    }
}