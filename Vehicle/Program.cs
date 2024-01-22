using System;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car car = new Car("Mercedes-Benz S-Class", 2012,"бензин",8.5);
            ElectricCar electricCar = new ElectricCar("Tesla Model S",2023,"електрика",100);

            car.Engine();
            car.CarCalculateFuelConsumption(); 
            Console.WriteLine();

            electricCar.Electric();
            electricCar.ElectricCarCalculateFuelConsumption(); 
            Console.WriteLine();
        }
    }
    class Vehicle
    {

        public String Brand;
        public int Year;
        public String FuelType;
        public double distans = 150;
        public double FuelEfficiency;
        public double BatteryCapacity;


        public Vehicle(string brand, int year, string fuelType, double fuelEfficiency, double batteryCapacity)
        {
            this.Brand = brand;
            this.Year = year;
            this.FuelType = fuelType;
            this.FuelEfficiency = fuelEfficiency;
            this.BatteryCapacity = batteryCapacity;
        }

        public void Details()
        {
            Console.WriteLine($"Марка: {Brand}\nРік випуску: {Year}\nТип пального:{FuelType}");
        }

        public void CarCalculateFuelConsumption()
        {
            double fuelconsumption = (FuelEfficiency * distans) / 100;
            Console.WriteLine($"Розхід пального на {distans}км = {fuelconsumption}л.");    
        }
        public void ElectricCarCalculateFuelConsumption()
        {
            double energyconsumption = BatteryCapacity/distans;



            Console.WriteLine($"Розхід заряду батареї на {distans}км = {energyconsumption}кВт*год.");
        }

    }

    class Car : Vehicle
    {
        public double FuelEfficiency;

        public Car(string brand, int year, string fuelType, double fuelEfficiency) :base(brand,year,fuelType,fuelEfficiency,0)
        {
           this.FuelEfficiency= fuelEfficiency;
        }

        public void Engine()
        {
            Details();
            Console.WriteLine($"Витрати пального {FuelEfficiency} на  100км");
        }
    }
    class ElectricCar : Vehicle
    {
        public double BatteryCapacity;

        public ElectricCar(string brand, int year, string fuelType,double batteryCapacity) : base(brand, year,fuelType,0, batteryCapacity)
        {    
            this.BatteryCapacity= batteryCapacity;
        }
        public void Electric()
        {
            Details();
            Console.WriteLine($"Потужність батареї {BatteryCapacity}кВт*год");
        }
    }
}
