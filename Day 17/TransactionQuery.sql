CREATE TABLE Departmentt1
(
 DeptID int PRIMARY KEY, 
 DeptName varchar(50) NULL,
 Location varchar(100) NULL,
 )
GO
 CREATE TABLE Employees
(
 EmpID int PRIMARY KEY, 
 Name varchar(50) NULL,
 Salary int NULL, 
 Address varchar(100) NULL,
 DeptID int foreign Key references Departmentt1(DeptID)
) 
--Now Insert data
INSERT INTO Departmentt1(DeptID,DeptName,Location)VALUES(1,'IT','Delhi')
GO
INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(1,'Mohan',15000,'Delhi',1)

BEGIN TRANSACTION trans
BEGIN TRY
INSERT INTO Departmentt1(DeptID,DeptName,Location)VALUES(2,'AS','AP')
INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(2,'Mohan',16000,'AP',2)

IF @@TRANCOUNT > 0
 BEGIN COMMIT TRANSACTION trans
 END
END TRY
BEGIN CATCH
 print 'Error Occured'
 IF @@TRANCOUNT > 0
 BEGIN ROLLBACK TRANSACTION trans
 END
END CATCH

select * from Employees

select * from Departmentt1

BEGIN TRY
INSERT INTO Departmentt1(DeptID,DeptName,Location)VALUES(2,'HR','Delhi')
 IF @@TRANCOUNT > 0
 BEGIN SAVE TRANSACTION trans;
 END
 INSERT INTO Departmentt1(DeptID,DeptName,Location)VALUES(3,'Admin','Delhi')
INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(1,'Mohan',18000,'Delhi',1)
 IF @@TRANCOUNT > 0
 BEGIN COMMIT TRANSACTION trans
 END
END TRY
BEGIN CATCH
 print 'Error Occured'
  IF @@TRANCOUNT > 0
 BEGIN ROLLBACK TRANSACTION trans
 END
END CATCH