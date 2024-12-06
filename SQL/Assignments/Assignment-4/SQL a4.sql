
--Write a T-SQL Program to find the factorial of a given number.
Begin Transaction factorial_T
Declare @num int, @fac int=5
set @num = @fac - 1
while(@num > 0)
begin
set @fac = @fac * @num
set @num = @num - 1
end
print 'The factorial is:'+cast(@fac as varchar)

--Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 
create or alter procedure Multip_Table(@number int)
AS
BEGIN
Declare @i int = 1, @result int;
print 'The Multiplication table is:'
while (@i <= @number)
begin
set @result = @number * @i
print cast(@number as varchar)+'*'+cast(@i as varchar)+'='+cast(@result as varchar);
set @i = @i + 1
end
end
exec Multip_table 7
drop table Student
drop table Marks
----------------------------------------
create table Student(sid int primary key,sname varchar(20))
insert into Student values(1,'jack'),(2,'rithvik'),(3,'jaspreeth'),(4,'praveen'),(5,'bisa'),(6,'suraj')


create table Marks(mid int primary key,sid int references student(sid),score int)
insert into Marks values(1,1,23),(2,6,95),(3,4,98),(4,2,17),(5,3,53),(6,5,13)

create function statusofstd(@marks int)
returns varchar(10)
as
begin
	declare @status varchar(10)
	if @marks>=50
		set @status='Pass'
	else
		set @status='Fail'
	return @status
end
select s.sid,s.sname,m.score,dbo.statusofstd(score) as status from student s join marks m on s.sid=m.sid