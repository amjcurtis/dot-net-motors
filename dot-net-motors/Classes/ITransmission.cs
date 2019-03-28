using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    interface ITransmission
    {
        // Property
        int Speeds { get; set; }

        // Method
        string Transmission();
    }
}
