using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercise_10
{
    class Reservation
    {
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int Room { get; set; }
        public String GuestName { get; set; }

        public String GuestGenre { get; set; }

        public Reservation (string guestname, int room, string guestgenre)
        {
            this.GuestName = guestname;
            this.Room = room;
            this.GuestGenre = guestgenre;
        }
    }
}
