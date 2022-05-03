using BirthdayCakeCandles;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class BirthdayCakeCandlesTests
{
    List<int> listInt;
    [Test]
    public void BasicCases()
    {
        listInt = new() { 3, 2, 1, 3 };
        Assert.AreEqual(2, BdayCakeCandles.birthdayCakeCandles(listInt));

        listInt = new() { 4, 4, 1, 3 };
        Assert.AreEqual(2, BdayCakeCandles.birthdayCakeCandles(listInt));
    }
}

