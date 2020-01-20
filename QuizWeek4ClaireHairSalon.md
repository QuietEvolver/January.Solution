
As the salon owner, I need to be able to see a list of all stylists.
As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
As the salon owner, I need to add new stylists to our system when they are hired.
As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.
Requirements
Naming
Use your first name and last name to name your databases in the following way:

Production Database: first_last
Use the following names for your directories:

Main Project Folder: HairSalon
Documentation
Include detailed setup instructions with all commands necessary to re-create your databases, columns, and tables in your README (example below from To Do):

Using MySQL:

> CREATE DATABASE to_do;
> USE to_do;
> CREATE TABLE categories (id serial PRIMARY KEY, name VARCHAR(255));
> CREATE TABLE tasks (id serial PRIMARY KEY, description VARCHAR(255));
Objectives
Your code will be reviewed for the following objectives:

Do the database table and column names follow both the specific requirements for this project and general .NET naming conventions?
Are the instructions for re-creating your database thorough and clear?
Is there a one-to-many relationship set up correctly in the database?
Is CREATE functionality included for one class and is CREATE and VIEW functionality included for the other class?
Is Entity used for communication with the database?
Have all of the standards from previous weeks been met? (See below)
Does the project demonstrate understanding of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology?
Is the project in a polished, portfolio-quality state?
Was required functionality in place by the Friday deadline?
Previous Objectives
For reference, here are the previous weeks' objectives:

Project uses two or more controllers.
GET and POST requests/responses are used successfully.
MVC routes follow RESTful conventions.
Logic is easy to understand.
Build files are included in .gitignore file and are not be tracked by Git
Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README).
Further Exploration
If you complete all objectives with time to spare, consider adding the following features (make sure to add tests when necessary):

Include a form where employees may search for a stylist by name. Display a list of all results.
Include a form where employees may also search for a client by name. Display a list of all results.
Add a feature for adding an appointment to a client.
Add a feature for adding an appointment to a stylist. Add a check to make sure the stylist does not have any conflicting appointments.
Add a feature for keeping track of how much each stylist was paid for each appointment.
Add styling to your page.
Submission
<hr>

Submit your code for review to the Database Basics code review on Epicenter.

Visit code review requirements for details on how to submit your code, how feedback works and course completion requirements.

Objectives
Your project will be reviewed on the following objectives:
Do the database table and column names follow both the specific requirements for this project and general .NET naming conventions?

Are the instructions for re-creating your database thorough and clear?

Is there a one-to-many relationship set up correctly in the database?

Is CREATE functionality included for one class and is CREATE and VIEW functionality included for the other class?






