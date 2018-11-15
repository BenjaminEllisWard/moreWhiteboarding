using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{
    // Write a method that takes a string of brackets and validates it.
    // For example: for an input of "([{}])" the method will return true, for an input of "([{]})" it will return false.

    public struct BracketBalance
    {
        public char bracket { get; set; }
        public int balance { get; set; }
    }

    public class BracketValidator
    {
        // As characters are passed through AddToBalance(), opening brackets '('. '{', and '[' will increment a member's balance property while closing
        // brackets will decrement the property. 
        BracketBalance[] b = new BracketBalance[3];

        public bool Validate(string input)
        {
            bool isValid = true;
           
            // adds each character to b, check validity, return if not valid
            foreach (char c in input)
            {
                AddToBalance(c);
                isValid = CheckBalance(b);
                if (isValid == false) return false;
            }

            // checks to see if all bracket pairs close
            foreach (BracketBalance bb in b)
            {
                if (bb.balance != 0)
                {
                    return false;
                }
            }
             
            // If previous checks pass, isValid will be true.
            return isValid;
        }

        private void AddToBalance(char c)
        {
            int val = 0;
            char bracketType = ' ';

            // assigns increment/decrement behavior to val based on whether c is an opening or a closing bracket
            if (c == '(' || c == '{' || c == '[')
            {
                val = 1;
            }
            else val = -1;

            // identifies catagory of bracket and assigns to bracketType
            switch (c)
            {
                case '(':
                case ')':
                    bracketType = '(';
                    break;
                case '{':
                case '}':
                    bracketType = '{';
                    break;
                case '[':
                case ']':
                    bracketType = '[';
                    break;
            }

            // this block executes if there is any member of b that is of the same type and has an unclosed bracket
            if (b.Any(b => b.bracket == bracketType && b.balance > 0))
            {
                // member of same type with balance greater than one is stored to temp so that val can increment/decrement
                // member's balance property. Temp is then assigned to original member's index.
                var temp = b.Single(t => t.bracket == bracketType && t.balance > 0);
                temp.balance += val;
                b[Array.IndexOf(b, b.Single(t => t.bracket == bracketType && t.balance > 0))] = temp;
            }

            // this block executes if there is no member of b of the same bracket type with a positive balance
            else
            {
                // the first member of b with a zero balance is assigned as a new BracketBalance with the type
                // and value as c.
                b[Array.IndexOf(b, b.Where(t => t.balance == 0).First())] = new BracketBalance()
                {
                    bracket = bracketType,
                    balance = val
                };
            }
        }

        public bool CheckBalance(BracketBalance[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                // return false if a member of b has a negative balance (closing bracket without being opened first)
                if (input[i].balance < 0 || input[i + 1].balance < 0)
                    return false;
                // return false if an exterior bracket closes before an interior bracket closes, i.e. "({[}])"
                if (input[i + 1].balance > input[i].balance)
                    return false;
            }

            return true;
        }
    }
}
