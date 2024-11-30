using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30_11.hotel
{
    public class Room
    {
        private static int _roomCounter = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; } = true;


        public Room(string name, double price, int capacity)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty.");
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.");
            if (capacity <= 0)
                throw new ArgumentException("Person capacity must be greater than zero.");

            Id = _roomCounter++;
            Name = name;
            Price = price;
            Capacity = capacity;
        }

        public string ShowInfo()
        {
            return $"{Name} - {Price} - {Capacity} - {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }



    }
}
