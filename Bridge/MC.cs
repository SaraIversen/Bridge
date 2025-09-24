namespace Bridge
{
    /// <summary>
    /// Contains data about the specific MC.
    /// </summary>
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the price for this specific MC class.
        /// </summary>
        /// <returns>The price of the MC as a double</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// Gets the vehicle type for this specific MC class.
        /// </summary>
        /// <returns>The vecihcle type of the MC as a string</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
