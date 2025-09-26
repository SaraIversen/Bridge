using Bridge.Models;

namespace Bridge.Helpers
{
    /// <summary>
    /// Provides methods to apply discounts, such as Brobizz discounts, when calculating the final ticket price for a vehicle.
    /// </summary>
    public static class DiscountCalculator
    {
        /// <summary>
        /// Calculates the final price for a vehicle after applying discounts.
        /// Currently applies a 10% Brobizz discount if the vehicle has a Brobizz.
        /// </summary>
        /// <param name="basePrice">The base ticket price before any discounts.</param>
        /// <param name="vehicle">The vehicle for which the price is being calculated.</param>
        /// <returns>The final ticket price after applying discounts.</returns>
        public static double CalculatePrice(double basePrice, Vehicle vehicle)
        {
            // Brobizz discount
            if (vehicle.HasBrobizz)
            {
                basePrice *= 0.9; // 10% off
            }

            return basePrice;
        }
    }
}
