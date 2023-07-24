using System;

namespace ISP.Vehicles
{
    class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;   
            this.engine = engine;

            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Configurada mota {color} de {year} com motor {engine} cilindradas.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
