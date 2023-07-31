using System;
using System.Collections.Generic;

namespace AWS_Test_HackerRank
{
    public class SolarPoweredBulbs_AWS_Exam
    {

        /*
         * Complete the 'maximizeSolarPoweredBulbs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING bulbs as parameter.
         */

        public static int MaximizeSolarPoweredBulbs(string bulbs)
        {
            if (string.IsNullOrEmpty(bulbs))
                return 0;

            if (bulbs.Length == 1)
                return 1;

            int total = 0;
            int countZero = 0;
            int anterior = 0;
            List<int> bulbsList = new List<int>();

            foreach (char number in bulbs)
                bulbsList.Add((int)Char.GetNumericValue(number));

            for (int i = 0; i < bulbsList.Count; i++)
            {
                anterior = i - 1;

                if (i == 0 && bulbsList[0] == 0 && bulbsList[1] == 0)
                {
                    countZero = 0;
                    bulbsList[i] = 1;
                }

                if (bulbsList[i] == 0)
                {
                    countZero++;

                    if (countZero == 3)
                    {
                        countZero = 1;
                        bulbsList[anterior] = 1;
                    }
                    if (bulbsList[i] == 0 && i == bulbsList.Count - 1 && bulbsList[anterior] == 0 && countZero == 2)
                        bulbsList[i] = 1;
                }
                else if (bulbsList[i] == 1)
                        countZero = 0;
            }

            foreach (int number in bulbsList)
                total += number;

            return total;
        }
    }
}