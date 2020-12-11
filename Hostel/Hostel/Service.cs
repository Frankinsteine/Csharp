using System;
using System.Collections.Generic;
using System.Text;

namespace Hostel
{
    class Service
    {
        public Guest Guest;
        public Services Services;
        public Room Room;
        public decimal Cost;
        public DateTime Date;
        
        public Service (Guest guest, Services services, Room room, decimal cost)
        {
            guest.Balance -= cost;
            Guest = guest;
            Services = services;
            Room = room;
            Cost = cost;
            Date = DateTime.Now;
        }



    }
}
