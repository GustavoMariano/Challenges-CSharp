using GrayCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class GrayCodeTests
    {
        [Test]
        public void CaseOne()
        {
            //Arrange
            int n = 2;
            List<int> expectedResult = new() { 0, 1, 3, 2 };

            //Action
            IList<int> result = GrayCodeSequence.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CaseTwo()
        {
            //Arrange
            int n = 3;
            List<int> expectedResult = new() { 0, 1, 3, 2, 6, 7, 5, 4 };

            //Action
            IList<int> result = GrayCodeSequence.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CaseThree()
        {
            //Arrange
            int n = 1;
            List<int> expectedResult = new() { 0, 1 };

            //Action
            IList<int> result = GrayCodeSequence.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
