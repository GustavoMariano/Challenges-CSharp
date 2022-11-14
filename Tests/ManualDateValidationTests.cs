using ManualDateValidation;
using NUnit.Framework;
using System;

namespace Challenges.Tests
{
    [TestFixture]
    public class ManualDateValidationTests
    {
        DateValidation dateValidation;

        public ManualDateValidationTests()
        {
            dateValidation = new();
        }

        #region Year Validation
        [Test]
        public void YearBelow1_Should_ThrowException()
        {
            //Arrange / Action
            int day = 01, month = 01, year = 0;

            //Assert
            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Entered year is out of validation scope(0001 ~3000)"));
        }

        [Test]
        public void YearAbove3000_Should_ThrowException()
        {
            //Arrange / Action
            int day = 01, month = 01, year = 3001;

            //Assert
            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Entered year is out of validation scope(0001 ~3000)"));
        }

        [Test]
        public void YearValid_ShouldNot_ThrowException()
        {
            //Arrange / Action
            int day = 01, month = 01, year = 2000;

            //Assert
            Assert.DoesNotThrow(() => dateValidation.IntToDate(day, month, year));
        }
        #endregion

        #region Month Validation
        [Test]
        public void MonthBelow1_Should_ThrowException()
        {
            int day = 01, month = 00, year = 2021;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("The month entered is invalid!!"));
        }

        [Test]        
        public void MonthAbove12_Should_ThrowException()
        {
            int day = 01, month = 13, year = 2021;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("The month entered is invalid!!"));
        }

        [Test]
        public void MonthValid_ShouldNot_ThrowException()
        {
            int day = 01, month = 01, year = 2021;

            Assert.DoesNotThrow(() => dateValidation.IntToDate(day, month, year));
        }
        #endregion

        #region Day Validation
        [Test]
        public void DayBelow1_Should_ThrowException()
        {
            int day = 00, month = 01, year = 2021;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Day informed is invalid!!"));
        }

        #region 31 day month test cases
        [Test]
        [TestCase(01)]
        [TestCase(03)]
        [TestCase(05)]
        [TestCase(07)]
        [TestCase(08)]
        [TestCase(10)]
        [TestCase(12)]
        public void MonthAbove31_Should_ThrowException(int month)
        {
            int day = 32, year = 2020;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Day informed is invalid!!"));
        }
        #endregion

        #region 30 day month test cases
        [Test]
        [TestCase(04)]
        [TestCase(06)]
        [TestCase(09)]
        [TestCase(11)]
        public void DayAbove30_Should_ThrowException(int month)
        {
            int day = 31, year = 2021;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("Day informed is invalid!!"));
        }
        #endregion

        #region February Validation
        [Test]
        public void Day29OrAbove_InFebruary_IsNotLeapYear_Should_ThrowException()
        {
            int day = 29, month = 02, year = 2021;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("The year informed is not a leap year, so February has 28 days!!"));
        }

        [Test]
        public void DayAbove29_InFebruary_IsLeapYear_Should_ThrowException()
        {
            int day = 30, month = 02, year = 2020;

            Assert.That(() => dateValidation.IntToDate(day, month, year),
                Throws.TypeOf<ArgumentException>().With.Message.EqualTo("The year informed is a leap year, however the day informed is not valid!!"));
        }
        #endregion

        #endregion
    }
}
