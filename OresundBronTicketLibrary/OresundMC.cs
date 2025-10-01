using Bridge.Models;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// Represents an Oresund motorcycle (MC) vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class OresundMC : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OresundMC"/> class with the specified license plate and ticket purchase date, ticket purchase date, and Brobizz status.
        /// </summary>
        /// <param name="licensePlate">The license plate of the Oresund motorcycle.</param>
        /// <param name="date">The date when the Oresund motorcycle bought a bridge ticket.</param>
        /// <param name="hasBrobizz">Indicates whether the Oresund motorcycle has a Brobizz.</param>
        public OresundMC(string licensePlate, DateTime date, bool hasBrobizz) : base(licensePlate, date, hasBrobizz) { }

        /// <summary>
        /// Gets the price for an Oresund motorcycle.
        /// </summary>
        /// <returns>The price of the Oresund motorcycle as a <see cref="double"/>.</returns>
        public override double Price()
        {
            return HasBrobizz ? 92 : 235;
        }

        /// <summary>
        /// Gets the vehicle type for an Oresund motorcycle.
        /// </summary>
        /// <returns>The vehicle type as a <see cref="string"/>.</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
