CREATE TABLE Member  
(  
    id INT PRIMARY KEY,  
    Name VARCHAR(50) NOT NULL,  
    salary INT NOT NULL,  
	gender VARCHAR(50) NOT NULL,  
    city VARCHAR(50) NOT NULL  
 ) 
 Go

 insert into Member values(3,'John',4500,'Male','New York')
 insert into Member values(1,'Sam',2500,'male','London')
 insert into Member values(4,'Sara',5500,'Female','Syndey')
 insert into Member values(2,'Pam',3100,'FeMale','Tokyo')
 insert into Member values(5,'Todd',6500,'Male','Toranto')


  create clustered index IX_Member_Gender_Salary
  on Member(gender DESC,Salary ASC)


  create nonclustered index IX_Member_Name on Member(name)

  create unique nonclustered index IX_Member_Name
  on Member(name)


  select * from Member

  Alter table Member ADD Constraint UQ_Member_City UNIQUE (City)