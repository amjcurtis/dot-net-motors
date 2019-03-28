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
            Console.WriteLine(" ");
            Console.WriteLine("ToyotaTacoma class");
            Console.WriteLine(" ");

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
            Console.WriteLine(" ");
            Console.WriteLine("MackSemi class");
            Console.WriteLine(" ");

            MackSemi semi = new MackSemi();

            Console.WriteLine(semi.NumberOfSeats);
            Console.WriteLine(semi.Price);
            semi.HaulTrailer(2);
            semi.GoOffRoading();
            Console.WriteLine(semi.FuelType);
            semi.Drive();

            semi.PrimeEngine();
            
            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine("HondaCrv class");
            Console.WriteLine(" ");

            HondaCrv crv = new HondaCrv();

            Console.WriteLine(crv.NumberOfSeats);
            Console.WriteLine(crv.Price);
            Console.WriteLine(crv.FuelType);
            Console.WriteLine(crv.PlayRadio());
            crv.Drive();

            crv.PrimeEngine();

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine("VolvoV70class");
            Console.WriteLine(" ");

            VolvoV70 v70 = new VolvoV70();

            Console.WriteLine(v70.NumberOfSeats);
            Console.WriteLine(v70.SunRoof);

            v70.Drive();
            v70.OpenBackHatch();
            v70.PlayRadio();

            // Interface method
            v70.Transmission();

            // Interface property
            Console.WriteLine(v70.Speeds);

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");
            Console.WriteLine(" ");
            Console.WriteLine("SubaruLegacy class");
            Console.WriteLine(" ");

            SubaruLegacy subby = new SubaruLegacy();

            Console.WriteLine(subby.CarriesPeople);
            Console.WriteLine(subby.Price);
            Console.WriteLine(subby.NumberOfSeats);
            Console.WriteLine(subby.PlayRadio());
            subby.OpenBackHatch();

            // Interface method
            subby.Transmission();
            Console.WriteLine(subby.Speeds);

            //////////////////////////////////////////////////
            Console.WriteLine("\nHit Enter to exit program");
            Console.ReadLine();
        }
    }
}
