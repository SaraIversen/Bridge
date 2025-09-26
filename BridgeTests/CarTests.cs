using Bridge.Models;
using System.Diagnostics.CodeAnalysis;

namespace Bridge.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void ConstructorTest_ValidData()
        {
            // Arrange
            string license = "AR12345";
            DateTime date = DateTime.Today;
            bool hasBrobizz = false;

            // Act
            Car car = new Car(license, date, hasBrobizz);

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
                new Car("", DateTime.Today, false);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Car("AR123456", DateTime.Today, false);
            });
        }

        [DataTestMethod]
        [DataRow(false, 230)]
        [DataRow(true, 207)]
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, double expectedPrice)
        {
            // Arrange
            Car car = new Car("AR12345", DateTime.Today, hasBrobizz);

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            Car car = new Car("AR12345", DateTime.Today, false);

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
    }
}