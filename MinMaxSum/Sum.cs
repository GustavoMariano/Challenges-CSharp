using System.Collections.Generic;

namespace MinMaxSum
{
    public class Sum
    {
        /*
         * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.
         * 
         * Example:
         * arr= [1,3,5,7,9]
         * The minimum sum is 1+3+5+7 = 16 and the maximum sum is 3+5+7+9 = 24. 
         * 
         * The function prints
         * 16 24
         */

        public static string minMaxSum(List<int> arr)
        {
            long sumOfAllNumbers = 0L;
            long minSum = long.MaxValue;
            long maxSum = 0L;

            for (int i = 0; i < arr.Count; i++)
            {
                sumOfAllNumbers += arr[i];

                if (arr[i] < minSum)
                    minSum = arr[i];

                if (arr[i] > maxSum)
                    maxSum = arr[i];
            }

            return string.Format("{0} {1}", 
                sumOfAllNumbers - maxSum, sumOfAllNumbers - minSum);
        }
    }
}
