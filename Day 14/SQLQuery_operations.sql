create table employeetable
(
emp_no int not null,
emp_name varchar(50)  null,
job varchar(50)  null,
mgr int null,
DoT Datetime null,
salary int null,
comm int null,
deptno int null,
)

Insert employeetable values(1,'Sam','Analyst',1,'09/6/12',30000,2,10)
Insert employeetable values(2,'Pam','Salesman',2,'10/6/12',3000,1,20)
Insert employeetable values(3,'James','Clerk',3,'10/6/12',4000,2,30)
Insert employeetable values(4,'Lalit','SoftwareEngg',4,'09/6/12',5000,3,40)
Insert employeetable values(5,'Rayan','Salesman',3,'10/6/12',3000,1,20)
Insert employeetable values(6,'Arhan','Analyst',3,'10/6/12',40000,1,10)
Insert employeetable values(7,'Lalitha','Analyst',3,'10/6/12',50000,1,10)
Insert employeetable values(8,'Vikram','Salesman',2,'09/6/12',3000,1,30)
Insert employeetable values(9,'Mahesh','Clerk',NULL,'10/6/12',4500,NULL,10)
Insert employeetable values(10,'Sham','Analyst',NULL,'10/6/12',35000,NULL,20)


select * from employeetable

select * from employeetable where deptno in (10,20)
select * from employeetable where job in('Clerk','Analyst')

select * from employeetable where emp_name like 'S%'

select * from employeetable where emp_name like '_L%'
select * from employeetable where emp_name like 'LL%'

select * from employeetable where emp_name like '%E'

select * from employeetable where emp_name like '_R%'

select emp_name,job from employeetable where job like '__'
select emp_name from employeetable where emp_name like '____'

select * from employeetable where salary between 2000 and 3000

select * from employeetable where comm is null
select * from employeetable where mgr is null

select * from employeetable where job ='saleman' and deptno =30
select * from employeetable where job ='saleman' and deptno =30 and salary>1500

select * from employeetable where emp_name like 'S%' or emp_name like 'A%'

select * from employeetable where deptno not in (10,20)

select * from employeetable where emp_name not like ' S%'

select * from employeetable where mgr is not null and deptno =10


select * from employeetable where job not in ('Manager','Clerk')
									and deptno in (10,20)
									and salary between 1000 and 3000


select * from employeetable where salary not between 1000 and 2000
								and deptno in (10,20,30)
								and job <>'salesman'
