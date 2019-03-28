using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    // Concrete class
    public class MackSemi : Truck
    {
        // Overridden properties
        public override int NumberOfSeats { get; set; } = 3;
        public override decimal Price { get; set; } = 65000m;

        // Overridden virtual methods
        public override bool GoOffRoading()
        {
            Console.WriteLine("No off-roading for semis!");
            return false;
        }

        // Implemented abstract methods
        public override void Drive()
        {
            Console.WriteLine("Semi is driving!");
        }
    }
}
