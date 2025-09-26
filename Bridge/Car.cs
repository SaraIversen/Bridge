namespace Bridge
{
    /// <summary>
    /// Represents a car vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class with the specified license plate and ticket purchase date.
        /// </summary>
        /// <param name="licensePlate">The license plate of the car.</param>
        /// <param name="date">The date when the car bought a bridge ticket.</param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date) { }

        /// <summary>
        /// Gets the price for a car.
        /// </summary>
        /// <returns>The price of the car as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return 230;
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
