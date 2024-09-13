using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation.Calendar;
using System;

namespace Encapsulation.Tests;

[TestClass]
public class DateTests
{
    [TestMethod]
    public void Date_Constructor_ValidValues()
    {
        // Arrange & Act
        Date date = new Date(12, 31, 2021);

        // Assert
        Assert.AreEqual(12, date.Month);
        Assert.AreEqual(31, date.Day);
        Assert.AreEqual(2021, date.Year);
    }

    [TestMethod]
    public void Date_Constructor_InvalidMonthSetsDefault()
    {
        // Arrange & Act
        Date date = new Date(13, 31, 2021); // Invalid month

        // Assert
        Assert.AreEqual(1, date.Month);
        Assert.AreEqual(1, date.Day);
        Assert.AreEqual(1970, date.Year);
    }

    [TestMethod]
    public void Date_Constructor_InvalidDaySetsDefault()
    {
        // Arrange & Act
        Date date = new Date(12, 32, 2021); // Invalid day

        // Assert
        Assert.AreEqual(1, date.Month);
        Assert.AreEqual(1, date.Day);
        Assert.AreEqual(1970, date.Year);
    }

}
