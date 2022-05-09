
using System;

namespace BMICalculator
{
    public static class BMI
    {
        public static string Calculate(double height, double weight)
        {
            double bmi = 0;

            bmi = ((weight / height) / height) * 10000;

            string classificationResult = ClassifyBMI(bmi);

            return $"BMI: {Math.Round(bmi, 1)} - {classificationResult}";
        }

        private static string ClassifyBMI(double bmi)
        {
            string result = "";

            if (bmi < 18.5)
                result = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                result = "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                result = "Overweight";
            else
                result = "Obesity";

            return result;
        }
    }
}
