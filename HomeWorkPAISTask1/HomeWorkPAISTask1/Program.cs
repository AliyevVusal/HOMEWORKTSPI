using System;

namespace HomeWorkPAISTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masininizin brandin daxil edin!");
            string brand = Console.ReadLine();
            Console.WriteLine("Masininizin rengin daxil edin!");
            string color = Console.ReadLine();
            Console.WriteLine("Masininizin Km ne qederdir daxil edin!");
            int.TryParse(Console.ReadLine(), out int millage);
            //Console.WriteLine("Masininizin MAXBenzin daxil edin!");
            //double.TryParse(Console.ReadLine(), out double fuelcapacity);
            //Console.WriteLine("Masininizin Olan Benzin daxil edin!");
            //double.TryParse(Console.ReadLine(), out double currentfuel);
            //Console.WriteLine("Masininizin Neqeder yandirir daxil edin!");
            //double.TryParse(Console.ReadLine(), out double fuelfor1km);
            Console.WriteLine("Gedeceyiniz yol miqdari");
            double.TryParse(Console.ReadLine(), out double yol);

            //Car car1 = new Car(brand, color, millage, fuelcapacity, currentfuel, fuelfor1km,yol);


            //car1.Drive();

            Byclecs bike1 = new Byclecs(brand,color,millage,yol);
            Console.WriteLine("Bike");
            bike1.Drive();

        }
    }
}
