using System.Collections.Generic;

namespace FibonacciSequence
{
    public static class Fibonacci
    {
        public static List<int> FibonacciSequenceGenerator(int repetions)
        {
            List<int> result = new();

            int x = 1, y = 0, z = 0;

            for (int i = 0; i < repetions; i++)
            {
                z = x + y;
                result.Add(z);
                x = y;
                y = z;
            }

            return result;
        }
    }
}
