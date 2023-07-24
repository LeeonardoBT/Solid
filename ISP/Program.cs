using ISP.Vehicles;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("vermelho", 2023, 1.8, 5, 4);
            Motorcycle motorcycle = new Motorcycle("branca", 2022, 600);

            Console.ReadLine();
        }
    }
}
