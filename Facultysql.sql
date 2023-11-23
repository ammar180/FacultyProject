CREATE DATABASE FacultyDB;
use FacultyDB;

create table FacultyEmployee(
	fac_Name varchar(50) ,
	fac_Address varchar(50),
	fac_Age varchar(50),
	fac_Depa varchar(50)

	primary key (fac_Name)
);
insert into FacultyEmployee values
('Ahmed', '6 Octoper City', '16', 'Elsewedy Electric'),
('Mostafa', 'Giza', '20', 'Elsewedy Electrometer'),
('Eng.Mahmoud', 'Ciro', '23', 'Elsewedy Electrometer'),
('Eng.Khaled', 'Ciro', '16', 'Elsewedy Electric')

select * from FacultyEmployee