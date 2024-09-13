using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation.Invoicing;

namespace Encapsulation.Tests
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange & Act
            Invoice invoice = new Invoice("001", "Part A", 10, 5.0);

            // Assert
            Assert.AreEqual("001", invoice.PartNumber);
            Assert.AreEqual("Part A", invoice.PartDescription);
            Assert.AreEqual(10, invoice.Quantity);
            Assert.AreEqual(5.0, invoice.Price);
        }

        [TestMethod]
        public void SetQuantity_NegativeValue_ShouldSetToZero()
        {
            // Arrange
            Invoice invoice = new Invoice("001", "Part A", -1, 5.0);

            // Act & Assert
            Assert.AreEqual(0, invoice.Quantity);
        }

        [TestMethod]
        public void Quantity_SetWithNegativeValue_ShouldBeZero()
        {
            // Arrange
            var invoice = new Invoice("001", "Hammer", 10, 50.0); // Membuat dengan nilai positif
            invoice.Quantity = -10; // Mengubah ke nilai negatif

            // Act
            var actualQuantity = invoice.Quantity;

            // Assert
            Assert.AreEqual(0, actualQuantity, "Quantity should be set to 0 if a negative value is provided.");
        }

        [TestMethod]
        public void Price_SetWithNegativeValue_ShouldBeZero()
        {
            // Arrange
            var invoice = new Invoice("002", "Nail", 5, 20.0); // Membuat dengan nilai positif
            invoice.Price = -20.0; // Mengubah ke nilai negatif

            // Act
            var actualPrice = invoice.Price;

            // Assert
            Assert.AreEqual(0.0, actualPrice, "Price should be set to 0.0 if a negative value is provided.");
        }

        [TestMethod]
        public void SetPrice_NegativeValue_ShouldSetToZero()
        {
            // Arrange
            Invoice invoice = new Invoice("001", "Part A", 10, -5.0);

            // Act & Assert
            Assert.AreEqual(0.0, invoice.Price);
        }

        [TestMethod]
        public void GetInvoiceAmount_WithValidQuantityAndPrice_ShouldCalculateCorrectly()
        {
            // Arrange
            Invoice invoice = new Invoice("001", "Part A", 10, 5.0);

            // Act
            double expected = 50.0;
            double actual = invoice.GetInvoiceAmount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetInvoiceAmount_WithZeroQuantity_ShouldReturnZero()
        {
            // Arrange
            Invoice invoice = new Invoice("001", "Part A", 0, 5.0);

            // Act & Assert
            Assert.AreEqual(0.0, invoice.GetInvoiceAmount());
        }

        [TestMethod]
        public void GetInvoiceAmount_WithZeroPrice_ShouldReturnZero()
        {
            // Arrange
            Invoice invoice = new Invoice("001", "Part A", 10, 0.0);

            // Act & Assert
            Assert.AreEqual(0.0, invoice.GetInvoiceAmount());
        }
    }
}
