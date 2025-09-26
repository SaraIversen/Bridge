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

            // Act
            Car car = new Car(license, date);

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
                new Car("", DateTime.Today);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new Car("AR123456", DateTime.Today);
            });
        }

        [TestMethod]
        public void PriceTest_ReturnsExpectedValue()
        {
            // Arrange
            Car car = new Car("AR12345", DateTime.Today);

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(230, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            Car car = new Car("AR12345", DateTime.Today);

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
    }
}