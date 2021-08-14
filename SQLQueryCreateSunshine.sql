CREATE DATABASE SunshineVietnam
GO

CREATE TABLE RoleUser(
	Id int IDENTITY(1,1) PRIMARY KEY,
	NameRole varchar(5) NOT NULL
);
CREATE TABLE City(
	Id int IDENTITY(1,1) PRIMARY KEY,
	NameCity varchar(max) NOT NULL
);
CREATE TABLE District(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdCity int FOREIGN KEY REFERENCES City(Id) NOT NULL,
	NameDistrict varchar(max) NOT NULL
);
CREATE TABLE Ward(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdDistrict int FOREIGN KEY REFERENCES District(Id) NOT NULL,
	NameWard varchar(max) NOT NULL
);

CREATE TABLE Users(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdRole int FOREIGN KEY REFERENCES RoleUser(Id) NOT NULL,
	NameUser varchar(max) NOT NULL,
	Phone varchar(11) NOT NULL,
	Gender bit NOT NULL,
	Street varchar(max) NOT NULL,
	IdWard int FOREIGN KEY REFERENCES Ward(Id) NOT NULL,
	IdDistrict int FOREIGN KEY REFERENCES District(Id) NOT NULL,
	IdCity int FOREIGN KEY REFERENCES City(Id) NOT NULL
);

CREATE TABLE Posts(
	Id int IDENTITY(1,1) PRIMARY KEY,
	TimePost datetime NOT NULL,
	IdUser int FOREIGN KEY REFERENCES Users(Id) NOT NULL,
	Content varchar(max) NOT NULL,
	Street varchar(max) NOT NULL,
	IdWard int FOREIGN KEY REFERENCES Ward(Id) NOT NULL,
	IdDistrict int FOREIGN KEY REFERENCES District(Id) NOT NULL,
	IdCity int FOREIGN KEY REFERENCES City(Id) NOT NULL,
	StatePost varchar(10) CHECK (StatePost='unchecked' OR StatePost='checked' OR StatePost='solved')
);

CREATE TABLE Images(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdPost int FOREIGN KEY REFERENCES Posts(Id) NOT NULL,
	PathImage varchar(max) NOT NULL
);

CREATE TABLE Plans(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdPost int FOREIGN KEY REFERENCES Posts(Id) NOT NULL,
	TimePlan datetime NOT NULL,
	Purpose varchar(max) NOT NULL,
	Budget decimal NOT NULL,
	Street varchar(max) NOT NULL,
	IdWard int FOREIGN KEY REFERENCES Ward(Id) NOT NULL,
	IdDistrict int FOREIGN KEY REFERENCES District(Id) NOT NULL,
	IdCity int FOREIGN KEY REFERENCES City(Id) NOT NULL
);

CREATE TABLE Sponsor(
	Id int IDENTITY(1,1) PRIMARY KEY,
	IdUser int FOREIGN KEY REFERENCES Users(Id) NOT NULL,
	Budget decimal NOT NULL,
	TimeSponsor datetime NOT NULL
);
