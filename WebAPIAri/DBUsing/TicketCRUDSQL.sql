CREATE TABLE ETicket
(
	PASSENGERID BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	TICKETNUMBER bigint NOT NULL,
	PASSENGERNAME nvarchar(50) NOT NULL,
	PHNUMBER bigint NOT NULL,
	EMAILID nvarchar(50) NOT NULL,
	JOURNEYDATE datetime2(7) NOT NULL
)
Select * from ETicket
drop table ETicket

CREATE procedure InsertSP(@TICKETNUMBER bigint ,@PASSENGERNAME nvarchar(50),@PHNUMBER bigint,@EMAILID nvarchar(50),@JOURNEYDATE datetime2(7) )
AS
BEGIN
INSERT INTO ETicket values(@TICKETNUMBER,@PASSENGERNAME,@PHNUMBER,@EMAILID,@JOURNEYDATE)
END
exec InsertSP 101,'madhan',1234567890,'madhan@gmail.com','02/18/2004'
exec InsertSP 102,'guru',1098765433,'guru@gmail.com','03/05/2006'
exec InsertSP 103,'sankar',8765945635,'sankar@gmail.com','05/08/2024'
exec InsertSP 104,'siva',2397346464,'siva@gmail.com','02/01/2014'
exec InsertSP 105,'hari',9876543334,'hari@gmail.com','04/02/2023'
drop procedure InsertSP
--delete
CREATE procedure DeleteSP @PASSENGERID BIGINT
as
begin
delete  ETicket where PASSENGERID=@PASSENGERID
end
exec DeleteSP 22
DROP PROCEDURE DeleteSP


--update
create procedure UpdateSP (@PASSENGERID bigint,@TICKETNUMBER bigint ,@PASSENGERNAME nvarchar(50),@PHNUMBER bigint,@EMAILID nvarchar(50),@JOURNEYDATE datetime2(7))
as
begin
update ETicket 
set TICKETNUMBER=@TICKETNUMBER,PASSENGERNAME=@PASSENGERNAME,PHNUMBER=@PHNUMBER,EMAILID=@EMAILID,JOURNEYDATE=@JOURNEYDATE where PASSENGERID=@PASSENGERID
end
exec UpdateSP 21 ,123,'marry',3456234567,'qwer@gmail.com','05/04/2013'

select * from ETicket

--SELECTALL
create procedure SelectSP
as 
begin
select * from ETicket 
end
exec SelectSP

--selectbyid
create procedure SelectidSP(@PASSENGERID BIGINT)
as 
begin
select * from ETicket where PASSENGERID=@PASSENGERID
end
exec SelectidSP 22