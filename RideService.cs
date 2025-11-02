using System.Collections.Generic;

namespace RideHailingSystem
{
    public class RideService
    {
        private List<Driver> drivers;
        private List<Passenger> passengers;

        public RideService()
        {
            drivers = new List<Driver>();
            passengers = new List<Passenger>();
        }

        public void RegisterDriver(Driver driver)
        {
            drivers.Add(driver);
            System.Console.WriteLine($"Driver {driver.Name} registered successfully!");
        }

        public void RegisterPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
            System.Console.WriteLine($"Passenger {passenger.Name} registered successfully!");
        }

        public List<Driver> GetDrivers()
        {
            return drivers;
        }

        public List<Passenger> GetPassengers()
        {
            return passengers;
        }
    }
}
