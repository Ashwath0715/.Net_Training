Create table EmployeeDetails
(
	EmpId int NULL,
	FullName nvarchar(50),
	ManagerId int,
	DateOfJoining Datetime null,
	City nvarchar(40)
)
Go

Insert into EmployeeDetails values (121,'Lakshmi Kumar',321,01-31-2001,'Hyderabad')
Insert into EmployeeDetails values (321,'Damodaran',986,01-30-2002,'Chennai')
Insert into EmployeeDetails values (421,'Priyadarshini',876,27-11-2003,'Bangalore')
Insert into EmployeeDetails values (521,'Mahesh',768,08-09-2004,'Mumbai')
Insert into EmployeeDetails values (621,'Mrinalini',456,09-10-2005,'Thiruvanthapuram')
Insert into EmployeeDetails values (721,'Yuvraj',654,06-08-2006,'Bhopal')
Insert into EmployeeDetails values (821,'Shruthi',546,05-05-2007,'Chandigarh')
Insert into EmployeeDetails values (921,'Nandini',256,09-06-2008,'Shimla')
Insert into EmployeeDetails values (221,'Santhya',345,07-11-2009,'Shillong')
Insert into EmployeeDetails values (122,'Priyavarshini',324,08-12-2010,'Amaravathi')

select * from EmployeeDetails

Create table EmployeeSalary
(
	EmpId int NULL,
	Project nvarchar(50),
	Salary int,
	variable int
)
Go

Insert into EmployeeSalary values (121,'P1',15000,500)
Insert into EmployeeSalary values (321,'P2',10000,1000)
Insert into EmployeeSalary values (421,'P1',12000,0)
Insert into EmployeeSalary values (521,'P2',9000,600)
Insert into EmployeeSalary values (621,Null,11000,0)
Insert into EmployeeSalary values (721,'P1',9000,850)
Insert into EmployeeSalary values (821,'P2',14000,478)
Insert into EmployeeSalary values (921,'P1',13000,0)
Insert into EmployeeSalary values (221,'P2',9000,586)
Insert into EmployeeSalary values (122,Null,7000,750)

select * from EmployeeSalary


--------2. fetch the different projects 
select DISTINCT(Project) from EmployeeSalary;

------3. salary between 9000  and 15000
select * from EmployeeSalary where salary between 9000  and 15000

-------------5. maximum, minimum, and average salary 
select Max(Salary), Min(Salary), AVG(Salary) from EmployeeSalary

-------1. nth highest salary
select * from EmployeeSalary Emp1
WHERE ( n ) = (
                select COUNT( DISTINCT ( Emp2.Salary ) )
                from EmployeeSalary Emp2
                WHERE Emp2.Salary >= Emp1.Salary
            )

----- 4. count of employees 
select count(*) Count_of_Project from [sampleDBDemo].[dbo].[EmployeeSalary] where Project='P1' 

-----6. fetch all the employees who either live in Hyderabad or work 
select EmpId, City, ManagerId from EmployeeDetails where City='Hyderabad' OR ManagerId='321';


------7.Write an SQL query to display both the EmpId and ManagerId together
select CONCAT (EmpId, ManagerId) as NewId FROM EmployeeDetails;


-----8.Fetch all the employees who are not working on any project
select EmpId from EmployeeSalary where Project IS NULL;


------9. to fetch all employee records from EmployeeDetails table who have a salary record in EmployeeSalary table.
select * from [sampleDBDemo].[dbo].[EmployeeDetails] E WHERE EXISTS

(select * from [SampleDBDemo].[dbo].[EmployeeSalary] S

WHERE E.EmpId = S.EmpId);


--------10. To fetch all the Employees who are also managers from the EmployeeDetails table
select E.FullName

from [SampleDBDemo].[dbo].[EmployeeDetails] E

INNER JOIN [SampleDBDemo].[dbo].[EmployeeDetails] M

ON E.EmpId = M.ManagerId;
