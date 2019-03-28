using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    abstract class Automobile
    {
        // Abstract properties
        public abstract int NumberOfSeats { get; set; }
        public abstract decimal Price { get; set; }
        public abstract string FuelType { get; set; }

        // Virtual properties
        public bool CarriesPeople { get; set; }

        // Abstract methods
        public abstract void Drive();
    }
}
