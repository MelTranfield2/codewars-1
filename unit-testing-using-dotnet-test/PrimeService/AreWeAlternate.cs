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