--2.a Get All Student who attend at '2020-06-15','2020-06-17'
select a.*, s.[Name]  from [dbo].[Absensi] a
LEFT JOIN student s ON s.Nim=a.Nim
WHERE thedate IN('2020-06-15','2020-06-17') 

--2b. get number of school attendance on eac student between '2020-06-15' to '2020-06-17' period
SELECT *, (SELECT count(thedate) FROM Absensi a WHERE a.Nim=s.Nim 
and thedate BETWEEN '2020-06-15' AND '2020-06-17') as NumberOfAttendance 
from student s


--5 Flowchart online action dengan fitur 
    --a. product listing
    --b. product auction 

    --q1 : teknologi yg dipakai : .Net Core dan SQL Server
    