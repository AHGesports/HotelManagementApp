CREATE PROCEDURE [dbo].[spRoom_GetRoomsByType]
 @startDate Date,
 @endDate Date,
 @desiredRoomTypeId int
As
begin

select r.*
from dbo.Rooms r
inner join dbo.RoomTypes t on t.Id = r.RoomTypeId

Where @desiredRoomTypeId = t.Id

and r.Id not in(

select b.RoomId
from dbo.Bookings b
	WHERE ( @startDate < b.StartDate and @endDate > b.StartDate)
	  or ( @startDate < b.StartDate and @endDate > b.EndDate)	
	  or ( @startDate >= b.StartDate and @endDate <= b.EndDate)
	  or ( @startDate >= b.StartDate and  @endDate > b.EndDate and @startDate != b.EndDate)
	  )




end