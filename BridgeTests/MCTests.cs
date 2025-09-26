using System.Diagnostics.CodeAnalysis;

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

            // Act
            MC car = new MC(license, date);

            // Assert
            Assert.AreEqual(license, car.LicensePlate);
            Assert.AreEqual(date, car.Date);
        }

        [TestMethod]
        public void ConstructorTest_EmptyLicensePlate_NullException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new MC("", DateTime.Today);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new MC("AR123456", DateTime.Today);
            });
        }

        [TestMethod]
        public void PriceTest_ReturnsExpectedValue()
        {
            // Arrange
            MC mc = new MC("AR12345", DateTime.Today);

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(120, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            MC mc = new MC("AR12345", DateTime.Today);

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}