namespace Bridge
{
    /// <summary>
    /// Base class for vehicles that have a license plate and a ticket purchase date.
    /// Must be inherited to implement specific details about a vehicles price and type.
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; }
        public DateTime Date { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class with the specified license plate and ticket purchase date.
        /// </summary>
        /// <param name="licensePlate">The license plate of the vehicle.</param>
        /// <param name="date">The date when the vehicle bought a bridge ticket.</param>
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = ValidateLicensePlate(licensePlate);
            Date = date;
        }

        /// <summary>
        /// Validates that the given license plate by ensuring it is not null, empty, or longer than 7 characters.
        /// </summary>
        /// <param name="licensePlate">The license plate string to validate.</param>
        /// <returns>The validated license plate string if all checks pass.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="licensePlate"/> is null, empty, or consists only of whitespace.</exception>
        /// <exception cref="ArgumentException">Thrown if <paramref name="licensePlate"/> exceeds 7 characters in length.</exception>
        public string ValidateLicensePlate(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
                throw new ArgumentNullException("Licence plate må ikke være null eller tomt.");

            if (licensePlate.Length > 7)
                throw new ArgumentException("Licence plate må ikke være mere end 7 karakterer langt.");

            return licensePlate;
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
