--Code Challenge : 5
 
 
--1.	Write a query to display your birthday( day of week)

 declare @dob 
 date = '2001-08-25' 
select datename(weekday,@dob) as DayOfWeek
 
 
--2.	Write a query to display your age in days
declare @dob 
date = '2001-08-25' 
select datediff(date,@dob,getdate()) as AgeInDays

--3.Write a query to display all employees information those who joined before 5 years in the current month
 
--(Hint : If required update some HireDates in your EMP table of the assignment)

select * from emp where year(hiredate)<=year(getdate())-5 and month(hiredate)=month(getdate())
 
/*4.	Create table Employee with empno, ename, sal, doj columns or use and perform the following operations in a single transaction
	a. First insert 3 rows 
	b. Update the second row sal with 15% increment  
    c. Delete first row.
After completing above all actions, recall the deleted row without losing increment of second row.*/

 create table Employee (
    empno int primary key,
    ename varchar(50),
    sal decimal(10, 2),
    doj date
)
 
-- 4.1. Insert 3 rows
insert into Employee (empno, ename, sal, doj) values (1, 'Rajesh', 25000, '2024-01-15');
insert into Employee (empno, ename, sal, doj) values (2, 'Bhanu', 26000, '2023-02-28');
insert into Employee (empno, ename, sal, doj) values (3, 'Pavan', 27000, '2024-08-10');
 
select * from Employee
-----4.2
update Employee
set sal = sal * 1.15
where empno = 2
select * from Employee
 
-- 4.3.Delete the first row
delete from Employee
where empno = 1
 
select * from Employee
 
-- To recall the deleted row, re-insert it using the deleted data
insert into Employee values (1, 'Rajesh', 25000, '2024-01-15')

/*5.Create a user defined function calculate Bonus for all employees of a  given dept using following conditions
	a.     For Deptno 10 employees 15% of sal as bonus.
	b.     For Deptno 20 employees  20% of sal as bonus
	c      For Others employees 5%of sal as bonus*/

	create Function Cal_Bonus(
  @deptno int,
  @sal decimal(12,2)
  )
  returns decimal(12,2)
  as 
  begin
  declare @Bonus float;
  if 
 @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;
 
  select empno, ename,dbo.Cal_Bonus(deptno,sal) as BONUS from emp
 
	

 
--6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current 
--salary is below 1500 (use emp table)

create procedure updatesal
  as
  begin
    update emp
    set sal=sal+500
	where deptno=(select deptno from dept where dname='SALES') and sal<1500
  end
 
  Exec updatesal
  select *from emp
 