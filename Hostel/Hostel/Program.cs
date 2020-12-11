using System;

namespace Hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            room.Number = 1;
            Services clean = new Services()
            {
                Name = "Clean"
            };
            Guest vitalik = new Guest();
            vitalik.Balance = 1000;
            Settling settling = new Settling(room, vitalik, 200);
            Console.WriteLine(vitalik.Balance);
            Service service = new Service(vitalik, clean, room, 100);
            Console.WriteLine(vitalik.Balance);



        }
    }
}
