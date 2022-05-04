USE ContosoEventsDB
GO
create procedure dbo.Insert_User_Details 
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
BEGIN
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
END


GO
EXEC dbo.Insert_User_Details  'Sameera123','Sameera','shaik','Sameera123@gmail.com',9966059938,'Sameera123','Female','Vijayawada','Gannavaram,Vijaywada 521286'
EXEC dbo.Insert_User_Details  'Asifa08','Asifa','shaik','Asifa123@gmail.com',7382358265,'Asifa123','Female','Narasaraopet','Narasaraopet,Guntur 522601'
SELECT * FROM [dbo].[User_Details]