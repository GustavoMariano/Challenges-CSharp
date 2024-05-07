namespace DevelopmentLogicAssessment;

public class Q3_RecalculatePayment
{
    /*
    Write an algorithm in Portugol (or the language of your choice) to recalculate Boleto payments.
    It should read the original due date, the new due date (payment date), and the boleto amount, and present the recalculated boleto amount and the total interest for the period.
    
    Consider the following:
    * Interest rate per day: R$ 0.03 and Fine amount: R$ 2.00 (fixed values)
    * Dates can be entered as date data type
    * Dates can be compared using Relational Operators, and Arithmetic Operators can be used
    * Ex.: date < -date + 1 // Adds one day to the date
    * Ex.: numDays < -endDate - startDate // Returns the number of days between two dates
    * There is a function VerifyHoliday(date: date): boolean
    * This function returns TRUE when a date is a holiday and FALSE otherwise
    * There is a function VerifyWeekend(date: date): boolean
    * This function returns TRUE when a date is a weekend and FALSE otherwise
    
    The recalculation rules to be followed are:
    
    1. If the due date falls on a weekend or holiday, and the payment date is the consecutive business day, no interest or fine should be charged. Ex.: Due on Saturday and payment on Monday;
    2. If the due date falls on a weekend or holiday, and the payment is made after the consecutive business day, interest for the entire period should be charged. Ex.: Due on Saturday and payment on Tuesday: three days of interest + fine.
    3. If the due date falls on a holiday, and the payment is made on the next day (business day), no interest or fine should be charged. Ex.: Due on May 1st, 2023, and payment on May 2nd, 2023;
    4. If the due date falls on a holiday preceding a weekend, and the payment is made on Monday (consecutive business day), no interest or fine should be charged. Ex.: Due on April 21st, 2023, and payment on April 24th, 2023;
    5. If the due date falls on a holiday, and the payment is made two consecutive business days after the holiday, interest for the entire period should be charged. Ex.: Due on April 7th, 2023, and payment on April 11th, 2023: four days of interest + fine;
    6. If the due date falls on a business day, and the payment is made on the same day, no interest or fine should be charged;
    7. If the payment date is before the due date, no interest or fine should be charged;
    8. If the due date falls on a business day, and the payment is made on the consecutive business day, interest and fine for only one period should be charged. Ex.: Due on May 8th, 2023, payment on May 9th, 2023: one day of interest + fine.
    */

    public static void Code()
    {
        double interestPerDayValue = 0.03;
        double fineValue = 2.00;

        Console.Write("Enter the original due date (DD/MM/YYYY): ");
        DateTime originalDueDate = ConvertDate(Console.ReadLine());

        Console.Write("Enter the invoice amount: R$ ");
        double invoiceAmount = double.Parse(Console.ReadLine());

        Console.Write("Enter the new due date (payment date) (DD/MM/YYYY): ");
        DateTime newDueDate = ConvertDate(Console.ReadLine());

        TimeSpan dateDifference = newDueDate - originalDueDate;
        int daysLate = (int)dateDifference.TotalDays;

        if (daysLate < 0)
            Console.WriteLine("Payment date cannot be before the due date.");
        else
        {
            bool dueDateWeekday = originalDueDate.DayOfWeek != DayOfWeek.Saturday && originalDueDate.DayOfWeek != DayOfWeek.Sunday;
            bool paymentWeekday = newDueDate.DayOfWeek != DayOfWeek.Saturday && newDueDate.DayOfWeek != DayOfWeek.Sunday;
            bool dueDateHoliday = CheckHoliday(originalDueDate);
            bool dueDateWeekend = originalDueDate.DayOfWeek == DayOfWeek.Saturday || originalDueDate.DayOfWeek == DayOfWeek.Sunday;

            if (dueDateWeekend || dueDateHoliday)
            {
                if (paymentWeekday)
                {
                    Console.WriteLine("Recalculated invoice amount: R$ " + invoiceAmount);
                    Console.WriteLine("Total interest amount for the period: R$ 0.00");
                }
                else
                {
                    double interestValue = (daysLate + 1) * interestPerDayValue;
                    double totalValue = invoiceAmount + interestValue + fineValue;
                    Console.WriteLine("Recalculated invoice amount: R$ " + totalValue);
                    Console.WriteLine("Total interest amount for the period: R$ " + interestValue.ToString("0.00"));
                }
            }
            else if (dueDateHoliday && CheckWeekend(newDueDate.AddDays(1)))
            {
                Console.WriteLine("Recalculated invoice amount: R$ " + invoiceAmount);
                Console.WriteLine("Total interest amount for the period: R$ 0.00");
            }
            else if (dueDateHoliday && paymentWeekday)
            {
                Console.WriteLine("Recalculated invoice amount: R$ " + invoiceAmount);
                Console.WriteLine("Total interest amount for the period: R$ 0.00");
            }
            else if (dueDateHoliday && CheckHoliday(newDueDate.AddDays(1)))
            {
                double interestValue = (daysLate + 2) * interestPerDayValue;
                double totalValue = invoiceAmount + interestValue + fineValue;
                Console.WriteLine("Recalculated invoice amount: R$ " + totalValue);
                Console.WriteLine("Total interest amount for the period: R$ " + interestValue.ToString("0.00"));
            }
            else if (dueDateWeekday && paymentWeekday && daysLate == 0)
            {
                Console.WriteLine("Recalculated invoice amount: R$ " + invoiceAmount);
                Console.WriteLine("Total interest amount for the period: R$ 0.00");
            }
            else if (paymentWeekday && daysLate == 1)
            {
                if (dueDateWeekday)
                {
                    double interestValue = interestPerDayValue;
                    double totalValue = invoiceAmount + interestValue + fineValue;
                    Console.WriteLine("Recalculated invoice amount: R$ " + totalValue);
                    Console.WriteLine("Total interest amount for the period: R$ " + interestValue.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Recalculated invoice amount: R$ " + invoiceAmount);
                    Console.WriteLine("Total interest amount for the period: R$ 0.00");
                }
            }
            else
            {
                double interestValue = daysLate * interestPerDayValue;
                double totalValue = invoiceAmount + interestValue + fineValue;
                Console.WriteLine("Recalculated invoice amount: R$ " + totalValue);
                Console.WriteLine("Total interest amount for the period: R$ " + interestValue.ToString("0.00"));
            }
        }
        Console.ReadLine();
    }

    static bool CheckHoliday(DateTime date)
    {
        if (date == new DateTime(2023, 01, 01))
            return true;
        else if (date == new DateTime(2023, 02, 20))
            return true;
        else if (date == new DateTime(2023, 02, 21))
            return true;
        else if (date == new DateTime(2023, 04, 07))
            return true;
        else if (date == new DateTime(2023, 04, 21))
            return true;
        else if (date == new DateTime(2023, 05, 01))
            return true;
        else if (date == new DateTime(2023, 06, 08))
            return true;
        else if (date == new DateTime(2023, 09, 07))
            return true;
        else if (date == new DateTime(2023, 10, 12))
            return true;
        else if (date == new DateTime(2023, 11, 02))
            return true;
        else if (date == new DateTime(2023, 11, 15))
            return true;
        else if (date == new DateTime(2023, 12, 25))
            return true;

        return false;
    }

    static bool CheckWeekend(DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }

    static DateTime ConvertDate(string dateString)
    {
        return new DateTime(
            int.Parse(dateString.Split('/')[2]),
            int.Parse(dateString.Split('/')[1]),
            int.Parse(dateString.Split('/')[0])
            );
    }
}
