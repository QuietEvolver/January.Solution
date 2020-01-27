-- IF EXISTS DROP DATABASE vera_weikel_db;
-- CREATE DATABASE vera_weikel_db;
-- USE vera_weikel_db;

-- IF EXISTS DROP TABLE clients;  
-- CREATE TABLE clients (
--      id serial PRIMARY KEY, 
--      clientname VARCHAR(255), 
--      clienttimeslotrequested VARCHAR(255), 
-- clienttimeslotbooked VARCHAR(255),  
-- stylistid INT (11));

-- IF EXISTS DROP TABLE stylysts;
-- CREATE TABLE stylysts (id serial PRIMARY KEY, 
-- stylistname VARCHAR(255), 
-- stylistspecialty VARCHAR(255), 
-- description VARCHAR(255), 
-- stylisttimeslotavailable VARCHAR(255), 
-- stylisttimeslotbooked DATETIME, 
-- stylistid INT (11));

IF EXISTS DROP DATABASE vera_weikel_db;
CREATE DATABASE vera_weikel_db;
USE vera_weikel_db;

IF EXISTS DROP TABLE clients;  
CREATE TABLE clients (
  ClientId INT(11) AUTO_INCREMENT PRIMARY KEY NOT NULL,
  ClientName varchar(45) DEFAULT NULL,
  ClientTimeSlotRequested BOOLEAN DEFAULT false,
  ClientTimeSlotBooked BOOLEAN DEFAULT false,
  StylistId int(11) NOT NULL,
  PRIMARY KEY (ClientId)
)
IF EXISTS DROP TABLE stylysts;
CREATE TABLE stylysts (
  StylistId INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  StylistName varchar(45) DEFAULT NULL,
  StylistSpecialty varchar(255) DEFAULT NULL,
  StylistTimeSlotAvailable BOOLEAN DEFAULT false,
  StylistTimeSlotBooked BOOLEAN DEFAULT false,
  Address varchar(45) DEFAULT NULL,
  Phone int(45) DEFAULT NULL,
  ClientId int(11) DEFAULT NULL,
  PRIMARY KEY (StylistId),
  KEY ClientId (ClientId),
  CONSTRAINT Stylists_ibfk_1 FOREIGN KEY (ClientId) REFERENCES Clients (ClientId)
)
-- SET DATEFORMAT mdy;  
-- SELECT TRY_CAST('12/31/2010' AS datetime2) AS Result;  
-- GO
SET DATETIME AppointmentTimeSlot;
SELECT   
     CAST('2007-05-08 12:35:29. 1234567 +12:15' AS time(7)) AS 'Time'   
    ,CAST('2007-05-08 12:35:29. 1234567 +12:15' AS date) AS 'Date' 
GO

-- Insert a set of records.
INSERT INTO clients (ClientName) VALUES ('tom');
INSERT INTO clients (ClientName) VALUES ('chelsea');
INSERT INTO clients (ClientName) VALUES ('randy');
INSERT INTO clients (ClientName) VALUES ('pedro');
INSERT INTO clients (ClientName) VALUES ('barten');
INSERT INTO clients (ClientName, ClientTimeSlotRequested, StylistId) VALUES ('500', true);
INSERT INTO clients (ClientName, ClientTimeSlotBooked,StylistId) VALUES ('430', false);
INSERT INTO clients (ClientName, ClientTimeSlotBooked,StylistId) VALUES ('500', true);
INSERT INTO clients (ClientName) VALUES ('anita');


INSERT INTO stylysts (StylistSpecialty) VALUES ('trim');
INSERT INTO stylysts (StylistSpecialty) VALUES ('buzz cuts');
INSERT INTO stylysts (StylistSpecialty) VALUES ('prom');
INSERT INTO stylysts (StylistSpecialty) VALUES ('pizzaz colors');
INSERT INTO stylysts (StylistSpecialty) VALUES ('mani');
INSERT INTO stylysts (StylistSpecialty, StylistTimeSlotRequested, ClientId) VALUES ('500', true,6);
INSERT INTO stylysts (StylistSpecialty, StylistTimeSlotBooked,ClientId) VALUES ('430', false, 7);
INSERT INTO stylysts (StylistSpecialty, StylistTimeSlotBooked,ClientId) VALUES ('500', true, 8);
INSERT INTO stylysts (StylistSpecialty) VALUES ('pediß');
