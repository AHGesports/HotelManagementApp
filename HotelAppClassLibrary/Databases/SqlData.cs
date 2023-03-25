using HotelAppClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppClassLibrary.Databases
{
	public class SqlData : IDatabaseData
	{
		private readonly string _connectioString;
		private readonly ISqlDataAccess _db;
		private const string connectionStringName = "SqlHotelDbAzure";

		public SqlData(ISqlDataAccess db)
		{
			_db = db;
		}



		public List<RoomTypeModel> GetAvialableRoomTypes(DateTime startDate, DateTime endDate)
		{
			return _db.LoadData<RoomTypeModel, dynamic>("dbo.spRoomTypes_GetAvialableTypes",
												new { startDate, endDate },
												connectionStringName,
												true).ToList();
		}

		public void BookGuest(string firstName, string lastName, int desiredRoomTypeId, DateTime startDate, DateTime endDate)
		{
			GuestModel guest = _db.LoadData<GuestModel, dynamic>("dbo.spGuest_CreateGuests",
																new { firstName, lastName },
																connectionStringName,
																true).First();
			RoomModel bookedRoom = _db.LoadData<RoomModel, dynamic>("dbo.spRoom_GetRoomsByType",
																	new { startDate, endDate, desiredRoomTypeId },
																	connectionStringName,
																	true).First();

			TimeSpan a = endDate.Subtract(startDate);
			decimal totalCost = a.Days * 100;






			_db.SaveData("dbo.spGuest_BookGuest",
				new { roomId = bookedRoom.Id, guestId = guest.Id, startDate = startDate, endDate = endDate, checkedIn = 0, totalCost = totalCost },
				connectionStringName,
				true);



		}


		public List<BookingModel> SearchForBookings(string lastName)
		{
			return _db.LoadData<BookingModel, dynamic>("dbo.spBookings_SearchByName",
				new { lastName },
				connectionStringName,
				true);
		}

		public void CheckIn(string lastName, string roomNumber)
		{
			_db.SaveData("dbo.spBookings_CheckIn",
						new { lastName, roomNumber },
						connectionStringName,
						true);
		}


		public void CheckOut(string lastName, string roomNumber)
		{
			_db.SaveData("dbo.spBookings_CheckOut",
						new { lastName, roomNumber },
						connectionStringName,
						true);
		}
		// Models : IdModel , RoomType, Room, BasicGuestModel, BookingModel









	}

}
