CREATE PROCEDURE [dbo].[spGuest_BookGuest]
 @roomId int,
 @guestId int,
 @startDate Date,
 @endDate Date,
 @totalCost money,
 @checkedIn bit

 As 

 begin
	set nocount on;


insert into dbo.Bookings(RoomId, GuestId, StartDate, EndDate, [CheckedIn ], TotalCost)  values (@roomId, @guestId, @startDate, @endDate, @checkedIn, @totalCost)





 end 