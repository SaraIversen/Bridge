using System.Diagnostics.CodeAnalysis;

namespace OresundBronTicketLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void ConstructorTest_ValidData()
        {
            // Arrange
            string license = "AR12345";
            DateTime date = DateTime.Today;
            bool hasBrobizz = false;

            // Act
            OresundCar oresundCar = new OresundCar(license, date, hasBrobizz);

            // Assert
            Assert.AreEqual(license, oresundCar.LicensePlate);
            Assert.AreEqual(date, oresundCar.Date);
            Assert.AreEqual(hasBrobizz, oresundCar.HasBrobizz);
        }

        [TestMethod]
        public void ConstructorTest_EmptyLicensePlate_NullException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new OresundCar("", DateTime.Today, false);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new OresundCar("AR123456", DateTime.Today, false);
            });
        }

        [DataTestMethod]
        [DataRow(false, 460)]
        [DataRow(true, 178)]
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, double expectedPrice)
        {
            // Arrange
            OresundCar oresundCar = new OresundCar("AR12345", DateTime.Today, hasBrobizz);

            // Act
            double result = oresundCar.Price();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            OresundCar oresundCar = new OresundCar("AR12345", DateTime.Today, false);

            // Act
            string result = oresundCar.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", result);
        }
    }
}