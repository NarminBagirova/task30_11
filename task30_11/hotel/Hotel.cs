using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task30_11.hotel
{
    public class Hotel
    {
        public string Name { get; set; }
        public Room[] rooms = new Room[0];
        public Hotel(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Hotel name cannot be null or empty");
            Name = name;

        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Room id cannot be null");
            }

            Room room = Array.Find(rooms, r => r != null && r.Id == roomId);

            if (room == null)
            {
                throw new NotAvailableException("Room not found.");
            }

            if (!room.IsAvailable)
            {
                throw new NotAvailableException("The room is already reserved");
            }

            room.IsAvailable = false;
            Console.WriteLine($"Room {room.Name} has been reserved.");
        }

        public void ShowHotelInfo()
        {
            Console.WriteLine($"Hotel name: {Name}");
            Console.WriteLine("Rooms:");

            foreach (var room in rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}
