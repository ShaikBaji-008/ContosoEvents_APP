USE ContosoEventsDB
--User Table Insertion--
Insert into [dbo].[User_Details] values
( 
'ShaikBaji008',
'Baji',
'Shaik',
'shaikbaji008@gmail.com',
8886051451,
'shaikbaji008',
'male',
'india',
'Narasaraopet Guntur AP -522601'
)
Insert into [dbo].[User_Details] values
( 
'ShaikSameera008',
'Sameera',
'Shaik',
'shaiksameera008@gmail.com',
9966059938,
'shaiksameera008',
'female',
'india',
'Narasaraopet Guntur AP -522601'
)
select * from [dbo].[User_Details]

--Event Table Insertion

Insert into [dbo].[Events_Details] values
( 
'Formula-1',
'Sport',
'Banglore',
'2022-03-03',
'2022-03-28',
5000,
'Active',
'Platinum'
)
Insert into [dbo].[Events_Details] values
( 
'Concert-Flute',
'Music',
'Banglore',
'2022-03-03',
'2022-03-28',
1000,
'Active',
'Gold'
)


select * from [dbo].[User_Details]
select * from [dbo].[Events_Details]
select * from [dbo].Booking_Details
select * from [dbo].[Payment_Details]
--Event Table Insertion
insert into [dbo].Booking_Details values
( 
  101,
  2500,
  6,
  5,
  500
)
insert into [dbo].Booking_Details values
( 
  106,
  2500,
  6,
  5,
  500
)
insert into [dbo].Booking_Details values
( 
  101,
  3000,
  1,
  6,
  500
)
insert into [dbo].Booking_Details values
( 
  106,
  3000,
  1,
  6,
  500
)
--Payment Table Insertion

insert into [dbo].[Payment_Details](Payment_User_Id,Payment_Event_Id,Payment_Amount) values
(1,101,6000),(1,106,6000),(6,101,5000),(6,106,5000)
insert into [dbo].[Payment_Details] values(1,101,3000),(6,106,6500)

--StoreProcedures for User_Details Inserion
Insert into [dbo].[User_Details] values
( 
'ShaikBaji008',
'Baji',
'Shaik',
'shaikbaji008@gmail.com',
8886051451,
'shaikbaji008',
'male',
'india',
'Narasaraopet Guntur AP -522601'
)
select * from [dbo].[User_Details]


UPDATE  [dbo].[User_Details]
SET 
User_UserName='Sameera1233',
User_FirstName='Sameera',
User_LastName='shaik',
User_Email='Sameera123@gmail.com',
User_Contact=9966059933,
User_Password='Sameera123',
User_Gender='Female',
User_Country='Vijayawada',
User_Address='Gannavaram,Vijaywada 521286' 

WHERE User_Id=1
select * from [dbo].[User_Details]
EXEC dbo.Update_User_Details 1,'Sameera123','Sameera','shaik','Sameera134@gmail.com',9966059945,'Sameera123','Female','Vijayawada','Gannavaram,Vijaywada 521286'


