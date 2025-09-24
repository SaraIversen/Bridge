using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Can be inherited to implement data about a specific vehicle
    /// </summary>
    public abstract class Vehicle
    {
        protected string LicensePlate { get; set; }
        protected DateTime Date { get; set; }

        /// <summary>
        /// Constructor that takes parameters.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle</param>
        /// <param name="date">The date of which the vechile bought a bridge ticket</param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Gets the price for this specific vehicle class.
        /// </summary>
        /// <returns>The price of the vehicle as a double</returns>
        public virtual double Price()
        {
            return 0;
        }

        /// <summary>
        /// Gets the vehicle type for this specific vehicle class.
        /// </summary>
        /// <returns>The vecihcle type of the vehicle as a string</returns>
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
    }
}
