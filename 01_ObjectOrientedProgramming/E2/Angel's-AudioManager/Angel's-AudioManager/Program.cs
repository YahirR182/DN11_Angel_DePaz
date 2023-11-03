using Angel_s_AudioManager_Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;

        Console.WriteLine("VEHICLES");
        Console.WriteLine(" ");
        Console.WriteLine("1 .- Bycicle");
        Console.WriteLine("2 .- Car");
        Console.WriteLine("3 .- Motorcycle");
        Console.WriteLine("4 .- Train");
        Console.WriteLine("5 .- Truck");
        Console.WriteLine(" ");
        while (contador <= 10)
        {
            Console.WriteLine("Type the vehicle!");
            string vehicleType = Console.ReadLine() ?? "DefaultVehicleType";
            Vehicle? vehicle = null;

            switch (vehicleType)
            {
                case "bycicle":
                    vehicle = new Bicycle();
                    break;
                case "Motorcycle":
                    vehicle = new Motorcycle();
                    break;
                case "Car":
                    vehicle = new Car();
                    break;

                case "Truck":
                    vehicle = new Truck();
                    break;

                case "Train":
                    vehicle = new Train();
                    break;

                default:
                    Console.WriteLine("Vehicle not found!");
                    System.Threading.Thread.Sleep(2000);
                    break;
            }

            if (vehicle != null)
            {
                vehicle.VehicleSound();
                contador++;

            }
        }
    }
}