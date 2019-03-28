using System;
using dot_net_motors.Classes;

namespace dot_net_motors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Main method!");

            ToyotaTacoma tacoma = new ToyotaTacoma();

            tacoma.Drive();
            
            // Tests that overridden boolean property works
            if (tacoma.GoOffRoading())
            {
                Console.WriteLine("Offroading method works!");
            }

            Console.WriteLine(tacoma.Price);
            Console.WriteLine(tacoma.NumberOfSeats);

            Console.WriteLine("\nHit Enter to exit program");
            Console.ReadLine();
        }
    }
}
