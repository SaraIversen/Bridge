using System.Diagnostics.CodeAnalysis;

namespace Bridge.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class MCTests
    {
        [DataTestMethod()]
        [DataRow]
        public void PriceTest()
        {
            // Arrange
            MC mc = new MC("", DateTime.Today);

            // Act
            double result = mc.Price();

            // Assert
            Assert.AreEqual(120, result, 0.001);
        }

        [DataTestMethod()]
        [DataRow]
        public void VehicleTypeTest()
        {
            // Arrange
            MC mc = new MC("", DateTime.Today);

            // Act
            string result = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", result);
        }
    }
}