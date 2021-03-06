﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    // Concrete class
    public class HondaCrv : Car, IStartEngine
    {
        // Overridden properties
        public override int NumberOfSeats { get; set; } = 5;
        public override decimal Price { get; set; } = 24000m;
        public override bool SunRoof { get; set; } = true;

        // Overridden virtual methods
        public override void Drive()
        {
            Console.WriteLine("Let's drive our Honda!");
        }

        public override string PlayRadio()
        {
            return "Got me some tunes!";
        }

        // Implement interface
        public override bool PrimeEngine()
        {
            Console.WriteLine("Definitely no need to prime engine for CR-V!");
            return false;
        }
    }
}
