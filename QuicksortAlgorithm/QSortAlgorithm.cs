using System.Linq;

namespace QuicksortAlgorithm
{
    public class QSortAlgorithm
    {
        public static int[] Quicksort(int[] nums)
        {
            if (nums.Length < 2)
                return nums;
            else
            {
                int pivot = nums[0];
                int[] minors = nums.Skip(1).Where(i => i <= pivot).ToArray();
                int[] majors = nums.Skip(1).Where(i => i > pivot).ToArray();

                return Quicksort(minors).Concat(new int[] { pivot }).Concat(Quicksort(majors)).ToArray();
            }
        }
    }
}
