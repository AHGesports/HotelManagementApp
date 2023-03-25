using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebAppHotel.Pages
{
    public class BookingModel : PageModel
    {
		
			[BindProperty(SupportsGet = true)]
			public int RoomTypeId { get; set; }


			[BindProperty(SupportsGet = true)]
			[DataType(DataType.Date)]
			public DateTime StartDate { get; set; }


			[BindProperty(SupportsGet = true)]
			[DataType(DataType.Date)]
			public DateTime EndDate { get; set; }
			public void OnGet()
			{

			}


			public IActionResult OnPost()
			{
				return RedirectToPage("/Index");
			}
			
    }
}
