using Bridge.Models;

namespace StoreBaeltRepository
{
    /// <summary>
    /// Defines the contract for a ticket repository for Storebaeltbroen.
    /// Provides functionality to add and retrieve tickets.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Adds (buys) a new ticket to the repository.
        /// </summary>
        /// <param name="ticket">The vehicle ticket to add.</param>
        void AddTicket(Vehicle ticket);

        /// <summary>
        /// Returns all tickets in the repository.
        /// </summary>
        /// <returns>A list of all vehicle tickets.</returns>
        List<Vehicle> GetAllTickets();


        /// <summary>
        /// Returns all tickets for the specified license plate.
        /// </summary>
        /// <param name="licensePlate">License plate for the specific vehicle.</param>
        /// <returns>Tickets matching the license plate.</returns>
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}
