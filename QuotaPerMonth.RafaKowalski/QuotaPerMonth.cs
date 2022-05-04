
namespace QuotaPerMonth_RafaKowalski
{
    public class QuotaPerMonth
    {
        public double Calculate(int month, double value)
        {
            return (value + CalcTax(month, value)) * 1.02;
        }

        private static double CalcTax(int month, double value)
        {
            return value * 0.01 * month;
        }
    }
}
