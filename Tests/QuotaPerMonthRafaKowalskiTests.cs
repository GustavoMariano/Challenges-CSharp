using NUnit.Framework;
using QuotaPerMonth_RafaKowalski;
using System.Collections.Generic;

[TestFixture]
public class QuotaPerMonthRafaKowalskiTests
{
    private QuotaPerMonth quotaPerMonth = new();
    private int months = 0;
    private double price = 0;

    [Test]
    public void BasicCases()
    {
        //Arrange
        months = 3;
        price = 200;
        List<double> expectedResult = new() { 206.04, 208.08, 210.12 };
        List<double> result = new();

        //Action
        for (int i = 1; i <= months; i++)
            result.Add(quotaPerMonth.Calculate(i, price));

        //Assert
        Assert.AreEqual(expectedResult, result);
    }
}
