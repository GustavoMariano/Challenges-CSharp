using GradingStudents;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class GradingStudentsTests
    {
        private List<int> grade;

        [Test]
        public void CaseOne()
        {
            //Arrange
            grade = new() { 73, 67, 38, 33 };
            List<int> expectedResult = new() { 75, 67, 40, 33 };

            //Action
            List<int> result = Grading.Calculate(grade);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CaseTwo()
        {
            //Arrange
            grade = new() { 55, 62, 48, 78 };
            List<int> expectedResult = new() { 55, 62, 50, 80 };

            //Action
            List<int> result = Grading.Calculate(grade);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CaseThree()
        {
            //Arrange
            grade = new() { 8, 43, 77, 99 };
            List<int> expectedResult = new() { 8, 45, 77, 100 };

            //Action
            List<int> result = Grading.Calculate(grade);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
