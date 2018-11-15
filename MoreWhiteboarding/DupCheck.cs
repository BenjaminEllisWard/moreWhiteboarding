using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{
    // Write a method that takes a string and checks if it has duplicate characters.
    // Example: for an input of "asdf" it will return true, for "asds" it will return false.

    public class DupCheck
    {
        public bool Check(string input)
        {
            for (int i = 0; i < input.Length + 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input.ElementAt(i) == input.ElementAt(j))
                        return true;
                }
            }

            return false;
        }
    }
}
