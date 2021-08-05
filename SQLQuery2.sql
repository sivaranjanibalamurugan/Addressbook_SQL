create Procedure EditPhoneNumber
(
@personId int,
@firstName varchar(50),
@phoneNumber int
)
as
begin
update AddressBookTable set phoneNumber=54632150987 where personId= 5 and firstName ='Rathna'
end