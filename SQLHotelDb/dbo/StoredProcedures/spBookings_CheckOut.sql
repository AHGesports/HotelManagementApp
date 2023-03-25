CREATE PROCEDURE [dbo].[spBookings_CheckOut]

@lastName varchar(50),
@roomNumber varchar(10)

AS
begin
update dbo.Bookings
Set [CheckedIn ] = 0
from dbo.Bookings b
inner join dbo.Rooms r on b.RoomId = r.Id
inner join dbo.Guests g on b.GuestId = g.Id
where @roomNumber = r.RoomNumber and g.LastName = @lastName


 






 end