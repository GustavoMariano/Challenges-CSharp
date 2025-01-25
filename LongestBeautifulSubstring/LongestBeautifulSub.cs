using System;

namespace LongestBeautifulSubstring
{
    /*
     *A string is considered beautiful if it satisfies the following conditions:
     *
     *Consisting of English vowels only, and each of the 5 English vowels ('a', 'e', 'ï', 'o', 'u') must appear at least once in it.
     *The letters must be sorted in alphabetical order (i.e. all 'a's before 'e's, all 'e's before 'i's, etc.).
     *
     *For example, strings "aeiou" and "aaaaaaeiiiioou" are considered beautiful, but "uaeio", "aeoiu", "aaaeeeooo" and "aeixyzou" are not beautiful.
     *
     *Given a string consisting of English Characters and numbers return the length of the longest beautiful substring in the given string. If no such substring exists, return 0.
     *
     *A substring is a contiguous sequence of characters in a string.
     *
     *Examples
     *Input: "abcdeaeiaaioaaaaeiiiiouuuooaauuaeiu" 
     *Output: 13
     *
     *Input: "aaaaa"
     *Output: 0
     */
    public class LongestBeautifulSub
    {
        public static string Validator(string str)
        {
            string vowels = "aeiou";
            int maxLength = 0;
            int currentLength = 0;
            int uniqueVowelsCount = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (i > 0 && str[i] < str[i - 1])
                {
                    currentLength = 0;
                    uniqueVowelsCount = 0;
                }

                if (vowels.Contains(str[i]))
                {
                    currentLength++;

                    if (i == 0 || str[i] != str[i - 1])
                        uniqueVowelsCount++;
                }
                else
                {
                    currentLength = 0;
                    uniqueVowelsCount = 0;
                }

                if (uniqueVowelsCount == 5)
                    maxLength = Math.Max(maxLength, currentLength);
            }

            return maxLength.ToString();
        }
    }
}
