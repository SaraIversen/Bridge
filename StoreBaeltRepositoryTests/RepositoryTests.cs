using Bridge.Models;
using StoreBaeltTicketLibrary;

namespace StoreBaeltRepository.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void AddTicketTest()
        {
            // Arrange
            Repository repository = new Repository();

            // Act
            repository.AddTicket(new StoreBaeltCar("AR12345", DateTime.Today, true));

            // Assert
            List<Vehicle> allTickets = repository.GetAllTickets();
            Assert.AreEqual(1, allTickets.Count);
        }

        [TestMethod]
        public void GetAllTicketsTest()
        {
            // Arrange
            Repository repository = new Repository();
            repository.AddTicket(new StoreBaeltCar("AR12345", DateTime.Today, true));

            // Act
            List<Vehicle> allTickets = repository.GetAllTickets();
        
            // Assert
            Assert.AreEqual(2, allTickets.Count);
        }

        [TestMethod]
        public void GetTicketsByLicensePlateTest()
        {
            // Arrange
            Repository repository = new Repository();
            repository.AddTicket(new StoreBaeltCar("AR54321", DateTime.Today, true));
            repository.AddTicket(new StoreBaeltCar("AR54321", DateTime.Today, true));

            // Act
            List<Vehicle> ticketsByLicense = repository.GetTicketsByLicensePlate("AR54321");

            // Assert
            Assert.AreEqual(2, ticketsByLicense.Count);
        }
    }
}