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