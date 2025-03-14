use [online Library]
Go

create table student 
(
 id int  identity(1,1)primary key,
 fname varchar(30) not null,
 mname varchar(30) not null,
 lname varchar(30) not null,
 email varchar(30) not null,
 pass varchar(30) not null,
 gender varchar(30) not null
 )

 create table [admin]
 (
 id varchar(30) primary key ,
 [name] varchar(30) not null,
 email varchar(30) not null,
 pass varchar(30) not null,
 gender varchar(30) not null,
 [role] varchar(30) not null,
 department varchar(30) not null  
 )


 create table category
 (
   [Name] int not null,
   classificationCode int primary key,
   BooksCount int DEFAULT 0
 )
 create table author
 (
   [Name] varchar(30) not null,
   id int primary key,
   nationality varchar(30)  not null
 )
  create table publisher
 (
   [Name] varchar(30) not null,
   id int primary key,
 )

 
create table book
(
  ISBN int primary key,
  Tittle varchar(30) not null , 
  numOfPage varchar(30) not null , 
  categoryId varchar(30) not null,
  authorId varchar(30) not null,
  publisherId varchar(30) not null,
  adminId varchar(30) not null,
  studentId varchar(30),
  startdate date ,
  enddate date ,
  FOREIGN KEY (categoryId) REFERENCES category(classificationCode),
  FOREIGN KEY (authorId) REFERENCES author(id),
  FOREIGN KEY (publisherId) REFERENCES publisher(id),
  FOREIGN KEY (adminId) REFERENCES [admin](id),
  FOREIGN KEY (studentId) REFERENCES student(id),
  )

  create table waitingList
  (

    daysleft int not null , 
	joindate date not null,
	studentId int not null,
	bookId varchar(30) not null,
	FOREIGN KEY (studentId) REFERENCES student(id),
	FOREIGN KEY (bookId) REFERENCES book(ISBN)
	)

	drop table waitingList;
	create table studRequest 
	(
	 reqID varchar(30) primary key , 
	 studentId int not null,
	bookId int not null,
	stutes varchar(30) not null,
	FOREIGN KEY (studentId) REFERENCES student(id),
	FOREIGN KEY (bookId) REFERENCES book(ISBN)
	)

	CREATE TABLE watinglist (
    studentId int NOT NULL,
    bookId int NOT NULL,
    Date DATE NOT NULL,
    daysLeft INT NOT NULL,
    PRIMARY KEY (studentId, bookId),
    FOREIGN KEY (studentId) REFERENCES student(id),
    FOREIGN KEY (bookId) REFERENCES book(ISBN)
); 

insert into admin( id,
 [name] ,
 email ,
 pass,
 gender,
 [role] ,
 department)values(9,'sa','a@',46,'ssc','asc','ac');
insert into book(ISBN,Tittle,numOfPage,categoryId,publisherId,adminId,authorId)values(1,'ff',2005,33,6,9,5);