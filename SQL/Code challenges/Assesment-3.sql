use Pradeep_db
create table Course_Details
(C_id varchar(10),
C_Name varchar(10),
Start_date DATE,
End_date DATE,
Fee int)
 
 
insert into Course_Details
values
('DN003','DotNet','2018-02-01','2018-02-28',15000),
('DV004','Data Visualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),
('JC001','CoreJava','2018-01-02','2018-01-12',3000)

--1. Create the Function
 
create function dbo.CalCourseDuration
(
    @StartDate date,
    @EndDate date
)
returns int
as
begin
    -- Calculate the difference in days between the start and end date
    return datediff(day, @StartDate, @EndDate)
end
go
 
select dbo.CalCourseDuration('2018-02-01', '2018-02-28') as CourseDuration
select dbo.CalCourseDuration('2018-01-02', '2018-01-20') as CourseDuration

---2 triggers
CREATE TABLE Table_CourseInfo
(
    CourseName varchar(10),
    Startdate date
)
create or alter trigger trig_InsertCourseInfo
on Course_Details
after insert
as
begin
    insert into Table_CourseInfo(CourseName, Startdate)
    select C_Name, Start_date
	from inserted   
end 
go

insert into Course_Details 
values ('AWS005', 'AWS', '2018-01-10', '2018-02-10', 12000)
select * from Table_CourseInfo
select * from 



--Write a stored Procedure that inserts records in the ProductsDetails table
 
--Table : ProductsDetails (ProductId, ProductName, Price, DiscountedPrice)
 
--The procedure should generate the ProductId automatically to insert and should return the generated value to the user
--Hint(User should not give the ProductId while inserting)
--Also the Discounted Price Column is a calculated column (Price - 10%)
 
--Test the Procedure using ADO classes to call the Procedure and show the generated ProductId, and Discounted Price

create table ProductDetails(
ProductId int identity(1,1),
ProductName varchar(20),
Price float(10),
DiscountedPrice float(10))

create or alter procedure sp_insert
@ProductName varchar(20),
@Price float,
@DiscountedPrice float
as
begin
insert into ProductDetails values(@ProductName, @Price, @DiscountedPrice);


end



create or alter procedure sp_select

as
begin
select * from ProductDetails;

end
--drop procedure sp_insert

select * from ProductDetails;

exec sp_insert