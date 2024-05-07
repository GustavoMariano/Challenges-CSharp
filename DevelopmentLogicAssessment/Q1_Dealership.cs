namespace DevelopmentLogicAssessment;

public class Q1_Dealership
{
    /*
    A car dealership is selling its vehicles at a discount.

    Create an algorithm in Portugol (or your preferred language) that calculates and displays the discount amount and the amount to be paid by the customer for several cars.

    The discount should be calculated according to the vehicle's year.

    • Up to 2000 - 12%
    • Above 2000 - 7%

    The algorithm should ask if you want to continue calculating the discount until the response is "N" (No).

    Inform the total number of cars with a year up to 2000 and the overall total.
    */

    public static void Code()
    {
        int totalCarsUntil2000 = 0;
        int totalGeneral = 0;
        string continueOption;

        do
        {
            Console.WriteLine("Enter the vehicle's year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the vehicle's value:");
            double value = double.Parse(Console.ReadLine());

            double discount;
            if (year <= 2000)
            {
                discount = 0.12;
                totalCarsUntil2000++;
            }
            else
            {
                discount = 0.07;
            }

            double discountValue = value * discount;
            double finalValue = value - discountValue;

            Console.WriteLine($"Discount value: $ {discountValue:N2}");
            Console.WriteLine($"Amount to be paid: $ {finalValue:N2}");

            totalGeneral++;

            Console.WriteLine("Do you want to continue calculating the discount? (Y/N)");
            continueOption = Console.ReadLine().ToUpper();

            if (continueOption != "Y" && continueOption != "N")
            {
                do
                {
                    Console.WriteLine("Invalid option, please try again!");
                    Console.WriteLine("Do you want to continue calculating the discount? (Y/N)");
                    continueOption = Console.ReadLine().ToUpper();
                } while (continueOption != "Y" && continueOption != "N");
            }

            Console.Clear();
        } while (continueOption == "Y");

        Console.WriteLine($"Total cars with year up to 2000: {totalCarsUntil2000}");
        Console.WriteLine($"Total general: {totalGeneral}");
        Console.ReadLine();
    }
}
