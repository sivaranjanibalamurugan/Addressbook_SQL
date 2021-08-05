Create Procedure InsertingIntoAddressBook
(
  @firstName varchar(200),
  @lastName varchar(200),
  @address varchar(200),
  @city varchar(100),
  @state varchar(100),
  @zipCode bigint,
  @phoneNumber bigint,
  @email varchar(100)
  )
  As
  Begin
  insert into AddressBookTable(firstName,lastName,address,city,state, zipCode,phoneNumber, email)values(@firstName,@lastName,@address,@city,@state, @zipCode,@phoneNumber, @email)
  End