using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{
    // Write a method that sorts an array of integers.

    public class IntArraySorter
    {
        public int[] Sort(int[] input)
        {
            while (IsSorted(input) == false)
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    int temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                }
            }

            return input;
        }

        public bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) { return false; }
            }

            return true;
        }
    }
}
