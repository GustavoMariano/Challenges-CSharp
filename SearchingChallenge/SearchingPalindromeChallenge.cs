using System;

namespace SearchingChallenge
{
    public class SearchingPalindromeChallenge
    {
        public static string Solution(string str)
        {
            if (str.Length < 3)
                return "none";

            string result = "";
            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 3; j <= n; j++)
                {
                    string sub = str.Substring(i, j - i);
                    bool isPalindrome = true;

                    for (int k = 0; k < sub.Length / 2; k++)
                        if (sub[k] != sub[sub.Length - 1 - k])
                        {
                            isPalindrome = false;
                            break;
                        }

                    if (isPalindrome && sub.Length > result.Length)
                        result = sub;
                }
            }

            return result == "" ? "none" : result;
        }
    }
}
