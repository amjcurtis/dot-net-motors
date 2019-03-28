using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    public abstract class StationWagon : Car, ITransmission
    {
        // Overridden properties
        public override int NumberOfSeats { get; set; } = 5;

        public void OpenBackHatch()
        {
            Console.WriteLine("Pop the hatch!");
        }

        // Implement interface
        public virtual int Speeds { get; set; } = 5;

        public abstract string Transmission();
    }
}
