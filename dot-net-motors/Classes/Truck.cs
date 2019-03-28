using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Truck : Automobile
    {
        // Overridden properties
        public override decimal Price { get; set; } = 30000m;
        public override string FuelType { get; set; } = "diesel";
        
        // Virtual methods
        public virtual bool HaulTrailer(int numOfTrailers)
        {
            if (numOfTrailers > 0)
            {
                Console.WriteLine($"Got me {numOfTrailers} trailer(s)!");
                return true;
            }
            Console.WriteLine("No trailers for me.");
            return false;
        }

        public virtual bool GoOffRoading()
        {
            Console.WriteLine("Goin' off-roading!");
            return true;
        }
    }
}
