using SpeedControlStation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpeedControlStation
{
    internal abstract class AVehicle
    {
        public static Random random = new Random();

        public virtual int Speed { get; set; }
        public virtual int LicensePlateNumber { get; }
        public virtual VehicleColor Color { get; }

        public virtual BodyType VehicleBodyType { get; }

        public virtual bool HasPassenger { get; }

        public AVehicle()
        {
            Speed = 0;
            LicensePlateNumber = random.Next(100, 1000); // можно задать константами
            Color = (VehicleColor)random.Next(Enum.GetNames(typeof(VehicleColor)).Length);
            HasPassenger = 1 == random.Next(2);
        }

        public abstract int GetSpeed();
    }

}
