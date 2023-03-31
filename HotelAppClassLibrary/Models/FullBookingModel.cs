using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace HotelAppClassLibrary.Models
{
     public class FullBookingModel
     {
        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Column("RoomNumber")]
        public string RoomNumber { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("TotalCost")]
        public decimal TotalCost { get; set; }

        [Column("CheckedIn")]
        public bool CheckedIn { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Id")]
        public int Id { get; set; }
     }

}
