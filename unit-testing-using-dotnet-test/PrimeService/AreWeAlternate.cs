using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class AreWeAlternate
    {
        public bool IsAlt(string word)
        {
            //put aeiou in an array or dict
            //loop through string, or use linq where/select
            //do a check if any of the values , int i + 1 are equal to one of the vowels in the array
            //check the index, only if int i + 1 index is equal to one of the values in the array then it passes
            //check the previous vowel

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            bool currentCharIsVowel = vowels.Contains(word[0]);
            bool isAlternating = true;

            for (int i = 1; i < word.Length; i++)
            {
                currentCharIsVowel = vowels.Contains(word[i]);
                if (currentCharIsVowel == vowels.Contains(word[i - 1]))
                {
                    isAlternating = false;
                }
            }
            return isAlternating;
        }
    }
}