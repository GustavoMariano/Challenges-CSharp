
namespace OddOrEvenVerificator
{
    public static class OddOrEven
    {
        public static string Verificator(int number)
        {
            string result = "";

            if (number % 2 == 0)
                result = "Even";
            else
                result = "Odd";

            return $"{number} is {result}";
        }
    }
}
