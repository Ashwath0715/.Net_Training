---Create function to get name job 
Create function fnGetEmpwithJobName
(
@emp_name varchar(50),
@job varchar(50)
)
returns varchar(101)
As 
Begin return (Select @emp_name + ' '+@job);
end

select * from employeetable

---Calling the above created function
Select dbo.fnGetEmpwithJobName(emp_name,job) as Name,
				salary from employeetable

Select SUBSTRING('John@bbb.com',
(                ------ 5  + 1
Select CHARINDEX('@','John@bbb.com')+1),
(Select LEN ('John@bbb.com') - Select CHARINDEX('@','John@bbb.com'))
                ---- 12  - 5 = 7
Select SUBSTRING('John@bbb.com',6,7)

Select LOWER('CONVERT TO LOWER CASE')

Select CEILING(15.2)
Select CEILING(-15.2)

Select FLOOR(15.2)
Select FLOOR(-15.2)

Select POWER(2,3)

----RAND() function always return the same value for the same seed
Select RAND(1)

----If u want to generate a random number between 1 and 100
----Every time you exceute this query u get random no bet 1 to 100
Select FLOOR(RAND() *100)

Select POWER(2,3)

Select RAND(1)

Select FLOOR(RAND() *100)

----This prints 10 random no bet 1 to 100
Declare @Counter INT
Set @Counter =1
While(@Counter <=10)
Begin
 Print FLOOR(RAND() *100)
 Set @Counter = @Counter +1
END

Select SQUARE(9)

Select SQRT(81)
 
----ROUND (numeric_expression,length [ ,function])

Select ROUND(850.556,2)  ----Returns 850.560

Select ROUND(850.556,2,1)  ----Returns 850.550

Select ROUND(850.556,1) ----Returns 850.600

Select ROUND(850.556,1,1)  -----Returns 850.500


