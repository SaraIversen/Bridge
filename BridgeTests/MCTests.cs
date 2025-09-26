using Bridge.Models;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bridge.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void ConstructorTest_ValidData()
        {
            // Arrange
            string license = "AR12345";
            DateTime date = DateTime.Today;
            bool hasBrobizz = false;

            // Act
            MC car = new MC(license, date, hasBrobizz);

            // Assert
            Assert.AreEqual(license, car.LicensePlate);
            Assert.AreEqual(date, car.Date);
            Assert.AreEqual(hasBrobizz, car.HasBrobizz);
        }

        [TestMethod]
        public void ConstructorTest_EmptyLicensePlate_NullException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new MC("", DateTime.Today, false);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new MC("AR123456", DateTime.Today, false);
            });
        }

        [DataTestMethod]
        [DataRow(false, 120)]
        [DataRow(true, 108)]
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, double expectedPrice)
        {
            // Arrange
            MC mc = new MC("AR12345", DateTime.Today, hasBrobizz);

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            MC mc = new MC("AR12345", DateTime.Today, false);

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}