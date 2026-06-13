--Data Query Language
SELECT * FROM Machine
SELECT  MacId, MacName from Machine
----SCALAR VALUE FUNCTIONS--------------
SELECT COUNT(*) as MachineCount from Machine --Create an alias/heading to UR generated column. 
SELECT MAX(MacId) as LatestMachine from Machine

SELECT TOP(10) * from Machine --Get the Top 10 records of the table...



Use titanDb
Create table Dept
(
	DeptId int primary key identity(1,1),
	DeptName varchar(200) NOT NULL
)
Alter table Employee
add DeptId int references Dept -- linked DeptTable with Employee Table. 

INSerT INTO Dept values('Admin')
INSerT INTO Dept values('Accounts')
INSerT INTO Dept values('Sales')
INSerT INTO Dept values('HR')

SELECT * FrOM Employee
SELECT * FrOM Dept
Insert into Employee values(10, 'Roshini', 'Chennai', 234243344, 4)--Value for the DeptId column must be those values from the deptTable's DeptID column, else it throws violation of foreign key...

-----------Joins help in combining data of different tables and retrieves the data--------------
SELECT Employee.* , Dept.DeptName from Employee, Dept where Employee.DeptID = Dept.DeptId--equ join...

SElECT FullName, MobileNo, DeptName 
From Employee
JOIN Dept
on Employee.DeptId = Dept.DeptId

Update Employee set DeptId = NULL 
WHERE Employee.Id = 13;


SElECT FullName, MobileNo, COALESCE(DeptName, 'Not Assigned') --If the DeptName does not exist, it sets as Not Assigned. 
From Employee 
left JOIN Dept
on Employee.DeptId = Dept.DeptId

SElECT FullName, MobileNo, DeptName --If the DeptName does not exist, it sets as Not Assigned. 
From Employee 
right JOIN Dept
on Employee.DeptId = Dept.DeptId --gets all the matching employees and all depts including the non matching ones

----group by clause. 
---We want the Employee Count grouped by City
SELECT * FROM Employee
SELECT Address, Count(FullName) as EmpCount from Employee
group by Address
order by EmpCount desc --descending order...
--When using a group by clause, the column that U select should be part of the group by or it should be aggregate function.


--Further to explore: Degrees of Normalization, Nested SELECT Statements, Functions in SQL, Stored Procs, Indexes.

