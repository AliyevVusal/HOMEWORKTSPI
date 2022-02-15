using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkPAISTask1
{
    class Byclecs : Vehicle
    {

        public Byclecs(string brand, string color, double millage, double yol):base(brand,color,millage,yol)
        {


        }

        public override void Drive()
        {
            for (int i = 0; i < Yol; i++)
            {
                Millage++;


            }
            Console.WriteLine(Millage);
        }
    }
}
