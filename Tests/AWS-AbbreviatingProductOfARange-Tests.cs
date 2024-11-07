using AWS_Test;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class AWS_AbbreviatingProductOfARange_Tests
    {
        private string expectedResult = "";

        [Test]
        public void ShouldReturn_24e0()
        {
            //Arrange
            expectedResult = "24e0";

            //Action
            string result = AbbreviatingTheProductOfARange_AWS_Exam.AbbreviateProduct(1, 4);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_399168e2()
        {
            //Arrange
            expectedResult = "399168e2";

            //Action
            string result = AbbreviatingTheProductOfARange_AWS_Exam.AbbreviateProduct(2, 11);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_7219856259e3()
        {
            //Arrange
            expectedResult = "7219856259e3";

            //Action
            string result = AbbreviatingTheProductOfARange_AWS_Exam.AbbreviateProduct(371, 375);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
