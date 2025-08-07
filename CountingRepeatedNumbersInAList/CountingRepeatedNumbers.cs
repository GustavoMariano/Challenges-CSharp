using System.Collections.Generic;

namespace CountingRepeatedNumbersInAList
{
    public class CountingRepeatedNumbers
    {
        public static int CountRepeatedNumbers(List<int> numbers)
        {
            int count = 0;

            Dictionary<int, int> numberFrequency = new Dictionary<int, int>();

            foreach (var item in numbers)
            {
                if (numberFrequency.ContainsKey(item))
                {
                    count++;
                    numberFrequency[item]++;
                }
                else
                    numberFrequency[item] = 1;
            }

            return count;
        }
    }
}
