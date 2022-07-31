create table femployee(
emp_no int not null,
emp_name varchar(10) not null,
dept_no int,
grade varchar(1),
basic_salary numeric(9,2)
)


select * from employee
exec sp_rename 'employee', 'emp'


select * from emp

sp_rename 'emp.basic_salary','bsal'

create table department(dept_no int identity (1,1),
				dept_name varchar(20),
				location varchar(20))

select * from department

Insert department values('harish','mumbai')
Insert department values('Rahul','pune')

Update department set dept_name = 'raj' where dept_no= 1
--Alter column datatype
Alter table emp Alter column emp_no varchar(5) not null

--Add a column
Alter table emp Add DoT Datetime

--Drop a column
Alter table emp drop column DoT

select * from emp

Insert emp values('E001','sam','10','A',4500,'11/3/14')
Insert emp values('E002','ram','10','B',4510,'11/3/14')
Insert emp values('E003','nam','20','C',4520,'11/3/14')
Insert emp (emp_no,emp_name) value('1006','lam')

Update emp set emp_name = 'samuel' where emp_no= 'E001'

select * from emp where dept_no=20

select * from femployee

Insert femployee values('E001','raj','10','A',4500,'11/3/14')