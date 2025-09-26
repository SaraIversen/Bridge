using Bridge.Models;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Provides methods to apply StoreBaelt discounts, when calculating the final ticket price for a vehicle.
    /// </summary>
    public static class StoreBaeltTicketCalculator
    {
        /// <summary>
        /// Calculates the final price for a vehicle after applying discounts.
        /// <para>- Applies a 15% weekend discount if the vehicle is a car and the date is Saturday or Sunday.</para>
        /// <para>- Applies a 10% Brobizz discount if the vehicle has a Brobizz.</para>
        /// </summary>
        /// <param name="basePrice">The base ticket price before any discounts.</param>
        /// <param name="vehicle">The vehicle for which the price is being calculated.</param>
        /// <returns>The final ticket price after applying discounts.</returns>
        public static double CalculatePrice(double basePrice, Vehicle vehicle)
        {
            // Weekend discount (only to Cars)
            if (vehicle is Car &&
               (vehicle.Date.DayOfWeek == DayOfWeek.Saturday || vehicle.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                basePrice *= 0.85; // 15% discount
            }

            // Brobizz discount
            if (vehicle.HasBrobizz)
            {
                basePrice *= 0.9; // 10% discount
            }

            return basePrice;
        }
    }
}
