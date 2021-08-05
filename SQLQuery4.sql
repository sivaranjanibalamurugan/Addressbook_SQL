create Procedure RetriveData
(
@city varchar(50),
@state varchar(100),
@firstName varchar(100),
@lastName varchar(100)
)
as
begin 
select * from AddressBookTable where city = 'madurai' order by(lastName)
select * from AddressBookTable where state = 'Tamil Nadu' order by (firstName)
end