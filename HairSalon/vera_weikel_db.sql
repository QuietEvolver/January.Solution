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
  ClientId int(11) NOT NULL AUTO_INCREMENT,
  ClientName varchar(45) DEFAULT NULL,
  ClientTimeSlotRequested varchar(255) DEFAULT NULL,
  ClientTimeSlotBooked varchar(255) DEFAULT NULL,
  StylistId int(11) NOT NULL,
  PRIMARY KEY (ClientId)
)
IF EXISTS DROP TABLE stylysts;
CREATE TABLE stylysts (
  StylistId int(11) NOT NULL AUTO_INCREMENT,
  StylistName varchar(45) DEFAULT NULL,
  StylistSpecialty varchar(255) DEFAULT NULL,
  StylistTimeSlotAvailable varchar(255) DEFAULT NULL,
  StylistTimeSlotBooked varchar(255) DEFAULT NULL,
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