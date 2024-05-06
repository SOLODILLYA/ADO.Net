create proc AddNewEmpProc
	@empName nvarchar(50),
	@birthDay date,
	@position nvarchar(50),
	@salary money,
	@imagePath nvarchar(50),
	@departmentId int
as
begin
	insert into Employees values
		(@empName, @birthDay, @position, @salary, @imagePath, @departmentId);
end;
go

create proc GetAllEmployeesProc
as
begin
	select * from Employees;
end;