using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PrimeService
{
    public class DuplicateEncoder
    {
        //convert string to new string when the new string is ( if char appears once or ) if char is duplicated
        //use StringBuilder
        //iterate through string, compare previous char?

        public string DuplicateEncode(string word)
        {
            StringBuilder newWord = new StringBuilder();

            if (!word.Any() || word.Length == 0)
            {
                return "";
            }

            char previous = word[0];

            foreach (char w in word)
            {
                if (!word.Equals(previous))
                {
                    newWord.Append("(");
                }
                else
                {
                    newWord.Append(")");
                }
            }
            return newWord.ToString();
        }
    }
}