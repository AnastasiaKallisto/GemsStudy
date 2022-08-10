using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeedControlStation.Enums;

namespace SpeedControlStation.Vehicles
{
    internal class Truck : AVehicle
    {
        public override BodyType VehicleBodyType { get; }

        public Truck()
        {
            VehicleBodyType = BodyType.Truck;
        }

        override public int GetSpeed()
        {
            Speed = random.Next(70, 100);
            return Speed;
        }
    }
}
