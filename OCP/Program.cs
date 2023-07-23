using OCP.Vehicles;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR) 
            {
                Car vehicle = new Car("Vermelho", 2022, 1.8, 5, 4);
            }
            else
            {
                Motorcycle vehicle = new Motorcycle("Branco", 2023, 250);
            }

            Console.ReadLine();
        }
    }
}
