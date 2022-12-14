using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces (this string source)
        {

            ///Inserts spaces before each capital letter in a string
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result += "";
                    }
                    result += letter;
              
                }
            }
            return result;
        }


    }
}
