Create table deptm
(
	deptNo int not NULL,
	Dname varchar(20) NULL,
	LOC varchar(10) NULL,
)

Insert deptm values(10,'ABC','Pune')
Insert deptm values(20,'XYZ','Nagpur')
Insert deptm values(30,'NYN','Mumbai')


select * from employeetable
select * from deptm

select * from employeetable where deptNo =(Select deptNo from deptm where Dname='ABC')

select * from deptm where deptNo IN (select deptNo from employeetable where job ='Analyst')

select * from employeetable where deptNo in(select deptno from deptm where dname in ('ABC','XYZ'))
order by deptNo

select * from deptm where deptno in (select deptno from employeetable where Job='Salesman')

select * from employeetable
where deptno in(select deptno from deptm where loc like '%Pune%')


--List the department names which are having atleast 1 employees in it 
select dname from deptm where deptno in
(select deptno from employeetable group by deptno having Count(*) >0)

--List the department names which are having 4 employees in it 
select dname from deptm where deptno in
(select deptno from employeetable group by deptno having Count(*) >=4)

--List the department names which are having atleast 2 clerks in it 
select dname from deptm where deptno in
(select deptno from employeetable group by deptno having Count('Clerk') =2)

--Display the 2nd maximum salary
select max(salary) from employeetable
where salary < (select max(salary) from employeetable)

--Display the 3rd maximum salary
select max(salary) from employeetable
where salary < (select max(salary) from employeetable
where salary < (select max(salary) from employeetable))

--Display the 4th maximum salary
select min(salary) from employeetable
where salary > (select min(salary) from employeetable
where salary > (select min(salary) from employeetable
where salary > (select min(salary) from employeetable)))

---List the depaertment names that are having no employeeat all
select * from deptm where deptno  in (select deptno from employeetable)

select Top 5 salary,comm from employeetable order by salary DESC