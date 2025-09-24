namespace Bridge
{
    /// <summary>
    /// Contains data about the specific car.
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the price for this specific car class.
        /// </summary>
        /// <returns>The price of the car as a double</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Gets the vehicle type for this specific car class.
        /// </summary>
        /// <returns>The vecihcle type of the car as a string</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
