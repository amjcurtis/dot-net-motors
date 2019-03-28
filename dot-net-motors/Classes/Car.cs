using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Car : Automobile, IStartEngine
    {
        // Overridden properties
        public override string FuelType { get; set; } = "gasoline";

        // Virtual properties
        public virtual bool SunRoof { get; set; } = false;

        // Abstract methods
        public abstract string PlayRadio();

        // Implement interface
        public virtual bool PrimeEngine()
        {
            Console.WriteLine("No need to prime engine!");
            return false;
        }
    }
}
