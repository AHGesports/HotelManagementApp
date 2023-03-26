﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppClassLibrary.Models
{
    public class FullBookingModel
    {
        public int Id { get; set; }
        public int RoomId { get; set; }

        public int GuestId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool CheckedIn { get; set; }
        public decimal TotalCost { get; set; }
        
        public string RoomNumber { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

    }
}
