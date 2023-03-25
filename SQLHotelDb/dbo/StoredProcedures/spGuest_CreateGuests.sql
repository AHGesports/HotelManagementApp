CREATE PROCEDURE [dbo].[spGuest_CreateGuests]
	@firstName nvarchar(50), 
	@lastName nvarchar(50)
AS
begin
 set nocount on;
 if not exists (Select 1 from dbo.Guests where FirstName = @firstName and LastName = @lastName)

 insert into dbo.Guests(FirstName, LastName)  values (@firstName, @lastName)

 select top 1 g.Id, g.FirstName,g.LastName
 from dbo.Guests g
 where g.FirstName = @firstName and g.LastName = @lastName
end
