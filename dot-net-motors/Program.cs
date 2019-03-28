using System;
using dot_net_motors.Classes;

namespace dot_net_motors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Main method!");

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            ToyotaTacoma tacoma = new ToyotaTacoma();

            tacoma.Drive();
            tacoma.HaulTrailer(1);
            
            // Tests that overridden boolean property works
            if (tacoma.GoOffRoading())
            {
                Console.WriteLine("Offroading method works!");
            }

            Console.WriteLine(tacoma.Price);
            Console.WriteLine(tacoma.NumberOfSeats);

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            MackSemi semi = new MackSemi();

            Console.WriteLine(semi.NumberOfSeats);
            Console.WriteLine(semi.Price);
            semi.HaulTrailer(2);
            semi.GoOffRoading();
            Console.WriteLine(semi.FuelType);
            semi.Drive();


            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");
            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");
            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            //////////////////////////////////////////////////
            Console.WriteLine("\nHit Enter to exit program");
            Console.ReadLine();
        }
    }
}
