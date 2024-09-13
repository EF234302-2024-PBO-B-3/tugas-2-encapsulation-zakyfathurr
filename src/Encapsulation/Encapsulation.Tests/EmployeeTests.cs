using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encapsulation.Employment;

namespace Encapsulation.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Constructor_WithNullFirstName_ShouldSetFirstNameToUnknown()
        {
            // Arrange
            string firstName = null;
            string lastName = "Doe";
            double salary = 1000.0;

            // Act
            Employee employee = new Employee(firstName, lastName, salary);

            // Assert
            Assert.AreEqual("Unknown", employee.FirstName, "FirstName should be set to 'Unknown' if null is provided.");
        }

        [TestMethod]
        public void Constructor_WithEmptyFirstName_ShouldSetFirstNameToUnknown()
        {
            // Arrange
            string firstName = "";
            string lastName = "Doe";
            double salary = 1000.0;

            // Act
            Employee employee = new Employee(firstName, lastName, salary);

            // Assert
            Assert.AreEqual("Unknown", employee.FirstName, "FirstName should be set to 'Unknown' if an empty string is provided.");
        }

        [TestMethod]
        public void Constructor_WithNullLastName_ShouldSetLastNameToUnknown()
        {
            // Arrange
            string firstName = "John";
            string lastName = null;
            double salary = 1000.0;

            // Act
            Employee employee = new Employee(firstName, lastName, salary);

            // Assert
            Assert.AreEqual("Unknown", employee.LastName, "LastName should be set to 'Unknown' if null is provided.");
        }

        [TestMethod]
        public void Constructor_WithEmptyLastName_ShouldSetLastNameToUnknown()
        {
            // Arrange
            string firstName = "John";
            string lastName = "";
            double salary = 1000.0;

            // Act
            Employee employee = new Employee(firstName, lastName, salary);

            // Assert
            Assert.AreEqual("Unknown", employee.LastName, "LastName should be set to 'Unknown' if an empty string is provided.");
        }

        [TestMethod]
        public void Constructor_ValidParameters_ShouldSetProperties()
        {
            // Arrange & Act
            var employee = new Employee("John", "Doe", 3000);

            // Assert
            Assert.AreEqual("John", employee.FirstName);
            Assert.AreEqual("Doe", employee.LastName);
            Assert.AreEqual(3000, employee.MonthlySalary);
        }

        [TestMethod]
        public void Constructor_NegativeSalary_ShouldSetSalaryToZero()
        {
            // Arrange & Act
            var employee = new Employee("John", "Doe", -100);

            // Assert
            Assert.AreEqual(0.0, employee.MonthlySalary);
        }

        [TestMethod]
        public void SetMonthlySalary_NegativeValue_ShouldNotChangeSalary()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 3000);

            // Act
            employee.MonthlySalary = -100;

            // Assert
            Assert.AreEqual(3000, employee.MonthlySalary);
        }

        [TestMethod]
        public void RaiseSalary_ValidPercentage_ShouldIncreaseSalary()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1000);

            // Act
            employee.RaiseSalary(10);

            // Assert
            Assert.AreEqual(1100, employee.MonthlySalary);
        }

        [TestMethod]
        public void RaiseSalary_NegativePercentage_ShouldNotChangeSalary()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1000);

            // Act
            employee.RaiseSalary(-10);

            // Assert
            Assert.AreEqual(1000, employee.MonthlySalary);
        }

        [TestMethod]
        public void RaiseSalary_TooHighPercentage_ShouldNotChangeSalary()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1000);

            // Act
            employee.RaiseSalary(21);

            // Assert
            Assert.AreEqual(1000, employee.MonthlySalary);
        }

        [TestMethod]
        public void GetYearlySalary_ShouldReturnCorrectValue()
        {
            // Arrange
            var employee = new Employee("John", "Doe", 1000);

            // Act
            var yearlySalary = employee.GetYearlySalary();

            // Assert
            Assert.AreEqual(12000, yearlySalary);
        }
    }
}
