using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentElements
{
    public class TopFrequentElements
    {
        public static int Validator(List<int> elements)
        {
            if (elements.Count == 0)
                return 0;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (int element in elements)
            {
                if (keyValuePairs.ContainsKey(element))
                    keyValuePairs[element]++;

                if (!keyValuePairs.ContainsKey(element))
                    keyValuePairs.Add(element, 1);
            }

            return keyValuePairs.OrderByDescending(kv => kv.Value).First().Key;
        }
    }
}
