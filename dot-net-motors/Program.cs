﻿using System;
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

            semi.PrimeEngine();
            
            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            HondaCrv crv = new HondaCrv();

            Console.WriteLine(crv.NumberOfSeats);
            Console.WriteLine(crv.Price);
            Console.WriteLine(crv.FuelType);
            Console.WriteLine(crv.PlayRadio());
            crv.Drive();

            crv.PrimeEngine();

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            VolvoV70 v70 = new VolvoV70();

            Console.WriteLine(v70.NumberOfSeats);
            Console.WriteLine(v70.SunRoof);

            v70.Drive();
            v70.OpenBackHatch();
            v70.PlayRadio();

            //////////////////////////////////////////////////
            Console.WriteLine("////////////////////////");

            SubaruLegacy subby = new SubaruLegacy();

            Console.WriteLine(subby.CarriesPeople);
            Console.WriteLine(subby.Price);
            Console.WriteLine(subby.NumberOfSeats);
            Console.WriteLine(subby.PlayRadio());
            subby.OpenBackHatch();

            //////////////////////////////////////////////////
            Console.WriteLine("\nHit Enter to exit program");
            Console.ReadLine();
        }
    }
}
