using System.Collections.Generic;
using System.Linq;

namespace ReverseOnlyLetters
{
    public static class ReverseOnlyLetter
    {
        public static string Reverse(string value)
        {
            List<char> stringList = value.ToList();

            if (stringList.Count == 0)
                return "";

            int left = 0;
            int right = stringList.Count - 1;

            while(left < right)
            {
                if (!char.IsLetter(stringList[left]))
                    left++;
                else if (!char.IsLetter(stringList[right]))
                    right--;
                else
                {
                    char aux = stringList[right];
                    stringList[right] = stringList[left];
                    stringList[left] = aux;

                    left++;
                    right--;
                }
            }

            return string.Join("", stringList);
        }
    }
}
