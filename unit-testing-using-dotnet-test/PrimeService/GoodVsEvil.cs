using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PrimeService
{

    //Each Middle Earth race has a certain worth when battling against others
    //E.g Hobbits: 1
    // Men: 2
    // Elves: 3
    // Dwarves: 3
    // Eagles: 4
    // Wizards: 10
    //Side of evil: Orcs: 1
    // Men: 2
    // Wargs: 2
    // Goblins: 2
    // Uruk Hai: 3
    // Trolls: 5
    // Wizards: 10

    //Factors: weather, location, supplies and valor. If you add up worth of side of good and compare
    //with worth of evil side, side with larger worth wins
    //Count of each of races on the side of good, followed by count of those on the side of evil, determine which side wins

    public class GoodVsEvil
    {
        public string returnGoodVsEvil(string countGood, string countEvil)
        {
            //Basic if comparison on whether countGood or countEvil is a larger amount
            //Inputs are two strings of integers separated by a single space
            //Would need to traverse each string and remove the spaces, then 
            //loop through each int and add them together
            //could convert it into an array of ints
            //could use LINQ

            // IEnumerable<char> stringQueryGood = from ch in countGood
            //                   where Char.IsDigit(ch)
            //                   select ch;

            // string resultString = "";

            int[] goodWorthValues = { 1, 2, 3, 3, 4, 10};
            int[] evilWorthValues = { 1, 2, 2, 2, 3, 5, 10 };

            var goodCounts = countGood.Split(' ').Select(int.Parse).ToArray();
            var evilCounts = countEvil.Split(' ').Select(int.Parse).ToArray();

            int goodResult = goodCounts.Select((count, i) => count * goodWorthValues[i]).Sum();
            int evilResult = evilCounts.Select((count, i) => count * evilWorthValues[i]).Sum();


            if (goodResult > evilResult)
                return "Battle Result: Good triumphs over Evil";
            if (goodResult < evilResult)
                return "Battle Result: Evil eradicates all trace of Good";
            return "Battle Result: No victor on this battle field";

        }

    }
}