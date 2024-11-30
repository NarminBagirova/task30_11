using task30_11.hotel;

namespace task30_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    try
            //    {
            //        Room room1 = new Room("Single room", 110, 1);
            //        Room room2 = new Room("Double room", 200, 2);

            //        Hotel hotel = new Hotel("Springs");

            //        hotel.AddRoom(room1);
            //        hotel.AddRoom(room2);

            //        Console.WriteLine("Hotel rooms:");

            //        foreach (var room in hotel.rooms)
            //        {
            //            if (room != null)
            //                Console.WriteLine(room);
            //        }

            //        Console.WriteLine("\nMaking reservation for room with ID 1");
            //        hotel.MakeReservation(1);

            //        Console.WriteLine("\nAfter reservation: ");

            //        foreach (var room in hotel.rooms)
            //        {
            //            if (room != null)
            //                Console.WriteLine(room);
            //        }

            //        Console.WriteLine("\nMaking reservation for room with ID 1 again");
            //        hotel.MakeReservation(1);

            //    }
            //    catch (NotAvailableException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //

            Car car1 = new Car("Mercedes", "E200", CarType.Sedan);
            Car car2 = new Car("BMW", "F10", CarType.SUV);

            Console.WriteLine(car1);
            Console.WriteLine(car2);

        }
    }

}