using System;

namespace OCP.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {this.color}, {this.year} e {this.engine} cilindradas.");
            StartVehicle();
        }
    }
}
