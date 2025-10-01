using Bridge.Models;

namespace StoreBaeltRepository
{
    public class Repository : IRepository
    {
        private readonly static List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket (vehicle) to the repository.
        /// </summary>
        /// <param name="ticket">The vehicle ticket to add.</param>
        public void AddTicket(Vehicle ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// Returns all tickets in the repository.
        /// </summary>
        /// <returns>All tickets.</returns>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }


        /// <summary>
        /// Returns all tickets for the specified license plate.
        /// </summary>
        /// <param name="licensePlate">License plate for the specific vehicle.</param>
        /// <returns>Tickets matching the license plate.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return _tickets.Where(t => t.LicensePlate == licensePlate).ToList();
        }
    }
}
