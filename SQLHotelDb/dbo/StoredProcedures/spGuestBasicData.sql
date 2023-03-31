CREATE PROCEDURE [dbo].[spGuestBasicData]
	@lastName nvarchar(50)
	
AS
begin
select b.Id, g.FirstName, g.LastName 
from dbo.Guests g
inner join Bookings b on g.Id = b.GuestId
where g.LastName = @lastName
end