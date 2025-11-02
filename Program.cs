using System;

namespace RideHailingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RideService rideService = new RideService();
            
            bool exit = false;
            
            while (!exit)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        RegisterDriver(rideService);
                        break;
                    case "2":
                        RegisterPassenger(rideService);
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Thank you for using the Ride-Hailing System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
                Console.WriteLine();
            }
        }
        
        static void DisplayMenu()
        {
            Console.WriteLine("=== Ride-Hailing System ===");
            Console.WriteLine("1. Register Driver");
            Console.WriteLine("2. Register Passenger");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option: ");
        }
        
        static void RegisterDriver(RideService rideService)
        {
            Console.WriteLine("\n--- Driver Registration ---");
            
            Console.Write("Enter driver's name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter moto plate number: ");
            string plateNumber = Console.ReadLine();
            
            Console.Write("Is the driver available? (true/false): ");
            bool isAvailable;
            while (!bool.TryParse(Console.ReadLine(), out isAvailable))
            {
                Console.Write("Invalid input. Please enter 'true' or 'false': ");
            }
            
            Driver driver = new Driver(name, plateNumber, isAvailable);
            rideService.RegisterDriver(driver);
        }
        
        static void RegisterPassenger(RideService rideService)
        {
            Console.WriteLine("\n--- Passenger Registration ---");
            
            Console.Write("Enter passenger's name: ");
            string name = Console.ReadLine();
            
            Passenger passenger = new Passenger(name);
            rideService.RegisterPassenger(passenger);
        }
    }
}
