using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bridge
{
    /// <summary>
    /// Contains data about the specific MC.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Constructor that takes parameters.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle</param>
        /// <param name="date">The date of which the vechile bought a bridge ticket</param>
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Gets the price for this specific MC class.
        /// </summary>
        /// <returns>The price of the MC as a double</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Gets the vehicle type for this specific MC class.
        /// </summary>
        /// <returns>The vecihcle type of the MC as a string</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
