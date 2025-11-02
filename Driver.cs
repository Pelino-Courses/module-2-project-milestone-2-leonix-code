namespace RideHailingSystem
{
    public class Driver
    {
        public string Name { get; set; }
        public string MotoPlateNumber { get; set; }
        public bool IsAvailable { get; set; }

        public Driver(string name, string motoPlateNumber, bool isAvailable)
        {
            Name = name;
            MotoPlateNumber = motoPlateNumber;
            IsAvailable = isAvailable;
        }
    }
}
