use Pradeep_db

--1 Retrieve a list of MANAGERS
select ename,job from emp where job='manager'

--2 Find out the names and salaries of all employees earning more than 1000 per month
select ename,sal from emp where sal>1000

--3  Display the names and salaries of all employees except JAMES
select ename,sal from emp where ename<>'JAMES'

--4 Find out the details of employees whose names begin with ‘S’
select ename from emp where ename like's%'

--5  Find out the names of all employees that have ‘A’ anywhere in their name
select ename from emp where ename like '%a%'

--6 Find out the names of all employees that have ‘L’ as their third character in their name
select ename from emp where ename like '__l%'

--7 Compute daily salary of JONES
select sal*12/365 from emp where ename='jones'

--8 Calculate the total monthly salary of all employees
select sum(sal) as 'totalsal' from emp

--9 Print the average annual salary
select avg(sal*12) as 'avgsal' from emp

--10 Select the name, job, salary, department number of all employees except SALESMAN from department number 30
select e.ename,e.job,e.sal,e.deptno from dept d,emp e where e.DEPTNO=d.DEPTNO and job<>'salesman' and e.DEPTNO=30

--11 List unique departments of the EMP table
select distinct(deptno) from emp

--12 List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively
select ename 'Empolyee',sal 'Monthly Salary',deptno from emp where sal>1500 and  deptno in(10,30)

--13 Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000
select ename,job,sal from emp where job in('manager','analyst') and sal not in(1000,3000,5000)

--14 Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%
select ename,sal,comm from emp where COMM>(sal+(sal*0.10))

--15  Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782
select ename from emp where ename like '%ll%' and deptno=30 or MGR_ID=7782

--16 Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees
select ename,count(*) 'no.of Employees'  from emp where DATEDIFF(year,hiredate,getdate()) between 30 and 40 group by ename

--17 Retrieve the names of departments in ascending order and their employees in descending order
select dname,ename from dept,emp where dept.deptno=emp.deptno order by DNAME , ename desc 

--18 Find out experience of MILLER
select datediff(year,HIREDATE,getdate()) as 'Empexperience' from EMP  where ENAME='miller'

