/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (SELECT 1 FROM dbo.RoomTypes)
BEGIN
    insert into dbo.RoomTypes(Title,Description,Price)
    values('King Size Bed','A room with a King-Sized bed and a window.', 100),
    ('Two Queen Sized Bed', 'A room with two Queen-Sized beds and a window', 115),
    ('Executive Suite', 'Two rooms, each with a King-Sized bed and a window', 205);
    
END

if not exists ( SELECT 1 FROM dbo.Rooms)
BEGIN
    declare @roomId1 int;
    declare @roomId2 int;
    declare @roomId3 int;
    
    SELECT @roomId1 = Id FROM dbo.RoomTypes Where Title = 'King Size Bed';
    SELECT @roomId2 = Id FROM dbo.RoomTypes Where Title = 'Two Queen Sized Bed';
    SELECT @roomId3 = Id FROM dbo.RoomTypes Where Title = 'Executive Suite';

    insert into dbo.Rooms(RoomNumber,RoomTypeId)
    values ('101', @roomId1),
    ('102', @roomId1),
    ('201', @roomId2),
    ('202', @roomId2),
    ('301', @roomId3);

    

END