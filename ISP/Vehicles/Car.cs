using System;

namespace ISP.Vehicles
{
    class Car : IVehicleCar
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Configurado carro {color} de {year}, motor {engine}, com {seats} assentos e {doors} portas.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
