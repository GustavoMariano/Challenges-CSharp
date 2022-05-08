
namespace MinimalMovesToSolveTowerOfHanoi
{
    public class TowerOfHanoi
    {
        public static int CalculateMinimalMoves(int rings)
        {
            int sum = 0;

            for (int i = 0; i < rings; i++)
                sum += sum + 1;

            return sum;
        }
    }
}
