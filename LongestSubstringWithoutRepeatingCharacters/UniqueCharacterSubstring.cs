using System.Collections.Generic;
using System;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class UniqueCharacterSubstring
    {
        public static int Solution(string str) 
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int longestSubstring = 0;
            int leftIndex = 0;
            var charSet = new HashSet<char>();

            for (int rightIndex = 0; rightIndex < str.Length; rightIndex++)
            {
                while (charSet.Contains(str[rightIndex]))
                {
                    charSet.Remove(str[leftIndex]);
                    leftIndex++;
                }

                charSet.Add(str[rightIndex]);

                longestSubstring = Math.Max(longestSubstring, rightIndex - leftIndex + 1);
            }

            return longestSubstring;
        }
    }
}
