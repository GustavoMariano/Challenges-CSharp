using NUnit.Framework;
using SearchingChallenge;

namespace Challenges.Tests
{
    [TestFixture]
    public class SearchingPalindromeChallengeTests
    {
        [Test]
        public void Palindrome_hellosannasmith()
        {
            //Arrange
            string input = "hellosannasmith";
            string expectedResult = "sannas";

            //Action
            string result = SearchingPalindromeChallenge.Solution(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Palindrome_abcdefge()
        {
            //Arrange
            string input = "abcdefge";
            string expectedResult = "none";

            //Action
            string result = SearchingPalindromeChallenge.Solution(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
