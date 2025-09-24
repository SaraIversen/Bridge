using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bridge
{
    /// <summary>
    /// Contains data about the specific car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor that takes parameters.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle</param>
        /// <param name="date">The date of which the vechile bought a bridge ticket</param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Gets the price for this specific car class.
        /// </summary>
        /// <returns>The price of the car as a double</returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Gets the vehicle type for this specific car class.
        /// </summary>
        /// <returns>The vecihcle type of the car as a string</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
