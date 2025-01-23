using System;
using System.Linq;

namespace NumberAsArraySum
{
    public class NumberAsArray
    {
        public static int[] Increment(int[] numbers)
        {
            int number = Convert.ToInt32(string.Join("", numbers)) + 1;

            return number.ToString().Select(x => int.Parse(x.ToString())).ToArray();
        }
    }
}
