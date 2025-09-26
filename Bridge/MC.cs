namespace Bridge
{
    /// <summary>
    /// Represents a motorcycle (MC) vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MC"/> class with the specified license plate and ticket purchase date.
        /// </summary>
        /// <param name="licensePlate">The license plate of the motorcycle.</param>
        /// <param name="date">The date when the motorcycle bought a bridge ticket.</param>
        public MC(string licensePlate, DateTime date) : base(licensePlate, date) { }

        /// <summary>
        /// Gets the price for a motorcycle.
        /// </summary>
        /// <returns>The price of the motorcycle as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Gets the vehicle type for a motorcycle.
        /// </summary>
        /// <returns>The vehicle type as a <see cref="string"/>.</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
