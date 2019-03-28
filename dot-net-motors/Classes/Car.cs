using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    abstract class Car : Automobile
    {
        // Abstract properties
        public override string FuelType { get; set; } = "gasoline";

        // Virtual properties
        public virtual string SunRoof() {
            return "Got me a sun roof!";
        }

        // Abstract methods
        public abstract string PlayRadio();
    }
}
