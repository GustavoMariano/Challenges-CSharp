using NUnit.Framework;
using QuotaPerMonth_RafaKowalski;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class QuotaPerMonthRafaKowalskiTests
    {
        private int months = 0;
        private double price = 0;

        [Test]
        public void TwoHundred_ThreeMonths()
        {
            //Arrange
            months = 3;
            price = 200;

            List<double> expectedResult = new() { 206.04, 208.08, 210.12 };
            List<double> result = new();

            //Action
            for (int i = 1; i <= months; i++)
                result.Add(QuotaPerMonth.Calculate(i, price));

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TwoHundred_SixMonths()
        {
            //Arrange
            months = 6;
            price = 200;

            List<double> expectedResult = new() { 206.04, 208.08, 210.12, 212.16, 214.20, 216.24 };
            List<double> result = new();

            //Action
            for (int i = 1; i <= months; i++)
                result.Add(QuotaPerMonth.Calculate(i, price));

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
