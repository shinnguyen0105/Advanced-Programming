using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Implement
{
    public abstract class Room
    {
        protected int ID;
        protected bool IsBooked;
        protected double Price;
        protected int Bed;

        public void AddRoom(int id, bool isbooked, double price, int bed)
        {
            this.ID = id;
            this.IsBooked = true;
            this.Price = price;
            this.Bed = bed;
        }
        
        
    }

    public class Singleroom : Room
    {
        public Singleroom(int id) : base(id)
        {
            Bed = 1;
            Price = 100;
        }

    }


    public class Doubleroom : Room
    {
        public Doubleroom(int id) : base(id)
        {
            Bed = 1;
            Price = 100;
        }
    }
}
