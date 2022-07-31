use SampleDemo
create table Employee(
ID int not null,
Name varchar(20) null,
Gender varchar(20) null,
Salary Decimal(3,2) null
)

exec sp_rename 'Employee','tEmployee'

Alter database SampleDemo modify name = SampleDBDemo


Create table dept
(
ID int Primary key identity(1,1),
DepartMentName nvarchar(50) not NULL
)
Insert dept values('IT')
Alter table femployee add Constraint emp_Depart_FK
Foreign Key(emp_no) references dept(ID)
