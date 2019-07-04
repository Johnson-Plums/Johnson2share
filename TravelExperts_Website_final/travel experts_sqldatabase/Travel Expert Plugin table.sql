create table AgentLogin 
(
AgentID int, 
AgentName Varchar(50),
AgentPassword Varchar(255),
)

INSERT INTO AgentLogin
VALUES (1, 'Josh', '$2a$12$EKW4A77gA9r8ZMFgMh4R5e2KWY2/tgjFlxaCOI14E2NyD6ODonG82');

INSERT INTO AgentLogin
VALUES (2, 'Wei', '$2a$12$fx8PK0Y1B/fg7Enlm691a.BeulJ0k8czXsriwuLzh8XK1KhByS7jy');

insert into Packages_Products_Suppliers
values (5, 888)


INSERT INTO AgentLogin
VALUES (9999, 'Johnson', '$2a$12$NNRZguebv5nALHTlDhTjfe1/NR4Mm3v6pIl3GB03/JGB90ObKDLCW');

select * from AgentLogin
select * from FlightsTable

Update FlightsTable set FltDepart = DateAdd(yy,+1,FltDepart) 
Update FlightsTable set FltReturn = DateAdd(yy,+1,FltReturn) 

select * from Customers
select * from Packages
select * from Packages_Products_Suppliers

insert into Packages_Products_Suppliers 
values(5, '888');



select * from Suppliers

select * from Products_Suppliers

DELETE FROM Products_Suppliers WHERE ProductSupplierId = 95


update Packages set DeparturePlnId = '40331', ReturnPlnId = '40332'
where PackageId =5

INSERT INTO Customers
VALUES ( 145,'Johnson', 'Plums', 'Address','Calgary', 'AB', 't2p1a4', 'Canada', '4034016111','4034016222', 'Johnson@travelagency.ca','9999', 'Johnson', '123456' );

select * from Customers
where CustomerId =144

update Customers set CustFirstName = 'Johnson', CustLastName = 'Plums', CustUsername='Johnson Plums', CustPassword='123456'
where CustomerId = 144