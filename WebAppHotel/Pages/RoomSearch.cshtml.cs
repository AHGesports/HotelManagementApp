using HotelAppClassLibrary.Databases;
using HotelAppClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace WebAppHotel.Pages
{
    public class RoomSearchModel : PageModel
    {

        private readonly IDatabaseData _db;


        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [BindProperty(SupportsGet = true)]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [BindProperty(SupportsGet = true)]
        public bool SearchButtonWasPressed { get; set; } = false;


        public List<RoomTypeModel> AvialableRoomTypes { get; set; }
         
        public RoomSearchModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
            if (SearchButtonWasPressed)
            {
                    
                    AvialableRoomTypes = _db.GetAvialableRoomTypes(StartDate, EndDate);
                 
            }
        }

        public IActionResult OnPost()
        {  
            return RedirectToPage(new { SearchButtonWasPressed = true });
        }

        


    }
}
