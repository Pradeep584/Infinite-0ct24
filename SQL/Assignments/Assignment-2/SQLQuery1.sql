use Pradeep_db

create table DEPT
(
DEPTNO int primary key not null,
DNAME varchar(20) not null,
LOC varchar(10) not null
)

create table EMP
(
  EMPNO int not null,
  ENAME varchar(20) not null,
  JOB varchar(20) not null,
  MGR_ID int,
  HIREDATE date not null,
  SAL int not null,
  COMM int,
  DEPTNO int references DEPT(DEPTNO)
)

insert into dept values
(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')


 insert into EMP values
 (7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
 (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
 (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
 (7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
 (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
 (7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
 (7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,NULL,10),
 (7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
 (7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10),
 (7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
 (7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
 (7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
 (7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
 (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10)

 select * from EMP
SELECT * FROM DEPT

 --1 List all employees whose name begins with 'A'
 select * from emp where ename like 'a%'

 --2 Select all those employees who don't have a manager
 select * from emp where MGR_ID is null

 --3 List employee name, number and salary for those employees who earn in the range 1200 to 1400
 select ename,empno,sal from emp where sal between 1200 and 1400

 --4  Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 
 select ename,sal,sal+(0.10*sal) as 'sal+10%' from emp where DEPTNO=(select deptno  from dept where dname='RESEARCH') 

 --5 Find the number of CLERKS employed. Give it a descriptive heading. 
 select count(*) as 'No.of Clerks' from emp where job='Clerk'

 --6 Find the average salary for each job type and the number of people employed in each job
 select job,avg(sal) as 'Avg salary',COUNT(*) as 'Emp count' from emp group by job
 --7 List the employees with the lowest and highest salary.
 select ename,sal from emp where sal=(select max(sal) from emp) union select ename,sal from emp where  sal=(select min(sal) from emp)

 --8 List full details of departments that don't have any employees
 select DNAME from DEPT left  join EMP on dept.DEPTNO=EMP.DEPTNO where emp.DEPTNO is null

 --9  Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
 select ename,sal from emp where job='ANALYST' and sal > 1200 and deptno=20 order by ename

 --10 For each department, list its name and number together with the total salary paid to employees in that department
 select e1.ENAME,e1.SAL,e1.DEPTNO,sum(e1.SAL) as 'Sum salary' from emp e1 join EMP e2 on  e1.DEPTNO=e2.DEPTNO  
 group by e1.ENAME,e1.SAL,e1.DEPTNO

 --11  Find out salary of both MILLER and SMITH
 select ename,sal from emp where ename in('MILLER','SMITH')

 --12 Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
 select ename from emp where ENAME like'A%' or  ename like 'M%'

 --13 Compute yearly salary of SMITH
 select ename, sal*12 as 'Annual Salary' from emp where ename = 'SMITH'

 --14 List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
 select ename,sal from emp  where sal  not between 1500 and 2850


 --15 Find all managers who have more than 2 employees reporting to them
 select MGR_ID,count(*) as emp_count from emp group by  MGR_ID having count(*)>2
 
 
 
 

  select dname from emp,dept where emp.deptno=dept.deptno group by dept.DEPTNO having count(emp.DEPTNO)=0

 

 select * from emp where sal< any
 (select sal from emp where job='salesman')
 and job<>'salesman'






















 create or alter proc sp_inc (@enum int)
 as
 begin
 select empno,ename,sal,sal+100 from emp where sal<1250 
 and empno=@enum
 end

sp_inc 7876

 
