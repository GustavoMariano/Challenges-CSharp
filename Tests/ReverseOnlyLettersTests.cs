using NUnit.Framework;
using ReverseOnlyLetters;

namespace Challenges.Tests
{
    [TestFixture]
    public class ReverseOnlyLettersTests
    {
        [Test]
        public void Test1()
        {
            //Arrange
            string stringLetters = "ab-cd";

            //Action
            string result = ReverseOnlyLetter.Reverse(stringLetters);

            //Assert
            Assert.AreEqual("dc-ba", result);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            string stringLetters = "a-bC-dEf-ghIj";

            //Action
            string result = ReverseOnlyLetter.Reverse(stringLetters);

            //Assert
            Assert.AreEqual("j-Ih-gfE-dCba", result);
        }

        [Test]
        public void Test3()
        {
            //Arrange
            string stringLetters = "Test1ng-Leet=code-Q!";

            //Action
            string result = ReverseOnlyLetter.Reverse(stringLetters);

            //Assert
            Assert.AreEqual("Qedo1ct-eeLg=ntse-T!", result);
        }
    }
}
