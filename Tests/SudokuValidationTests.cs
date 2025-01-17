using NUnit.Framework;
using SudokuValidation;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class SudokuValidationTests
    {
        [Test]
        public void ShouldReturnTrue()
        {
            List<List<string>> sudoku = new()
            {
                new List<string> { "5", "3", "", "", "7", "", "", "", "" },
                new List<string> { "6", "", "", "1", "9", "5", "", "", "" },
                new List<string> { "", "9", "8", "", "", "", "", "6", "" },
                new List<string> { "8", "", "", "", "6", "", "", "", "3" },
                new List<string> { "4", "", "", "8", "", "3", "", "", "1" },
                new List<string> { "7", "", "", "", "2", "", "", "", "6" },
                new List<string> { "", "6", "", "", "", "", "2", "8", "" },
                new List<string> { "", "", "", "4", "1", "9", "", "", "5" },
                new List<string> { "", "", "", "", "8", "", "", "7", "9" }
            };

            Assert.AreEqual(true, SudokuValidator.Validator(sudoku));
        }

        [Test]
        public void ShouldReturnFalse()
        {
            List<List<string>> sudoku = new()
            {
                new List<string> { "5", "3", "", "", "7", "", "", "", "" },
                new List<string> { "6", "", "", "1", "9", "5", "", "", "" },
                new List<string> { "", "9", "8", "", "", "", "", "6", "" },
                new List<string> { "8", "", "", "", "6", "", "", "", "3" },
                new List<string> { "4", "", "", "8", "", "3", "", "", "1" },
                new List<string> { "7", "", "", "", "2", "", "", "", "6" },
                new List<string> { "", "6", "", "", "", "", "2", "8", "" },
                new List<string> { "", "", "", "4", "1", "9", "", "", "5" },
                new List<string> { "", "", "", "", "8", "9", "", "7", "9" }
            };

            Assert.AreEqual(false, SudokuValidator.Validator(sudoku));
        }
    }
}
