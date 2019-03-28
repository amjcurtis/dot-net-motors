using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    // Concrete class
    public class VolvoV70 : StationWagon
    {
        // Overridden properties
        public override decimal Price { get; set; } = 38000m;
        public override bool SunRoof { get; set; } = true;

        // Overridden methods
        public override void Drive()
        {
            Console.WriteLine("Volvo can drive!");
        }

        public override string PlayRadio()
        {
            return "Volvo plays tunes!";
        }

        // Implement interface
        public override int Speeds { get; set; } = 6;

        public override string Transmission()
        {
            return "I, Volvo V70, have a belt-driven transmission.";
        }
    }
}
