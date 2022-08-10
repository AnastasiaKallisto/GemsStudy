using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedControlStation.Enums;

namespace SpeedControlStation.Vehicles
{
    internal class Bus : AVehicle
    {
        public override BodyType VehicleBodyType { get; }

        public Bus()
        {
            VehicleBodyType = BodyType.Bus;
        }

        override public int GetSpeed()
        {
            Speed = random.Next(80, 110);
            return Speed;
        }
    }
}
