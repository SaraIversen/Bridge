using Bridge.Models;
using System.Diagnostics.CodeAnalysis;

namespace StoreBaeltTicketLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class MCTests
    {
        [DataTestMethod]
        [DataRow(false, "2025-01-01", 120)] // Base price (no brobizz, weekday)
        [DataRow(true, "2025-01-01", 108)] // With brobizz discount only (still weekday)
        [DataRow(true, "2025-01-04", 108)] // With brobizz & weekend
        [DataRow(false, "2025-01-04", 120)] // No brobizz & weekend
        public void PriceTest_ReturnsExpectedValue(bool hasBrobizz, string dateString, double expectedPrice)
        {
            // Arrange
            DateTime date = DateTime.Parse(dateString);
            MC mc = new MC("AR12345", date, hasBrobizz);

            // Act
            double result = StoreBaeltTicketCalculator.CalculatePrice(basePrice: mc.Price(), vehicle: mc);

            // Assert
            Assert.AreEqual(expectedPrice, result, 0.001);
        }
    }
}