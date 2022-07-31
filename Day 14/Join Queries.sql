Create table tblDepartment
(
	ID int primary Key,
	DepartmentName nvarchar(50),
	Location nvarchar(50),
	DepartmentHead nvarchar(50)
)
Go

Insert into tblDepartment values (1,'IT','London','Ram')
Insert into tblDepartment values (2,'Finance','US','Raj')
Insert into tblDepartment values (3,'HR','New York','Christie')
Insert into tblDepartment values (4,'Other Department','Sydney','Nivea')
Go

Create table tblEmployee
(
	ID int primary Key,
	Name nvarchar(50),
	Gender nvarchar(50),
	Salary int,
	DepartmentId int foreign key references tblDepartment(Id)
)
Go

Insert into tblEmployee values (1,'Terry','Male',4000,1)
Insert into tblEmployee values (2,'Pam','Female',3000,3)
Insert into tblEmployee values (3,'Johnny','Male',3500,1)
Insert into tblEmployee values (4,'Sammy','Male',4500,2)
Insert into tblEmployee values (5,'Toddy','Male',2800,2)
Insert into tblEmployee values (6,'Beny','Male',7000,1)
Insert into tblEmployee values (7,'Sara','Female',4800,3)
Insert into tblEmployee values (8,'Vikas','Female',5500,1)
Insert into tblEmployee values (9,'Jakie','Male',6500,NULL)
Insert into tblEmployee values (10,'Rohan','Male',8800,NULL)
Go

select * from tblDepartment
select * from tblEmployee

--Cross join
select Name,Gender,Salary,DepartmentName from tblEmployee
Cross Join tblDepartment

---Inner Join
select Name,Gender,Salary,DepartmentName from tblEmployee
Inner Join tblDepartment
ON tblEmployee.ID = tblDepartment.ID

---Left Join
select Name,Gender,Salary,DepartmentName from tblEmployee
LEFT Join tblDepartment
ON tblEmployee.ID = tblDepartment.ID

--Right Join
select Name,Gender,Salary,DepartmentName from tblEmployee
RIGHT Join tblDepartment
ON tblEmployee.ID = tblDepartment.ID

---FULL Join
select Name,Gender,Salary,DepartmentName from tblEmployee
FULL Join tblDepartment
ON tblEmployee.ID = tblDepartment.ID
 
 ---How to retrieve only the non matching rows from the left table
 select Name,Gender,Salary,DepartmentName from tblEmployee E
LEFT Join tblDepartment D
ON E.ID=D.ID
where D.ID is NULL

 ---How to retrieve only the non matching rows from the right table
  select Name,Gender,Salary,DepartmentName 
  from tblEmployee E
RIGHT Join tblDepartment D
ON E.DepartmentId=D.ID
where E.DepartmentId = NULL

SELECT Name,Gender,Salary,DepartmentName
FROM  tblEmployee E
LEFT Join tblDepartment D
ON E.DepartmentId = D.Id
WHERE D.Id IS NULL