namespace DevelopmentLogicAssessment;

public class CodeSelector
{
    static void Main(string[] args)
    {
        int continueOption;
        do
        {
            Console.Clear();

            Console.WriteLine("Which the code:");
            Console.WriteLine("1 - Dealership");
            Console.WriteLine("2 - Grade Average");
            Console.WriteLine("3 - Recalculate Payment");
            Console.WriteLine("0 - Exit");
            int.TryParse(Console.ReadLine(), out continueOption);

            Console.Clear();

            switch (continueOption)
            {
                case 1: Q1_Dealership.Code(); break;
                case 2: Q2_GradeAverage.Code(); break;
                case 3: Q3_RecalculatePayment.Code(); break;
                default:
                    break;
            }

        } while (continueOption != 0);
    }
}
