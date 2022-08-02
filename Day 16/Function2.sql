-------Cast_convert-Date

Select Id, Name, DateofBirth, Convert(nvarchar, DateOfBirth) as ConvertedDOB
from Employees


Select Id, Name, DateofBirth, Convert(nvarchar, DateOfBirth,105) as ConvertedDOB
from Employees


---------Scalar Function

Create Function Age(@DOB Date)
Returns int
as
Begin 
	Declare @Age int

	set @Age = DATEDIFF(YEAR, @DOB,GETDATE())
	- CASE WHEN (MONTH (@DOB) > MONTH (GETDATE())) OR (MONTH (@DOB) > MONTH(GETDATE())
	AND DAY(@DOB) >DAY(GETDATE()))
	THEN 1
	ELSE 0
END
RETURN @Age
END

Select SampleDBDemo.dbo.Age('10/08/1982')
Select dbo.Age('10/08/1982')

-----InlineFunction 

Create function fnGetInlineEmployee()
returns Table
As
 return (Select * from employeetable)

 ----Now call the above function
 Select * from fnGetInlineEmployee()


 Create function fnGetInlineCustomer()
returns Table
As
 return (Select * from Customers)

 ----Now call the above function
 Select * from fnGetInlineCustomer()

 ----- Multiline

 Create function fnGetMultiEmployee()
 returns @Emp Table
 (
emp_no nchar(5),
emp_name varchar(50),
salary nvarchar(50)
 )
 As
 begin
 Insert into @Emp Select e.emp_no,e.emp_name,e.salary from employeetable e;
 ------Now update salary of first employee
 update @Emp set salary=25000 where emp_no=1;
 -----It will update only in @Emp table not in Original Employee table
 return 
 end

 select * from fnGetMultiEmployee()


 select * from Customers

 Create function fnGetMultiCustomer()
 returns @cust Table
 (
 CustomerID nchar(5),
 CompanyName varchar(50),
 Address varchar(50)
 )
 As
 Begin
   Insert into @cust Select e.CustomerID,e.CompanyName,e.Address from Customers e
   update @cust set CompanyName='ABC' where CustomerID='ALFKI'
   return 
 end

 select * from fnGetMultiCustomer()