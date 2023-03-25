CREATE PROCEDURE [dbo].[spBookings_CheckIn]

@lastName varchar(50),
@roomNumber varchar(10)

AS
begin
update dbo.Bookings
Set [CheckedIn ] = 1
from dbo.Bookings b
inner join dbo.Rooms r on b.RoomId = r.Id
inner join dbo.Guests g on b.GuestId = g.Id
where @roomNumber = r.RoomNumber and g.LastName = @lastName


 






 end