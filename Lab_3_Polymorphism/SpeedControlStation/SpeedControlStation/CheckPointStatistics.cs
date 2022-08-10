using SpeedControlStation.Enums;

namespace SpeedControlStation
{
    internal class CheckPointStatistics
    {
        public int SumOfSpeeds
        {
            get; set;
        }
        public int CarsCount 
        {
            get; set;
        }
        public int BusesCount
        {
            get; set;
        }

        public int TrucksCount
        {
            get; set;
        }

        public int SpeedLimitBreakersCount
        {
            get; set;
        }
        // что такое CarJackersCount?

        public int AverageSpeed
        {
            get 
            { 
                if (SumOfSpeeds == 0)
                    return 0;
                else 
                    return SumOfSpeeds/(CarsCount + BusesCount + TrucksCount); 
            }
        }

        public CheckPointStatistics()
        {
            CarsCount = 0;
            BusesCount = 0;
            TrucksCount = 0;
            SpeedLimitBreakersCount = 0;
        }

        public void RegisterVehicle(AVehicle vehicle)
        {
            SumOfSpeeds += vehicle.Speed;
            if (vehicle.Speed > 110)
            {
                SpeedLimitBreakersCount++;
            }
            switch (vehicle.VehicleBodyType)
            {
                case BodyType.Car:
                    CarsCount++;
                    break;
                case BodyType.Bus:
                    BusesCount++;
                    break;
                case BodyType.Truck:
                    TrucksCount++;
                    break;
            }
        }
    }
}