using Bridge.Helpers;

namespace Bridge.Models
{
    /// <summary>
    /// Base class for vehicles that have a license plate and a ticket purchase date.
    /// Must be inherited to implement specific details about a vehicles price and type.
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; }
        public DateTime Date { get; }
        public bool HasBrobizz { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with the specified license plate, ticket purchase date, and Brobizz status.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle.</param>
        /// <param name="date">The date when the vehicle bought a bridge ticket.</param>
        /// <param name="hasBrobizz">Indicates whether the vehicle has a Brobizz.</param>
        protected Vehicle(string licensePlate, DateTime date, bool hasBrobizz)
        {
            LicensePlate = LicensePlateValidator.Validate(licensePlate);
            Date = date;
            HasBrobizz = hasBrobizz;
        }

        /// <summary>
        /// Gets the price for this vehicle.
        /// Must be implemented in derived classes.
        /// </summary>
        public abstract double Price();

        /// <summary>
        /// Gets the type of this vehicle.
        /// Must be implemented in derived classes.
        /// </summary>
        public abstract string VehicleType();
    }
}
