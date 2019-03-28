using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    class ToyotaTacoma : Truck
    {
        // Override properties
        public override int NumberOfSeats { get; set; } = 4;
        public override decimal Price { get; set; } = 28000m;

        // Override methods
        public override bool GoOffRoading()
        {
            return true;
        }

        // Implemented abstract methods
        public override void Drive()
        {
            Console.WriteLine("Let's drive!");
        }

    }
}
