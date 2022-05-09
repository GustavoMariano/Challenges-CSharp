using BMICalculator;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class BMICalculatorTests
    {
        private double height = 0; //centimeters
        private double weight = 0; //kilograms

        [Test]
        public void ShouldReturn_22_2_Normal_weight()
        {
            //Arrange
            height = 190;
            weight = 80;
            string expectedResult = "BMI: 22.2 - Normal weight";

            //Action
            string result = BMI.Calculate(height, weight);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_17_3_Underweight()
        {
            //Arrange
            height = 170;
            weight = 50;
            string expectedResult = "BMI: 17.3 - Underweight";

            //Action
            string result = BMI.Calculate(height, weight);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_31_Obesity()
        {
            //Arrange
            height = 175;
            weight = 95;
            string expectedResult = "BMI: 31 - Obesity";

            //Action
            string result = BMI.Calculate(height, weight);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
