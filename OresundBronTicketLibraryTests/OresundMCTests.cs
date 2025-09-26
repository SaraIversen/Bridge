using OresundBronTicketLibrary;
using System.Diagnostics.CodeAnalysis;

namespace OresundBronTicketLibraryTests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class OresundMCTests
    {
        [TestMethod]
        public void ConstructorTest_ValidData()
        {
            // Arrange
            string license = "AR12345";
            DateTime date = DateTime.Today;
            bool hasBrobizz = false;

            // Act
            OresundMC oresundMc = new OresundMC(license, date, hasBrobizz);

            // Assert
            Assert.AreEqual(license, oresundMc.LicensePlate);
            Assert.AreEqual(date, oresundMc.Date);
            Assert.AreEqual(hasBrobizz, oresundMc.HasBrobizz);
        }

        [TestMethod]
        public void ConstructorTest_EmptyLicensePlate_NullException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                new OresundMC("", DateTime.Today, false);
            });
        }

        [TestMethod]
        public void ConstructorTest_LicensePlateTooLong_ArgumentException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                new OresundMC("AR123456", DateTime.Today, false);
            });
        }

        [DataTestMethod]
        [DataRow(false, 235)]
        [DataRow(true, 92)]
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, double expectedPrice)
        {
            // Arrange
            OresundMC oresundMc = new OresundMC("AR12345", DateTime.Today, hasBrobizz);

            // Act
            double result = oresundMc.Price();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }

        [TestMethod]
        public void VehicleTypeTest_ReturnsExpectedValue()
        {
            // Arrange
            OresundMC oresundMc = new OresundMC("AR12345", DateTime.Today, false);

            // Act
            string result = oresundMc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", result);
        }
    }
}
