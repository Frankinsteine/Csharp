using System;
using System.Collections.Generic;
using System.Text;

namespace Hostel
{
    class Settling
    {
        public Room Room;
        public Guest Guest;
        public DateTime Date = DateTime.Now;
        public decimal Cost;

        public Settling (Room room, Guest guest, decimal cost)
        {
            guest.Balance -= cost;
            Guest = guest;
            Room = room;
            Cost = cost;
        }
    }
}
