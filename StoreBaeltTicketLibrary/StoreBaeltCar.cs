using Bridge.Models;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents a StoreBaelt car vehicle, derived from <see cref="Vehicle"/>.
    /// </summary>
    public class StoreBaeltCar : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBaeltCar"/> class with the specified license plate, ticket purchase date, and Brobizz status.
        /// </summary>
        /// <param name="licensePlate">The license plate of the StoreBaelt car.</param>
        /// <param name="date">The date when the StoreBaelt car bought a bridge ticket.</param>
        /// <param name="hasBrobizz">Indicates whether the StoreBaelt car has a Brobizz.</param>
        public StoreBaeltCar(string licensePlate, DateTime date, bool hasBrobizz) : base(licensePlate, date, hasBrobizz) { }

        /// <summary>
        /// Gets the price for a StoreBaelt car.
        /// </summary>
        /// <returns>The price of the StoreBaelt car as a <see cref="double"/>.</returns>
        public override double Price()
        {
            double basePrice = 230;

            // Weekend discount
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% discount
            }

            // Brobizz discount
            if (HasBrobizz)
            {
                basePrice *= 0.9; // 10% discount
            }

            return basePrice;
        }

        /// <summary>
        /// Gets the vehicle type for a StoreBaelt car.
        /// </summary>
        /// <returns>The vehicle type as a <see cref="string"/>.</returns>
        public override string VehicleType()
        {
            return "StoreBaelt car";
        }
    }
}
