create Procedure spGetEmployees
As
Begin
select Name, Gender from tb1_employeestable
End

exec spGetEmployees

----With Parameter
Create Proc spGetEmployeesByGenderDepartment
@Gender nvarchar(20),
@DepartmentId Int
As
Begin
select Name,Gender, @DepartmentId from tb1_employeestable
		where Gender= @Gender and DepartmentId = @DepartmentId
END

spGetEmployeesByGenderDepartment @Gender ='male',@DepartmentId =1



Create Proc spGetEmployeesCountByGender
@Gender nvarchar(20),
@EmployeeCount int output
As
Begin
Select @EmployeeCount= Count(Id) from tb1_employeestable where Gender= @Gender
End


----execute output stored procedure

Declare @EmployeeTotal int
execute spGetEmployeesCountByGender 'male', @EmployeeTotal output
Print @EmployeeTotal