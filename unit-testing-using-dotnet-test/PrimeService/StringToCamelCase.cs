using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{
    public class StringToCamelCase
    {
        public String ConvertToCamelCase(string startString)
        {
            StringBuilder camelCaseString = new StringBuilder();

            for (int i = 0; i < startString.Length; i++)
            {
                if (startString[i].Equals('-') || startString[i].Equals('_'))
                {
                    camelCaseString.Append(char.ToUpper(startString[i + 1]));
                    i++;
                    continue;
                }
                camelCaseString.Append(startString[i]);
            }
            return camelCaseString.ToString();
        }
    }
}