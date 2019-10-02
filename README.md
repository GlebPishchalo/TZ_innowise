# TZ_innowise

create database BooksCatalog
use BooksCatalog

Create table Books(
book_id INT PRIMARY KEY IDENTITY (1, 1),
    book_name VARCHAR (30) NOT NULL,
    year int NOT NULL
    )

Create table Authors(
author_id int primary key IDENTITY (1, 1),
author_name varchar(20) not null)

Create table BAConnect(
book_id int not null,
author_id int not null)

ALTER TABLE BAConnect
   ADD CONSTRAINT FK_BookID FOREIGN KEY (book_id)
      REFERENCES Books (book_id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
      
      Alter AUTHORIZATION ON DATABASE::BooksCatalog TO [sa];
      
      ALTER TABLE BAConnect
   ADD CONSTRAINT FK_AuthorID FOREIGN KEY (author_id)
      REFERENCES Authors (author_id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
