using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkPAISTask1
{
    abstract class Vehicle
    {
        public string Brand;

        public string Color;

        public double Millage;

        public double Yol;

        public Vehicle()
        {

        }

        public Vehicle(string brand,string color,double millage,double yol):this()
        {
            Brand = brand;
            Color = color;
            Millage = millage;
            Yol = yol;
        }

        public virtual string ShowInfo()
        {
             return $"{Brand} {Color} {Millage}";
        }

        public virtual void Drive()
            {

            } 


    }
}
