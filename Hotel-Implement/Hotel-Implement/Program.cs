using System;
using System.Collections.Generic;

namespace Hotel_Implement
{
    public class Hotel
    {
        public string Name;
        public string Address;
        public List<Room> rooms;

        public bool CheckBooked(Room room)
        {
            if ( room.IsBooked == false)
            {
                Console.WriteLine("Room is active");
                return true;
            }
            else return false;
        }
        public Hotel()
        {
            rooms = new List<Room>();
        }
        public void AddSingleRoom(int id)
        {
            rooms.Add(new Singleroom(id));
        }
        public void AddDoubleRoom(int id)
        {
            rooms.Add(new Doubleroom(id));
        }
    }
    public class Reservation
    {
        public int ID;
        Guest guest;
        Room room;
    }
    public class Guest
    {
        public List<string> Search(Hotel hotel)
        {
            int n = 1;
            List<String> listroom = new List<string>();
            foreach (Room item in hotel.rooms)
            {
                if (item.IsBooked == true)
                {
                    Console.WriteLine("{1}: Room {2}", n, item.ID);
                    n++;
                }
            }
            return listroom;
        }
        public string Name;
        public int Age;
        public string Email;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
