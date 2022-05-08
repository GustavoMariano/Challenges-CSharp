using MorseDecoder;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class MorseCodeTests
    {
        [Test]
        public void NormalLetters()
        {
            Assert.AreEqual(new string[] { "E" }, MorseCode.Possibilities("."));
            Assert.AreEqual(new string[] { "A" }, MorseCode.Possibilities(".-"));
            Assert.AreEqual(new string[] { "S" }, MorseCode.Possibilities("..."));
        }

        [Test]
        public void WordsWithASingle_UnknownSignal()
        {
            Assert.AreEqual(new string[] { "E", "T" }, MorseCode.Possibilities("?"));
            Assert.AreEqual(new string[] { "I", "N" }, MorseCode.Possibilities("?."));
            Assert.AreEqual(new string[] { "I", "A" }, MorseCode.Possibilities(".?"));

            Assert.AreEqual(new string[] { "A", "M" }, MorseCode.Possibilities("?-"));
            Assert.AreEqual(new string[] { "S", "U" }, MorseCode.Possibilities("..?"));
            Assert.AreEqual(new string[] { "R", "W" }, MorseCode.Possibilities(".-?"));
            Assert.AreEqual(new string[] { "G", "O" }, MorseCode.Possibilities("--?"));
            Assert.AreEqual(new string[] { "D", "K" }, MorseCode.Possibilities("-.?"));
            Assert.AreEqual(new string[] { "I", "A", "N", "M" }, MorseCode.Possibilities("??"));
            Assert.AreEqual(new string[] { "S", "U", "R", "W", "D", "K", "G", "O" }, MorseCode.Possibilities("???"));

            Assert.AreEqual(new string[] { "I", "A", "N", "M" }, MorseCode.Possibilities("3 "));
            Assert.AreEqual(new string[] { "S", "U" }, MorseCode.Possibilities("..A"));
            Assert.AreEqual(new string[] { "S", "U", "R", "W", "D", "K", "G", "O" }, MorseCode.Possibilities("AAA"));
        }
    }
}