using System.Collections.Generic;

namespace GrayCode
{
    public class GrayCodeSequence
    {
        public static IList<int> Solution(int n)
        {
            int possibleGrayCodes = (1 << n);
            int[] result = new int[possibleGrayCodes];

            for (int i = 0; i < possibleGrayCodes; i++)
                result[i] = (i ^ (i >> 1));

            return result;
        }
    }
}
