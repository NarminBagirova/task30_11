using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30_11
{
    public class Car
    {
        private static int _idCounter = 1;
        public int Id { get; private set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }

        public Car(string brand, string model, CarType type)
        {
            Id = _idCounter++;
            Brand = brand;
            Model = model;
            Type = type;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Brand: {Brand}, Model: {Model}, Type: {Type}";
        }
    }
}
