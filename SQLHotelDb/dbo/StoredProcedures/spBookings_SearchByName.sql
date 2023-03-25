CREATE PROCEDURE [dbo].[spBookings_SearchByName]
	
   @lastName varchar(50)

AS
begin
 set nocount on;
select [b].[StartDate], [b].[EndDate], [r].[RoomNumber],[t].[Title], [t].[Description], [t].[Price], [b].[TotalCost], [b].[CheckedIn ]
from dbo.Guests g 
inner join dbo.Bookings b on g.id = b.GuestId
inner join dbo.Rooms r on b.RoomId = r.Id
inner join dbo.RoomTypes t on r.RoomTypeId = t.Id
Where g.LastName = @lastName;
end