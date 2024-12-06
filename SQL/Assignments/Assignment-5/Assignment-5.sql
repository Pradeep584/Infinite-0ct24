create or alter PROCEDURE spPaySlip
@EmpID INT,
@Sal DECIMAL(10, 2)
AS
BEGIN
DECLARE
@HRA DECIMAL(10,2),
@DA DECIMAL(10, 2),
@PF DECIMAL(10, 2),
@IT DECIMAL(10, 2),
@Deductions DECIMAL(10, 2),
@GrossSalary DECIMAL(10, 2),
@NetSalary DECIMAL(10, 2)
 
---- Calculate HRA, DA, PF, IT
SET @HRA = @Sal * 0.10
SET @DA = @Sal * 0.20
SET @PF = @Sal * 0.08
SET @IT = @Sal * 0.05
 
-----Calculate Deductions
SET @Deductions = @PF + @IT
 
------ Calculate Gross Salary
SET @GrossSalary = @Sal + @HRA + @DA
 
------ Calculate Net Salary
SET @NetSalary = @GrossSalary - @Deductions
 
------Print Payslip
PRINT 'Payslip for Employee ID: ' + CONVERT(VARCHAR, @EmpID)
PRINT '-----------------------------------------------'
PRINT 'Salary: ' + CONVERT(VARCHAR, @Sal)
PRINT 'HRA (10%): ' + CONVERT(VARCHAR, @HRA)
PRINT 'DA (20%): ' + CONVERT(VARCHAR, @DA)
PRINT 'PF (8%): ' + CONVERT(VARCHAR, @PF)
PRINT 'IT (5%): ' + CONVERT(VARCHAR, @IT)
PRINT 'Deductions: ' + CONVERT(VARCHAR, @Deductions)
PRINT 'Gross Salary: ' + CONVERT(VARCHAR, @GrossSalary)
PRINT 'Net Salary: ' + CONVERT(VARCHAR, @NetSalary)
PRINT '-----------------------------------------------'
END
GO
 
EXEC spPayslip @EmpID = 2, @Sal = 70000
 
--------------------------------------------------------------------------------------------------------------------------------------------------
 
  ---2.HOLIDAYS TABLE
CREATE TABLE Holidays (
holiday_date date primary key,
holiday_name VARCHAR(20) NOT NULL
)
INSERT INTO Holidays (holiday_date, holiday_name) VALUES
('2024-01-26', 'Republic Day'),
('2024-03-29', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-11-12', 'Diwali')
 
CREATE or alter trigger DataManipulation
ON Emp
for insert,update,delete
as
BEGIN
DECLARE @holiday_name VARCHAR(20);
	declare @current_date date = cast(getdate() as date)
SELECT @holiday_name =holiday_name
FROM Holidays
WHERE holiday_date = @current_date;
IF @holiday_name IS NOT NULL
	begin
raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
rollback transaction
END
END
update Emp set ename='JONES' where EmpNo=7566
select * from emp
