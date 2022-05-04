USE ContosoEventsDB
GO
Alter procedure dbo.Insert_User_Details 

( 
@User_UserName   varchar(30),
@User_FirstName  varchar(30),
@User_LastName   varchar(30),
@User_Email      varchar(30),
@User_Contact    bigint,
@User_Password   varchar(30),
@User_Gender     varchar(10),
@User_Country    varchar(30),
@User_Address    varchar(50)
)

AS
 BEGIN TRY
INSERT INTO [dbo].[User_Details]
(
User_UserName,
User_FirstName,
User_LastName,
User_Email,
User_Contact,
User_Password,
User_Gender,
User_Country,
User_Address    
)
VALUES(@User_UserName,@User_FirstName,@User_LastName,@User_Email,@User_Contact,@User_Password,@User_Gender,@User_Country,@User_Address)
declare @Msg varchar(max)
 SET @Msg='User Details Inserted Successfully.'
 Print @Msg
END TRY

BEGIN CATCH

     SET @Msg='User Details Insertion Failed .'
	 Print @Msg

END CATCH




GO
EXEC dbo.Insert_User_Details  'Sameera13','Sameera','shaik','Sameera13@gmail.com',9966059939,'Sameera123','Female','Vijayawada','Gannavaram,Vijaywada 521286'
EXEC dbo.Insert_User_Details  'Asifa118','Asifa','shaik','Asifa123@gmail.com',7382358265,'Asifa123','Female','Narasaraopet','Narasaraopet,Guntur 522601'
SELECT * FROM [dbo].[User_Details]


ALTER procedure dbo.Update_User_Details 

(
@User_Id int,
@User_UserName   varchar(30),
@User_FirstName  varchar(30),
@User_LastName   varchar(30),
@User_Email      varchar(30),
@User_Contact    bigint,
@User_Password   varchar(30),
@User_Gender     varchar(10),
@User_Country    varchar(30),
@User_Address    varchar(50)
)

AS
 BEGIN TRY
UPDATE  [dbo].[User_Details]
SET 
User_UserName=@User_UserName,
User_FirstName=@User_FirstName,
User_LastName=@User_LastName,
User_Email=@User_Email,
User_Contact=@User_Contact,
User_Password=@User_Password,
User_Gender=@User_Gender,
User_Country=@User_Country,
User_Address=@User_Address 

WHERE User_Id=@User_Id

declare @Msg varchar(max)
SET @Msg='User Details Updated Successfully.'
Print @Msg

END TRY

BEGIN CATCH

SET @Msg='User Details Updation Failed .'
Print @Msg

END CATCH
GO

EXEC dbo.Update_User_Details 1,'Sameera1233','Sameera','shaik','Sameera13@gmail.com',9966059939,'Sameera123','Female','Vijayawada','Gannavaram,Vijaywada 521286'
EXEC dbo.Update_User_Details  'Asifa118','Asifa','shaik','Asifa123@gmail.com',7382358265,'Asifa123','Female','Narasaraopet','Narasaraopet,Guntur 522601'

select * from [dbo].[User_Details]


ALTER procedure dbo.Delete_User_Details 

(
@User_Id int

)

AS
 BEGIN TRY
 declare @Msg varchar(max)
DELETE FROM  [dbo].[User_Details] WHERE User_Id=@User_Id


SET @Msg='User Details Deleted Successfully.'
Print @Msg

END TRY

BEGIN CATCH

SET @Msg='User Details Not Deleted...'
Print @Msg

END CATCH

exec dbo.Delete_User_Details 5

select * from dbo.User_Details


Alter procedure dbo.Insert_Events_Details
( 
@Event_Name      varchar(50),
@Event_Type      varchar(30),
@Event_Location  varchar(30),
@Event_Startdate   varchar(30),
@Event_Enddate     varchar(30),
@Event_AvilableTickets  int,
@Event_Status  varchar(10),
@Event_Ticket_Catageory varchar(30)

)
AS
BEGIN TRY
SET DATEFORMAT DMY

INSERT INTO [dbo].[Events_Details]
(
Event_Name ,
Event_Type ,
Event_Location,
Event_Startdate,
Event_Enddate ,
Event_AvilableTickets,
Event_Status,
Event_Ticket_Catageory    
)
VALUES
(
@Event_Name ,
@Event_Type ,
@Event_Location,
@Event_Startdate,
@Event_Enddate ,
@Event_AvilableTickets,
@Event_Status,
@Event_Ticket_Catageory
)

declare @Msg varchar(max)
 SET @Msg='Events_Details Inserted Successfully.'
 Print @Msg
END TRY

BEGIN CATCH

     SET @Msg='Events_Details Insertion Failed .'
	 Print @Msg

END CATCH

GO
EXEC dbo.Insert_Events_Details 'Formula-1','Sport','Banglore','04-03-2022' ,'28-03-2022',1500 ,'Active','Gold'
EXEC dbo.Insert_Events_Details 'Formula-1','Sport','Banglore','04-03-2022' ,'28-03-2022',1500 ,'Active','Platinum'

EXEC dbo.Insert_Events_Details 'New Year-Bash','Music','Hyderabad','08-03-2022' ,'22-04-2022',2500 ,'Active','Gold'
EXEC dbo.Insert_Events_Details 'Violin','Music','Chennai','12-03-2022' ,'27-05-2022',3500 ,'Active','Platinum'

Alter procedure dbo.Insert_Booking_Details
( 
@Booking_Event_Id          int,
@Booking_Amount            varchar(30),
@Booking_User_Id           int,
@Booking_NumberofTickets   int,
@Booking_Single_UnitPrice  varchar(30)

)
AS
BEGIN TRY
INSERT INTO [dbo].[Booking_Details]
(
Booking_Event_Id ,         
Booking_Amount ,
Booking_User_Id ,
Booking_NumberofTickets ,
Booking_Single_UnitPrice   
)
VALUES(@Booking_Event_Id,@Booking_Amount,@Booking_User_Id,@Booking_NumberofTickets,@Booking_Single_UnitPrice)


declare @Msg varchar(max)
 SET @Msg='Booking_Details Inserted Successfully.'
 Print @Msg

END TRY

BEGIN CATCH

     SET @Msg='Booking_Details Insertion Failed .'
	 Print @Msg

END CATCH



select * from [dbo].[User_Details]
select * from [dbo].[Events_Details]
select * from [dbo].Booking_Details
select * from [dbo].[Payment_Details]

 Go

Exec dbo.Insert_Booking_Details 101,'3000',1,6,'500'

Alter procedure dbo.Insert_Payment_Details
( 
@Payment_User_Id   int,
@Payment_Event_Id  int,
@Payment_Amount  varchar(30)
)
AS
BEGIN TRY
INSERT INTO [dbo].[Payment_Details]
(
Payment_User_Id ,         
Payment_Event_Id ,
Payment_Amount 
 )
VALUES(@Payment_User_Id,@Payment_Event_Id,@Payment_Amount)

declare @Msg varchar(max)
 SET @Msg='Payment_Details Inserted Successfully.'
 Print @Msg

END TRY

BEGIN CATCH

     SET @Msg='Payment_Details Insertion Failed .'
	 Print @Msg

END CATCH

Exec dbo.Insert_Payment_Details 8,101,'3000'
Exec dbo.Insert_Payment_Details 1,101,'6000'


select * from [dbo].[User_Details]
select * from [dbo].[Events_Details]
select * from [dbo].Booking_Details
select * from [dbo].[Payment_Details]

CREATE PROCEDURE dbo.View_User_Details
as
BEGIN
 select * from [dbo].[User_Details]
END;
CREATE PROCEDURE dbo.View_Booking_Details
as
BEGIN
 select * from [dbo].[Booking_Details]
END;
CREATE PROCEDURE dbo.View_Events_Details
as
BEGIN
 select * from [dbo].[Events_Details]
END;
CREATE PROCEDURE dbo.View_Payment_Details
as
BEGIN
 select * from [dbo].[Payment_Details]
END;




exec dbo.View_User_Details
exec dbo.View_Payment_Details
exec dbo.View_Booking_Details
exec dbo.View_Events_Details
