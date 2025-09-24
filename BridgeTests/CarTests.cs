using System.Diagnostics.CodeAnalysis;

namespace Bridge.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class CarTests
    {
        [DataTestMethod()]
        [DataRow]
        public void PriceTest()
        {
            // Arrange
            Car car = new Car();

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(230, result, 0.001);
        }

        [DataTestMethod()]
        [DataRow]
        public void VehicleTypeTest()
        {
            // Arrange
            Car car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
    }
}