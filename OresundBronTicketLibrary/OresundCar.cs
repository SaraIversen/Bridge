using Bridge.Models;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// Represents an Oresund car vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class OresundCar : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OresundCar"/> class with the specified license plate, ticket purchase date, and Brobizz status.
        /// </summary>
        /// <param name="licensePlate">The license plate of the Oresund car.</param>
        /// <param name="date">The date when the Oresund car bought a bridge ticket.</param>
        /// <param name="hasBrobizz">Indicates whether the Oresund car has a Brobizz.</param>
        public OresundCar(string licensePlate, DateTime date, bool hasBrobizz) : base(licensePlate, date, hasBrobizz) { }

        /// <summary>
        /// Gets the price for an Oresund car.
        /// </summary>
        /// <returns>The price of the Oresund car as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return HasBrobizz ? 178 : 460;
        }

        /// <summary>
        /// Gets the vehicle type for an Oresund car.
        /// </summary>
        /// <returns>The vehicle type as a <see cref="string"/>.</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
