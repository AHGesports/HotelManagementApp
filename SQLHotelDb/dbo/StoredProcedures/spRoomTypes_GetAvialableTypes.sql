CREATE PROCEDURE [dbo].[spRoomTypes_GetAvialableTypes]
    @startDate Date,
	@endDate Date
AS
begin
	set nocount on;

	select t.Id,t.Title, t.Price, t.Description
from dbo.Rooms r
inner join dbo.RoomTypes t on r.RoomTypeId = t.Id
where not exists (
    select 1
    from dbo.Bookings b
    where b.RoomId = r.Id
    and ((@startDate >= b.StartDate and @startDate < b.EndDate)
         or (@endDate > b.StartDate and @endDate <= b.EndDate)
         or (@startDate <= b.StartDate and @endDate >= b.EndDate))
)
group by t.Id, t.Title, t.Price, t.Description
end
