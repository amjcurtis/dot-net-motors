using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    // Concrete class
    class ToyotaTacoma : Truck
    {
        // Overridden properties
        public override int NumberOfSeats { get; set; } = 4;
        public override decimal Price { get; set; } = 28000m;

        // Overridden virtual methods
        public override bool GoOffRoading()
        {
            Console.WriteLine("Tacoma can go off-road");
            return true;
        }

        // Implemented abstract methods
        public override void Drive()
        {
            Console.WriteLine("Let's drive!");
        }

    }
}
