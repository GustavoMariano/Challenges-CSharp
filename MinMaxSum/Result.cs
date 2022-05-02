using System.Collections.Generic;

namespace MinMaxSum
{
    public class Result
    {
        /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
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
