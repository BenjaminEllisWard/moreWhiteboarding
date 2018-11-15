using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{
    // This solution is from Gabriel Khachatryan: https://github.com/gmkhach/WBE_ValidateBracketsOrder

    class BracketValidatorBetter
    {
        public bool ValidateBrackets(string input)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (var ch in input)
            {
                // adds the opening bracket to the Stack
                if ("({[<".Contains(ch))
                {
                    myStack.Push(ch);
                }
                // compares the closing brackets with with the last opening bracket on Stack and pops it if they match
                else if (")}]>".Contains(ch))
                {
                    // checks for unmatched closing brackets
                    if (myStack.Count() == 0)
                    {
                        return false;
                    }
                    // tries to match the closing bracket with the last character in myStack.
                    else if (myStack.Peek() + 1 == ch || myStack.Peek() + 2 == ch)
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // Checks for unmatched opening brackets
            return myStack.Count() == 0 ? true : false;
        }
    }
}
