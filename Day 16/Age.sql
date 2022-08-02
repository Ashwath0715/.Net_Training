CREATE TABLE tb1_employeestable
(
	ID int primary Key,
	Name nvarchar(50) null,
	DoT Datetime null,
	
	Gender nvarchar(10) null,
	DepartmentId int NULL,
)

Insert into tb1_employeestable values(1,'Sam','1980-12-30 00:00:00:000','Male',1)
Insert into tb1_employeestable values(2,'Ram','1982-09-01 12:02:36:260','Female',2)
Insert into tb1_employeestable values(3,'Raj','1982-09-01 ','Female',1)
Insert into tb1_employeestable values(4,'Rahul','1982-09-01 ','male',1)
Insert into tb1_employeestable values(5,'Viraj','1982-09-01 ','male',1)
Select * from tb1_employeestable

Select Name, dbo.Age(DoT) as age from tb1_employeestable