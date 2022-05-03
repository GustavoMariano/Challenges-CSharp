using System.Collections.Generic;

namespace BirthdayCakeCandles
{
    /*
     * You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
     * Example
     * candles = [4, 4, 1, 3]
     * The maximum height candles are 4 units high. There are 2 of them, so return 2.
     */
    public class BdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            candles.Reverse();

            int higherValue = candles[0];
            int count = 0;

            foreach (int candle in candles)
                if (candle == higherValue)
                    count++;

            return count;
        }
    }
}
