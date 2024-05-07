namespace DevelopmentLogicAssessment;

public class Q2_GradeAverage
{
    /*
    Write an algorithm in Portugol(or your preferred language) that reads an undetermined number of values.

    Each set consists of the student's number (code) and their three grades.

    Calculate for each student the weighted average with respective weights of 4 for the HIGHEST grade and 3 for the other two grades.

    Write the student's number (code), their 3 grades, the calculated average, and a message (PASSED) if the average is ≥ 6 and (FAILED) if the average is < 6.

    End the reading of values ​​as soon as 0 is entered in the student's code.
    */

    public static void Code()
    {
        int studentCode;
        double[] grades;

        do
        {
            grades = new double[3];
            Console.WriteLine("Enter the student's code (0 to finish):");
            studentCode = int.Parse(Console.ReadLine());

            if (studentCode == 0)
                break;

            Console.WriteLine("Enter the first grade:");
            grades[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second grade:");
            grades[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third grade:");
            grades[2] = double.Parse(Console.ReadLine());

            double average = CalculateWeightedAverage(grades);
            string status = average >= 6 ? "PASSED" : "FAILED";

            Console.WriteLine($"Student: {studentCode}");
            Console.WriteLine($"Grades: {grades[0]}, {grades[1]}, {grades[2]}");
            Console.WriteLine($"Average: {average:N2} - {status}");
            Console.WriteLine();
            Console.ReadLine();
        } while (studentCode != 0);
    }
    static double CalculateWeightedAverage(double[] grades)
    {
        double highestGrade = grades.Max();
        double average = (4 * highestGrade + 3 * (grades.Sum() - highestGrade)) / 10;
        return average;
    }
}
