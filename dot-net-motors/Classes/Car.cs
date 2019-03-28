using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class Car : Automobile
    {
        // Overridden properties
        public override string FuelType { get; set; } = "gasoline";

        // Virtual properties
        public virtual bool SunRoof { get; set; } = false;

        // Abstract methods
        public abstract string PlayRadio();
    }
}
