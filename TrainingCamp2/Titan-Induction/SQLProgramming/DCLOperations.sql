Create Database SampleDb;

use SampleDb


Use master;
Drop database SampleDb -- If U want to drop/delete a database, U should exit from the usage and then delete. 

Create table Machine
(
	MacId int primary key identity(1000, 1),
	MacName varchar(200) NOT NULL, 
	MacModel varchar(200) NOT NULL,
	UserName varchar(200) NOT NULL, 
	ExpiryDate date NOT NULL DEFAULT GETDATE() 
)



Drop table Machine --Dont run this as this will delete the table..
SELECT * FROM Machine

----------Commands to execute to get info about ur databases
sp_databases --Stored Proc to get all the databases of UR SQL Server instance. 

sp_tables --To get all the tables of the current database

sp_columns Machine

alter table Machine --To Add and remove columns in the table, we use Alter table command
add Price money 

alter table Machine
Drop column Price --remove the column

--Foreign keys are links that are maintained in the tables. If a table contains data that is repeated set, U can move the data into another table and link that table's primary with the current table's column. This is called as FOREIGN KEY RELATIONS. 

select * from Machine
truncate table Machine --removes all records from a table. truncate ensures that foreign key values are maintaned. If you want to remove those constraints and delete
Delete from machine where MacId > 0 --delete forcefully removes the data. 


---------------------Data Manipulation language----------------
Insert into Machine(MacName, MacModel, UserName) values('SecurityMachine', 'Dell Inspiron 2000', 'komal')
SELECT * FROM MAChine













