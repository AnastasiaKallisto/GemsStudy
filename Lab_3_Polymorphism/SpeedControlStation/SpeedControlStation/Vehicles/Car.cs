using SpeedControlStation.Enums;

namespace SpeedControlStation.Vehicles
{
    internal class Car : AVehicle
    {
        public override BodyType VehicleBodyType { get; }

        public Car()
        {
            VehicleBodyType = BodyType.Car;
        }

        override public int GetSpeed()
        {
            Speed = random.Next(90, 151);
            return Speed;
        }
    }

}
