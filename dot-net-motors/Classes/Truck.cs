using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    abstract class Truck : Automobile
    {
        // Overridden properties
        public override decimal Price { get; set; } = 30000m;
        public override string FuelType { get; set; } = "diesel";
        
        // Virtual methods
        public virtual bool HaulTrailer(int numOfTrailers)
        {
            if (numOfTrailers > 0)
            {
                return true;
            }
            return false;
        }

        public virtual bool GoOffRoading()
        {
            Console.WriteLine("Goin' off-roading!");
            return true;
        }
    }
}
