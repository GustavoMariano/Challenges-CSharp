using System;

namespace ManualDateValidation
{
    public class DateValidation
    {
        public void IntToDate(int day, int month, int year)
        {
            DateTime dataConvertida;

            if (year > 0 && year <= 3000) //Fictitious limit
            {
                if (Have31Days(month))
                {
                    if (day < 1 || day > 31)
                        throw new ArgumentException("Day informed is invalid!!");
                    else
                        dataConvertida = new DateTime(year, month, day);
                }
                else if (Have30Days(month))
                {
                    if (day < 1 || day > 30)
                        throw new ArgumentException("Day informed is invalid!!");
                    else
                        dataConvertida = new DateTime(year, month, day);
                }
                else if (IsFebruary(month))
                {
                    if (!DateTime.IsLeapYear(year))
                    {
                        if (day < 1 || day > 28)
                            throw new ArgumentException("The year informed is not a leap year, so February has 28 days!!");
                        else
                            dataConvertida = new DateTime(year, month, day);
                    }
                    else
                    {
                        if (day < 1 || day > 29)
                            throw new ArgumentException("The year informed is a leap year, however the day informed is not valid!!");
                        else
                            dataConvertida = new DateTime(year, month, day);
                    }
                }
                else
                    throw new ArgumentException("The month entered is invalid!!");
            }
            else
                throw new ArgumentException("Entered year is out of validation scope(0001 ~3000)");
        }        

        public void StringToDate(string day, string month, string year)
        {
            int intDay;
            int intMonth; //= Convert.ToInt32(month);
            int intYear; //= Convert.ToInt32(year);

            if (!Int32.TryParse(day, out intDay))
                throw new ArgumentException("The day entered is invalid!!");

            if (!Int32.TryParse(month, out intMonth))
                throw new ArgumentException("The month entered is invalid!!");

            if (!Int32.TryParse(year, out intYear))
                throw new ArgumentException("The year entered is invalid!!");

            //DateTime dataConvertida;

            IntToDate(intDay, intMonth, intYear);
        }

        #region If conditions
        private static bool IsFebruary(int month)
        {
            return month == 2;
        }
        private static bool Have30Days(int month)
        {
            return month == 4 || month == 6 || month == 9 || month == 11;
        }
        private static bool Have31Days(int month)
        {
            return month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12;
        }
        #endregion
    }
}
