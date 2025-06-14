using NUnit.Framework;
using SumOfTwoArrays;

namespace Challenges.Tests
{
    [TestFixture]
    public class SumOfTwoArraysTests
    {
        [Test]
        public void ShouldReturn199()
        {
            //Arrange
            int[] arrayNumber1 = { 1, 0, 1};
            int[] arrayNumber2 = { 9, 8};
            int[] expectedResult = { 1, 9, 9};

            //Action
            int[] result = SumTwoArrays.Sum(arrayNumber1, arrayNumber2);
            
            //Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void ShouldReturn52314()
        {
            //Arrange
            int[] arrayNumber1 = { 2, 6, 0, 0, 0 };
            int[] arrayNumber2 = { 2, 6, 3, 1, 4 };

            //Action
            int[] expectedResult = { 5, 2, 3, 1, 4 };
            int[] result = SumTwoArrays.Sum(arrayNumber1, arrayNumber2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
