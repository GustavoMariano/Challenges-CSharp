using System.Collections.Generic;

namespace LongestConsecutiveSequence
{
    public class LongestConsecutiveSeq
    {
        public static int LongestConsecutiveSequenceValidator(List<int> sequence)
        {
            HashSet<int> sequenceHS = new HashSet<int>(sequence);
            int longest = 0;

            foreach (int num in sequenceHS)
            {
                if(sequenceHS.Contains(num - 1))
                    continue;

                int count = 0;
                do
                {
                    count++;
                } while (sequenceHS.Contains(num + count));

                if (count >  longest)
                    longest = count;
            }
            return longest;
        }
    }
}
