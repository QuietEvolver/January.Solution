IF EXISTS DROP DATABASE vera_weikel_db;
CREATE DATABASE vera_weikel_db;
USE vera_weikel_db;

IF EXISTS DROP TABLE clients;  
CREATE TABLE clients (id serial PRIMARY KEY, clientname VARCHAR(255), clienttimeslotrequested VARCHAR(255), clienttimeslotbooked VARCHAR(255),  stylistid INT (11));

IF EXISTS DROP TABLE stylysts;
CREATE TABLE stylysts (id serial PRIMARY KEY, stylistname VARCHAR(255), stylistspecialty VARCHAR(255), description VARCHAR(255), stylisttimeslotavailable VARCHAR(255), stylisttimeslotbooked DATETIME, stylistid INT (11));