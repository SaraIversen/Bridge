using Bridge.Helpers;

namespace Bridge.Models
{
    /// <summary>
    /// Represents a car vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class with the specified license plate, ticket purchase date, and Brobizz status.
        /// </summary>
        /// <param name="licensePlate">The license plate of the car.</param>
        /// <param name="date">The date when the car bought a bridge ticket.</param>
        /// <param name="hasBrobizz">Indicates whether the car has a Brobizz.</param>
        public Car(string licensePlate, DateTime date, bool hasBrobizz) : base(licensePlate, date, hasBrobizz) { }

        /// <summary>
        /// Gets the price for a car.
        /// </summary>
        /// <returns>The price of the car as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return DiscountCalculator.CalculatePrice(basePrice: 230, vehicle: this); //230;
        }

        /// <summary>
        /// Gets the vehicle type for a car.
        /// </summary>
        /// <returns>The vehicle type as a <see cref="string"/>.</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
