using System.Diagnostics.CodeAnalysis;

namespace StoreBaeltTicketLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class StoreBaeltCarTests
    {
        [DataTestMethod]
        [DataRow(false, "2025-01-01", 230)] // Base price (no brobizz, weekday)
        [DataRow(true, "2025-01-01", 207)] // With brobizz discount only (still weekday)
        [DataRow(true, "2025-01-04", 175.95)] // With weekend & then brobizz discount
        [DataRow(false, "2025-01-04", 195.5)] // With weekend discount (no brobizz)
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, string dateString, double expectedPrice)
        {
            // Arrange
            DateTime date = DateTime.Parse(dateString);
            StoreBaeltCar storeBaeltCar = new StoreBaeltCar("AR12345", date, hasBrobizz);

            // Act
            double result = storeBaeltCar.Price();

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }
    }
}