namespace Bridge.Helpers
{
    /// <summary>
    /// Provides methods for validating vehicle license plates to ensure they meet format requirements,
    /// such as not being null, empty, or longer than 7 characters.
    /// </summary>
    public static class LicensePlateValidator
    {
        /// <summary>
        /// Validates that the given license plate by ensuring it is not null, empty, or longer than 7 characters.
        /// </summary>
        /// <param name="licensePlate">The license plate string to validate.</param>
        /// <returns>The validated license plate string if all checks pass.</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="licensePlate"/> is null, empty, or consists only of whitespace.</exception>
        /// <exception cref="ArgumentException">Thrown if <paramref name="licensePlate"/> exceeds 7 characters in length.</exception>
        public static string Validate(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
                throw new ArgumentNullException("Licence plate må ikke være null eller tomt.");

            if (licensePlate.Length > 7)
                throw new ArgumentException("Licence plate må ikke være mere end 7 karakterer langt.");

            return licensePlate;
        }
    }
}
