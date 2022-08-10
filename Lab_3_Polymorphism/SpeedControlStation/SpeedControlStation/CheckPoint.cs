using SpeedControlStation.Vehicles;
using SpeedControlStation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedControlStation
{
    internal class CheckPoint
    {
        private CheckPointStatistics statistics;

        public CheckPoint()
        {
            statistics = new CheckPointStatistics();
        }

        public void PrintStatistics()
        {
            Console.WriteLine($"\nЛегковые автомобили: {statistics.CarsCount}");
            Console.WriteLine($"Автобусы: {statistics.BusesCount}");
            Console.WriteLine($"Грузовики: {statistics.TrucksCount}");
            Console.WriteLine($"Нарушители скорости: {statistics.SpeedLimitBreakersCount}\n");
            Console.WriteLine($"Средняя скорость потока: {statistics.AverageSpeed}");
        }

        public void RegisterVehicle(AVehicle vehicle)
        {
            statistics.RegisterVehicle(vehicle);
        }

        public void PrintRegisterInfo(AVehicle vehicle)
        {
            Console.WriteLine($"\nТип транспорта: {vehicle.VehicleBodyType.ToString()}");
            Console.WriteLine($"Номер: {vehicle.LicensePlateNumber}");
            Console.WriteLine($"Цвет: {vehicle.Color.ToString()}");
            Console.WriteLine($"Пассажир: {vehicle.HasPassenger}");
            Console.WriteLine($"Скорость {vehicle.Speed}");
            if (vehicle.Speed > 110)
            {
                Console.WriteLine("\n Перехват! \n");
            }
        }
        static void Main()
        {
            Random random = new Random();
            CheckPoint checkPoint = new CheckPoint();
            AVehicle vehicle = null;
            while (!Console.KeyAvailable)
            {
                BodyType bodyType = (BodyType)random.Next(Enum.GetNames(typeof(BodyType)).Length);
                switch (bodyType)
                {
                    case BodyType.Car:
                        vehicle = new Car();
                        break;
                    case BodyType.Bus:
                        vehicle = new Bus();
                        break;
                    case BodyType.Truck:
                        vehicle = new Truck();
                        break;

                }
                vehicle.GetSpeed();
                checkPoint.RegisterVehicle(vehicle);
                checkPoint.PrintRegisterInfo(vehicle);
                checkPoint.PrintStatistics();


                System.Threading.Thread.Sleep(5000);
            }

           
        }
    }
}
