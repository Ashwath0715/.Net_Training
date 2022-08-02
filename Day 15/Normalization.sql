Create table Studenttb1
(
	StudentID int not NULL,
	Name varchar(50),
	PinCode int,
	City varchar(50),
	State varchar(50)
)
Go

Insert into Studenttb1 values (1,'Rahul',3469720,'MP','Indore')
Insert into Studenttb1 values (2,'Ajay',469237,'UP','Lucknow')
Insert into Studenttb1 values (3,'John',2854542,'MH','Pune')
Insert into Studenttb1 values (4,'Vijay',238743,'MH','Mumbai')


Create table Studenttb2
(
	StudentID int not NULL,
	Name varchar(50),
	PinCode int,

)

Insert into Studenttb2 values (1,'Rahul',3469720)
Insert into Studenttb2 values (2,'Ajay',469237)
Insert into Studenttb2 values (3,'John',2854542)
Insert into Studenttb2 values (4,'Vijay',238743)

Create table Studenttb3
(
	PinCode int,
	City varchar(50),
	State varchar(50)
)

Insert into Studenttb3 values (3469720,'MP','Indore')
Insert into Studenttb3 values (469237,'UP','Lucknow')
Insert into Studenttb3 values (2854542,'MH','Pune')
Insert into Studenttb3 values (238743,'MH','Mumbai')

select * from Studenttb1
select * from Studenttb2
select * from Studenttb3
