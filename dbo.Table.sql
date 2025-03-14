CREATE TABLE watinglist (
    studentId VARCHAR(30) NOT NULL,
    bookId VARCHAR(30) NOT NULL,
    Date DATE NOT NULL,
    daysLeft INT NOT NULL,
    PRIMARY KEY (studentId, bookId),
    FOREIGN KEY (studentId) REFERENCES student(id)
	on delete cascade
	on update cascade ,
    FOREIGN KEY (bookId) REFERENCES book(ISBN)
	on delete cascade
	on update cascade 
); 