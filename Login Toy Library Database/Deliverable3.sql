use ajo20_Deliverable3

--STAFF
create table Staff (
staffID int not null primary key, 
staffPassword varChar(30),
loginName varChar(30) Unique,
)

--DIABILITY
create table Disability (
 disabilityID int not null primary key,
 title varChar(30) Unique,
 descriptionInjury varChar(60), 
)

--MEMBERS
create table Membership(
membershipID int not null primary key, 
memberPassword varChar(30),
loginName varChar(30) Unique,
)

--TOY
create table Toy(
toyID int not null primary key,
toyName varChar(25),
toyDescription varChar(30),
purchasedOn varChar(15),
photo image,
replaceCost float, 
origCost float,
libraryLocation varChar(15),
legacyID int,
parts varChar(25),
toyStatus varChar(15),
toyType varChar(15),
--check (toyType= 'book/puzzle' or toyType = 'toy'),
--check (toyStatus= 'available' or toyStatus= 'maintainance' or toyStatus= 'not available'),
--check (libraryLocation= 'backroom' or libraryLocation= 'front room')
)

--CHILDREN
create table Child (
childID int not null primary key, 
note varChar(50), 
languageSpoken varChar(10), 
gender varChar(10),
iwi varChar(30), 
DoB varChar(20),
lname varChar(30), 
fname varChar(30),
membershipID int,
foreign key (membershipID) references Membership
)

--LENDINGS
create table Lending(
lendingID int not null primary key,
lendingDate date,
deadline date,
returnedOn date,
stateOfToy varChar(30),
rating int,
childID int,
toyID int,
foreign key(childID) references Child,
foreign key(toyID) references Toy,
--check (stateOfToy='broken' or stateOfToy='dirty' or stateOfToy='lost' or stateOfToy='parts missing' or stateOfToy='fine'),
--check (rating='1' or rating='2' or rating='3' or rating='4' or rating='5')
)
--CATEGORY
create table Category(
categoryID int not null primary key, 
title varChar(30) Unique,
categoryDescription varChar(60)
)

--HAS
create table Has(
disabilityID int not null,
childID int not null,
foreign key(disabilityID) references Disability,
foreign key(childID) references Child
)

--IS IN 
create table IsIn(
toyID int not null,
categoryID int not null,
foreign key(toyID) references Toy,
foreign key(categoryID) references Category
)

--INSERT STATEMENTS
INSERT INTO Category Values(001,'Active Play','Toy Description Here')
INSERT INTO Category Values(002,'Animals','Toy Description Here')
INSERT INTO Category Values(003,'Asking Questions','Toy Description Here')
INSERT INTO Category Values(004,'Babies','Toy Description Here')
INSERT INTO Category Values(005,'Balance','Toy Description Here')
INSERT INTO Category Values(006,'Books','Toy Description Here')
INSERT INTO Category Values(007,'Cars','Toy Description Here')
INSERT INTO Category Values(008,'CD music','Toy Description Here')
INSERT INTO Category Values(009,'CD story','Toy Description Here')
INSERT INTO Category Values(010,'CDs','Toy Description Here')
INSERT INTO Category Values(011,'Colour','Toy Description Here')
INSERT INTO Category Values(012,'Communcation','Toy Description Here')
INSERT INTO Category Values(013,'Construction','Toy Description Here')
INSERT INTO Category Values(014,'Coordination','Toy Description Here')
INSERT INTO Category Values(015,'Counting','Toy Description Here')
INSERT INTO Category Values(016,'Dancing','Toy Description Here')
INSERT INTO Category Values(017,'Dice','Toy Description Here')
INSERT INTO Category Values(018,'Dinosaurs','Toy Description Here')
INSERT INTO Category Values(019,'Dolls','Toy Description Here')
INSERT INTO Category Values(020,'Dolls house','Toy Description Here')
INSERT INTO Category Values(021,'Dress up','Toy Description Here')
INSERT INTO Category Values(022,'DVD','Toy Description Here')
INSERT INTO Category Values(023,'DVD - Film','Toy Description Here')
INSERT INTO Category Values(024,'DVD - music','Toy Description Here')
INSERT INTO Category Values(025,'Early child hood','Toy Description Here')
INSERT INTO Category Values(026,'Fine Motor','Toy Description Here')
INSERT INTO Category Values(027,'Fire engine','Toy Description Here')
INSERT INTO Category Values(028,'Firemen','Toy Description Here')
INSERT INTO Category Values(029,'Flash cards','Toy Description Here')
INSERT INTO Category Values(030,'Floor play','Toy Description Here')
INSERT INTO Category Values(031,'Floor puzzles','Toy Description Here')
INSERT INTO Category Values(032,'Games','Toy Description Here')
INSERT INTO Category Values(033,'Gardening','Toy Description Here')
INSERT INTO Category Values(034,'Gears','Toy Description Here')
INSERT INTO Category Values(035,'Gross Motor','Toy Description Here')
INSERT INTO Category Values(036,'Hammering','Toy Description Here')
INSERT INTO Category Values(037,'House','Toy Description Here')
INSERT INTO Category Values(038,'Imaginative play','Toy Description Here')
INSERT INTO Category Values(039,'Jumping','Toy Description Here')
INSERT INTO Category Values(040,'Kaleidoscopes','Toy Description Here')
INSERT INTO Category Values(041,'Kitchen','Toy Description Here')
INSERT INTO Category Values(042,'Kits','Toy Description Here')
INSERT INTO Category Values(043,'Light','Toy Description Here')
INSERT INTO Category Values(044,'Literacy','Toy Description Here')
INSERT INTO Category Values(045,'Loud sounds','Toy Description Here')
INSERT INTO Category Values(046,'Machines','Toy Description Here')
INSERT INTO Category Values(047,'Magnets','Toy Description Here')
INSERT INTO Category Values(048,'Marble runs','Toy Description Here')
INSERT INTO Category Values(049,'Maths','Toy Description Here')
INSERT INTO Category Values(050,'Memory','Toy Description Here')
INSERT INTO Category Values(051,'Music','Toy Description Here')
INSERT INTO Category Values(052,'Nature','Toy Description Here')
INSERT INTO Category Values(053,'Outdoor games','Toy Description Here')
INSERT INTO Category Values(054,'Phonetics','Toy Description Here')
INSERT INTO Category Values(055,'Police','Toy Description Here')
INSERT INTO Category Values(056,'Posting','Toy Description Here')
INSERT INTO Category Values(057,'Pretend play','Toy Description Here')
INSERT INTO Category Values(058,'Prisms','Toy Description Here')
INSERT INTO Category Values(059,'Puppets','Toy Description Here')
INSERT INTO Category Values(060,'Puzzles','Toy Description Here')
INSERT INTO Category Values(061,'Ride-on','Toy Description Here')
INSERT INTO Category Values(062,'Role play','Toy Description Here')
INSERT INTO Category Values(063,'Science','Toy Description Here')
INSERT INTO Category Values(064,'Sensory','Toy Description Here')
INSERT INTO Category Values(065,'Singing','Toy Description Here')
INSERT INTO Category Values(066,'Soft sounds','Toy Description Here')
INSERT INTO Category Values(067,'Space','Toy Description Here')
INSERT INTO Category Values(068,'Stacking','Toy Description Here')
INSERT INTO Category Values(069,'Taking turns','Toy Description Here')
INSERT INTO Category Values(070,'Tents','Toy Description Here')
INSERT INTO Category Values(071,'Texture','Toy Description Here')
INSERT INTO Category Values(072,'Threading','Toy Description Here')
INSERT INTO Category Values(073,'Trains','Toy Description Here')
INSERT INTO Category Values(074,'Trucks','Toy Description Here')
INSERT INTO Category Values(075,'Vehicles','Toy Description Here')
INSERT INTO Category Values(076,'Walking','Toy Description Here')
INSERT INTO Category Values(077,'Water play','Toy Description Here')
INSERT INTO Category Values(087,'Words','Toy Description Here')


INSERT INTO Disability Values(001,'ADHD','Attention Deficit Hyperactivity Disorder')
INSERT INTO Disability Values(002,'ASD',' Autism spectrum disorder')
INSERT INTO Disability Values(003,'Asthma',' Disorder Description Here')
INSERT INTO Disability Values(004,'Blind',' Disorder Description Here')
INSERT INTO Disability Values(005,'Cerebral palsy ',' Disorder Description Here')
INSERT INTO Disability Values(006,'Cystic fibrosis',' Disorder Description Here')
INSERT INTO Disability Values(007,'Deaf',' Disorder Description Here')
INSERT INTO Disability Values(008,'Developmental delay',' Disorder Description Here')
INSERT INTO Disability Values(009,'Downs syndrome',' Disorder Description Here')
INSERT INTO Disability Values(010,'Dyslexia',' Disorder Description Here')
INSERT INTO Disability Values(011,'Epilepsy',' Disorder Description Here')
INSERT INTO Disability Values(012,'Traumatic brain injury',' Disorder Description Here')
INSERT INTO Disability Values(013,'Intellectual disability',' Disorder Description Here')
INSERT INTO Disability Values(014,'Multiple Sclerosis (MS)',' Disorder Description Here')
INSERT INTO Disability Values(015,'Muscular Dystrophy',' Disorder Description Here')
INSERT INTO Disability Values(016,'Paraplegia',' Disorder Description Here')
INSERT INTO Disability Values(017,'Parkinsons disease',' Disorder Description Here')
INSERT INTO Disability Values(018,'Physical disability',' Disorder Description Here')
INSERT INTO Disability Values(019,'Quadriplegia ',' Disorder Description Here')

INSERT INTO Membership Values(123, 'pass1','john1')
INSERT INTO Membership Values(245, 'pass2','sammy2')
INSERT INTO Membership Values(422, 'pass3','piri3')

INSERT INTO Child Values(001,'Child has tendancy to damage toys', 'English','Male', 'No Iwi', '10-09-2012','Smith', 'John',123)
INSERT INTO Child Values(002,'This child shares toys with siblings', 'Mandarin', 'Male', 'No Iwi', '11-07-2014','Mark', 'Lawrence',245)
INSERT INTO Child Values(003,'Does not like Maths toys', 'Maori', 'Female','Te Aupōuri', '06-01-2013','Wiri', 'Jo',422)

INSERT INTO Toy Values(4342, 'Buzz Lightyear', 'Toy Story Figure', '12-09-2010',null, 32.90,25.90,'front room', 13145635,'Helmet, Lasers', 'available', 'toy')
INSERT INTO Toy Values(2345, 'Lightning McQueen', 'Car', '11-12-2011', null, 17.90,10.90,'front room', 32423452,'Racing Wheels', 'available', 'toy')
INSERT INTO Toy Values(1235, '1001 Puzzle Pieces', 'Puzzle game', '09-03-2016', null, 40.90,29.90,'backroom', 65389768,'1001 pieces of puzzle', 'maintainance', 'book/puzzle')
INSERT INTO Toy Values(2456, 'Hairy Maclary', 'Book', '01-04-2009', null,22.90,20.90,'backroom', 23425233,'302 pages', 'available', 'book/puzzle')
INSERT INTO Toy Values(8976, 'Bob the Builder Kit', 'Set of Bob the Builder tools', '11-04-2017',null, 15.90,10.90,'front room', 74563523,'Plastic Hammer, Wrench', 'available', 'toy')

INSERT INTO Staff Values(1234, 'bobross1', 'bobr')
INSERT INTO IsIn Values(4342, 019)
INSERT INTO IsIn Values(2345, 007)
INSERT INTO IsIn Values(2456,006)
INSERT INTO IsIn Values(8976, 074)

INSERT INTO Lending Values(001, '2018-06-04', '2018-06-18', '2018-06-7', 'dirty', 2, 001, 4342)
INSERT INTO Lending Values(002, '2018-06-06', '2018-06-20', '2018-06-8', 'broken', 2, 002, 8976)

Begin transaction
	UPDATE Toy Set toyStatus = 'not available' Where toyID = 4342
rollback transaction


--Select toyName from Toy where toyID in(Select toyID from IsIn where categoryID in(Select categoryID from Category where title like 'Dolls'))
Select toyName from Toy where toyStatus like 'available'
Update Toy set toyStatus = 'available' where toyID = 4342
Update Toy set toyStatus = 'available' where toyID = 2345
Update Toy set toyStatus = 'available' where toyID = 2456
Update Toy set toyStatus = 'available' where toyID = 8976

--SELECT STATEMENTS
Select* from Membership
Select * from Disability
Select * from Child
Select * from Category    
Select * from Toy
Select * from Staff
Select * from IsIn
Select * from Lending

--DROP TABLE STATEMENTS
Drop Table Membership
Drop Table Has
Drop Table IsIn
Drop Table Lending
Drop Table Toy
Drop Table Category
Drop Table Disability
Drop Table Child
Drop Table Staff