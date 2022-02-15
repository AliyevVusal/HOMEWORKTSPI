using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkPAISTask1
{
    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1Km;
        

        public Car(string brand,string color,double millage,double fuelcapacity,double currentfuel, double fuelfor1km,double yol) :base(brand,color,millage,yol)
        {
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentfuel;
            FuelFor1Km = fuelfor1km;
            Yol = yol;
        }

        public override void Drive()
        {
            if (CurrentFuel / FuelFor1Km == Yol)
            {
                CurrentFuel--;
                Millage++;
                Console.WriteLine("Sag Salamat qardash");

            }
            else
            {
                Console.WriteLine("Fuel-niz bu yola yetmiyecek");
            }
        }

    }
}
