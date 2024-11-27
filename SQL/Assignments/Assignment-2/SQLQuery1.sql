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
 --1
 select * from emp where ename like 'a%'
 --2
 select * from emp where MGR_ID is null
 --3
 select ename,empno,sal from emp where sal between 1200 and 1400
 --11
 select ename,sal from emp where ename in('MILLER','SMITH')
 --13
 select ename, sal*12 as 'Annual Salary' from emp where ename = 'SMITH'
 --14
 select ename,sal from emp  where sal  not between 1500 and 2850
 --15
 select ename,MGR_ID,count(*) as emp_count from emp group by MGR_ID having count(*)>2
 --9
 select ename,sal from emp where job='ANALYST' and sal > 1200 and deptno=20 order by ename
 --5
 select count(*) as 'No.of Clerks' from emp where job='Clerk'
 --4
 select ename,sal,sal+(0.10*sal) as 'sal+10%' from emp where DEPTNO=(select deptno  from dept where dname='RESEARCH') 
 --7
 select ename,sal from emp where sal=(select max(sal) from emp) union select ename,sal from emp where  sal=(select min(sal) from emp)

  select dname from emp,dept where emp.deptno=dept.deptno group by dept.DEPTNO having count(emp.DEPTNO)=0

 select * from emp e where exists (select 'x' from emp where MGR_ID=e.MGR_ID)

 select * from emp where sal< any
 (select sal from emp where job='salesman')
 and job<>'salesman'


 select ename,sal,DEPTNO from emp e1 where SAL>(select avg(sal) from emp e2 where e1.DEPTNO=e2.DEPTNO)

 --with corelated sub query
select ename,sal,dname from emp e1,dept e2
where sal> (select avg(sal) from emp where e2.deptno = e1.deptno)
                --5166  bhanuprakash
				--5200  chiramya, hareesh
 
--with inner join

select ename,sal,dname from emp,dept where emp.DEPTNO=dept.DEPTNO
and sal>(select avg(sal) as avgsal from emp,DEPT)

select * from emp e1 inner join (select deptno,avg(sal) as avgsal from emp group by deptno) as e2 on 
e1.deptno=e2.deptno where e1.sal>e2.avgsal

