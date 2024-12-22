create database RailwayProject

use RailwayProject

create database Train_Reservation_Project
 
use Train_Reservation_Project
 
CREATE TABLE Trains(
TrainNo int,
TrainName varchar(40),
FromStation varchar(40),
ToStation varchar(40),
ClassType varchar(40),
Status varchar(20),
TicketPrice int
)
 
select * from Trains
 
 drop table Trains
delete

from Trains

where Train_number = 9876;
 
--------------------- Add Trains-----------------
 
create or alter procedure sp_Add_Trains

@TrainNo int,
@TrainName varchar(20),
@FromStation varchar(20),
@ToStation varchar(20),
@ClassType varchar(20),
@Status varchar(20),
@TicketPrice int

as
begin
 Insert into Trains values

(@TrainNo,@TrainName,@FromStation,@ToStation,@ClassType,@Status,@TicketPrice)

end
 
 exec sp_Add_Trains
----------------Delete Trains----------------------

--drop procedure sp_delete_trains
 
Create or alter procedure sp_Delete_Trains

@TrainNo int

as
begin
update Trains

  set status = 'InActive'
  where TrainNo=@TrainNo;
end
 
 --where TrainName = @TrainName and TrainNo = @TrainNo and FromStation = @FromStation and ToStation = @ToStation;
--------------------Update Trains-----------
 
--drop procedure sp_Update_Trains
 
create or alter procedure sp_Update_Trains
@TrainNo int,
@TrainName varchar(40),
@FromStation varchar(40),
@ToStation varchar(40),
@Status varchar(40)
 
as
begin
update  Trains 

set
TrainName = @TrainName,
FromStation = @FromStation,
ToStation = @ToStation,
Status = @Status

where TrainNo = @TrainNo
end

 
select * from Trains
 
-----------------------User Block-----------------------

--drop procedure sp_View_Trains

create or alter procedure sp_View_Trains
as
begin 

select TrainNo, TrainName, FromStation, ToStation, ClassType, Status,  TicketPrice from Trains

where Status = 'Active';
end
 
 exec sp_View_Trains
-----------Tickets Table-----------------------

--drop table Tickets

create table Tickets
(
TrainNo int,
TrainName varchar(40),
PassengerName varchar(40),
PassengerAge int,
Gender varchar(20),
ClassType varchar(40),
Number_of_seats int,
)


select * from Tickets

--drop procedure sp_Book_Ticket
 
create or alter procedure sp_Book_Ticket
 
@TrainNo int,
@TrainName varchar(40),
@PassengerName varchar(40),
@PassengerAge int,
@gender varchar(20),
@ClassType varchar(40),
@Number_of_seats int

as
begin
 
insert into Tickets
values
(@TrainNo, @TrainName, @PassengerName, @PassengerAge, @Gender, @ClassType, @Number_of_seats)

end
 
 
---------Cancel------------------

create table Cancel_Ticket(
TrainNo int,
TrainName varchar(20),
PassengerName varchar(20)
)
 
select * from Cancel_Ticket
 
create or alter procedure sp_Cancel_Ticket

@Trainno int,
@TrainName varchar(20),
@PassengerName varchar(20)

as
begin

insert into Cancel_Ticket
values
(@TrainNo,@TrainName,@PassengerName)

end
 
-------------------Show all trains------------------

create table view_Trains_information
(
TrainNo int,
TrainName varchar(20),
FromStation varchar,
ToStation varchar,
ClassType varchar(20),
TicketPrice int,
Status varchar(20)
)

select * from view_Trains_information
drop table view_trains_information

create or alter procedure sp_view_Trains_information
as
begin
select
TrainNo ,
TrainName ,
FromStation ,
ToStation  ,
ClassType,
TicketPrice,
status
from view_Trains_information

end

 drop procedure sp_view_trains_information
 
 








