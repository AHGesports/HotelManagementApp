using HotelAppClassLibrary.Models;

namespace HotelAppClassLibrary.Databases
{
	public interface IDatabaseData
	{
		void BookGuest(string firstName, string lastName, int desiredRoomTypeId, DateTime startDate, DateTime endDate);
		void CheckIn(string lastName, string roomNumber);
		void CheckOut(string lastName, string roomNumber);
		List<RoomTypeModel> GetAvialableRoomTypes(DateTime startDate, DateTime endDate);
		List<BookingModel> SearchForBookings(string lastName);
	}
}