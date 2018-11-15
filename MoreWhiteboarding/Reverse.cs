using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{
    // Write a method that takes a string and returns another string that is the reversed version of the input.

    public class Reverse
    {
        public string ReverseString(string input)
        {
            string output = "";

            foreach (char c in input)
            {
                output = c + output;
            }

            return output;
        }
    }
}
