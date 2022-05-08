
using System;

namespace QuotaPerMonth_RafaKowalski
{
    public class QuotaPerMonth
    {
        public static double Calculate(int month, double value)
        {
            return Math.Round((value + CalcTax(month, value)) * 1.02, 2);
        }

        private static double CalcTax(int month, double value)
        {
            return value * 0.01 * month;
        }
    }
}
