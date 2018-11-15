using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreWhiteboarding
{

    // Write a method that takes three sorted arrays of integers and merges them into one.
    // Example: input: [1, 4, 5], [2, 6, 9], and [3, 7, 8], output: [1, 2, 3, 4, 5, 6, 7, 8, 9]

    public class ArrMerger
    {
        public int[] Merge(int[][] arr)
        {
            List<int> output = new List<int>();
            foreach (int[] a in arr)
            {
                foreach (int i in a)
                {
                    output.Add(i);
                }
            }

            return Sort(output.ToArray());
        }

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
