Create table tblProject
(
	ID int primary Key,
	ProjectName nvarchar(50),
	ProjectType nvarchar(50),
	ProjectManager nvarchar(50)
)
Go


Insert into tblProject values (1,'Ecommerce','Web Design','Raj')
Insert into tblProject values (2,'Ethical Hacking','Cyber Security','John')
Insert into tblProject values (3,'Online Auction App','Android Developer','Rahul')
Insert into tblProject values (4,'Home Automation','IOT','Abir')
Go

Create table tblEmployee_table
(
	ID int primary Key,
	Name nvarchar(50),
	Gender nvarchar(50),
	Salary int,
	ProjectId int foreign key references tblProject(Id)
)
Go

Insert into tblEmployee_table values (1,'Terry','Male',4000,1)
Insert into tblEmployee_table values (2,'Pam','Female',3000,3)
Insert into tblEmployee_table values (3,'Johnny','Male',3500,1)
Insert into tblEmployee_table values (4,'Sammy','Male',4500,2)
Insert into tblEmployee_table values (5,'Toddy','Male',2800,2)
Insert into tblEmployee_table values (6,'Beny','Male',7000,1)
Insert into tblEmployee_table values (7,'Sara','Female',4800,3)
Insert into tblEmployee_table values (8,'Vikas','Female',5500,1)
Insert into tblEmployee_table values (9,'Jakie','Male',6500,NULL)
Insert into tblEmployee_table values (10,'Rohan','Male',8800,NULL)
Go

select * from tblProject
select * from tblEmployee_table

---Inner Join
select Name,Gender,Salary,ProjectName from tblEmployee_table
Inner Join tblProject
ON tblEmployee_table.ProjectId = tblProject.ID

---Left Join
select Name,Gender,Salary,ProjectName from tblEmployee_table
LEFT Join tblProject
ON tblEmployee_table.ProjectId = tblProject.ID

--Right Join
select Name,Gender,Salary,ProjectName from tblEmployee_table
RIGHT Join tblProject
ON tblEmployee_table.ProjectId = tblProject.ID

---FULL Join
select Name,Gender,Salary,ProjectName from tblEmployee_table
FULL Join tblProject
ON tblEmployee_table.ProjectId = tblProject.ID


---CROSS Join
select Name,Gender,Salary,ProjectName from tblEmployee_table
CROSS Join tblProject

 ---How to retrieve only the non matching rows from the left table
 select Name,Gender,Salary,ProjectName from tblEmployee_table E
LEFT Join tblProject P
ON E.ID=P.ID
where P.ID is NULL


 ---How to retrieve only the non matching rows from the right table
select Name,Gender,Salary,ProjectName from tblEmployee_table E
RIGHT Join tblProject P
ON E.ProjectId=P.ID
where E.ProjectId = NULL

SELECT Name,Gender,Salary,ProjectName
FROM  tblEmployee_table E
LEFT Join tblProject P
ON E.ProjectId = P.Id
WHERE P.Id IS NULL