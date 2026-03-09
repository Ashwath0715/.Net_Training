create table Employee_Test
(
Emp_ID int identity,
Emp_Name varchar(55),
Emp_Technology varchar(55),
Emp_Sal decimal (10,2),
Emp_Designation varchar(20)
)

-----To view detailed info of col of table
SELECT * FROM INFORMATION_SCHEMA.COLUMNS
where TABLE_NAME='Employee_Test'

select * from sys.tables
---To see all SQL Server connections
SELECT connection_id,session_id,client_net_address,auth_scheme
FROM sys.dm_exec_connections

---Now Insert data
Insert into Employee_Test values ('Amit','PHP',12000,'SE');
Insert into Employee_Test values ('Mohan','ASP',15000,'TL');
Insert into Employee_Test values ('Monaj','JAVA',22000,'SSE');
Insert into Employee_Test values ('Riz','VB',18000,'SE');

----Now create view on single table
create VIEW vw_Employee_Test
AS
Select Emp_ID,Emp_Name,Emp_Designation
FROM Employee_Test

---Query view like as table
select * from vw_Employee_Test

insert into vw_Employee_Test(Emp_Name,Emp_Designation)
			values ('Shailu','SSE')

----Now see the affected view
select * from vw_Employee_Test
select * from Employee_Test
---Update data to view vw_Employee_Test
Update vw_Employee_Test set Emp_Name = 'Pawan' where Emp_ID=5

---Delete 
delete from vw_Employee_Test where Emp_ID =5