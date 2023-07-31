using AWS_Test_HackerRank;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class AWS_Test_HackerRankTests
    {
        private int expectedResult = 1;

        [Test]
        public void ShouldReturn_One_OneSolar()
        {
            //Arrange
            expectedResult = 1;
            string input = "1";

            //Action
            int result = SolarPoweredBulbs_AWS_Exam.MaximizeSolarPoweredBulbs(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_One_ZeroSolar()
        {
            //Arrange
            expectedResult = 1;
            string input = "0";

            //Action
            int result = SolarPoweredBulbs_AWS_Exam.MaximizeSolarPoweredBulbs(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_Six_ThreeSolar()
        {
            //Arrange
            expectedResult = 6;
            string input = "00101000100";

            //Action
            int result = SolarPoweredBulbs_AWS_Exam.MaximizeSolarPoweredBulbs(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_TwentySix_TwentySolar()
        {
            //Arrange
            expectedResult = 26;
            string input = "0010100010001010100101000100100100100101010101010001100";

            //Action
            int result = SolarPoweredBulbs_AWS_Exam.MaximizeSolarPoweredBulbs(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_Six_ZeroSolar()
        {
            //Arrange
            expectedResult = 6;
            string input = "00000000000";

            //Action
            int result = SolarPoweredBulbs_AWS_Exam.MaximizeSolarPoweredBulbs(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}