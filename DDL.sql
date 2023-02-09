Use MOYO_DB
Go

DROP TABLE IF EXISTS  Contact
DROP TABLE IF EXISTS Staff_Role
DROP TABLE IF EXISTS Role
DROP TABLE IF EXISTS Staff
DROP TABLE IF EXISTS Areas_Of_Concern
DROP TABLE IF EXISTS Goals
DROP TABLE IF EXISTS Interests
DROP TABLE IF EXISTS IntakeForm
DROP TABLE IF EXISTS Schedule
DROP TABLE IF EXISTS Customers
DROP TABLE IF EXISTS Appointment




create table Customers
(
	CustomerID int not null IDENTITY(1, 1)
		constraint PK_Customers_CustomerID primary key clustered,
	FirstName char(150) not null,
	LastName char(150) not null,
	Street char(250) not null,
	City char(200) not null,
	Province char(100) not null,
	PostalCode char(10) null,
	/* not sure if i should put a check constraint on here?? we discussed US AND CANADA, How would we be able to establish states information ??? */
	DateOfBirth date not null, 
		/* constraint CK_Customer_DateOfBirth check (DateOfBirth)  waiting for client to send a response on age limit (> 18) */
	Phone_Number char(10) not null
		constraint CK_Customers_PhoneNumber check (Phone_Number like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	/* Should phone number remain 10 digits?? People use different format when it comes to typing phone numbers  */
	Email varchar(350) not null
		constraint CK_Customers_Email check (Email like '%@%'),
	Hobbies varchar(350) null,
	Occupation varchar(300) null
)

create table Contact
(
	ContactID int not null IDENTITY(1, 1)
		constraint PK_Contact_ContactID primary key clustered,
	CustomerID int not null
		constraint FK_Contact_CustomerID references Customers(CustomerID),
	FirstName char(150) not null,
	LastName char(150) not null,
	Phone_Number char(10) not null
		constraint CK_Contact_PhoneNumber check (Phone_Number like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Email char(350) not null
		constraint CK_Contact_Email check (Email like '%@%'),
	Relationship char(150) not null
)

create table Staff
(
	StaffID int not null IDENTITY(1, 1)
		constraint PK_Staff_StaffID primary key clustered,
	FirstName char(100) not null,
	LastName char(100) not null,
	Phone_Number char(10) not null
		constraint CK_Staff_PhoneNumber check (Phone_Number like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Email char(350) not null
		constraint CK_Staff_Email check (Email like '%@%'),
	YearsOfExperience int not null
)

create table Role
(
	RoleID int not null IDENTITY(1, 1)
		constraint PK_Role_RoleID primary key clustered,
	RoleName char(150) not null,
	Description char(255) not null,
	CreatedBy int not null
		constraint FK_Role_CreatedBy references Staff(StaffID)
)

create table Staff_Role	
(
	StaffRoleID int not null IDENTITY(1, 1)
		constraint PK_StaffRole_StaffRoleID primary key clustered,
	StaffID int not null
		constraint FK_StaffRole_StaffID references Staff(StaffID),
	RoleID int not null
		constraint FK_StaffRole_RoleID references Role(RoleID)
)

create table Schedule
(
	CalenderID int not null IDENTITY(1, 1)
		constraint PK_Schedule_CalenderID primary key clustered,
		AppointmentDate date not null,
	AppointmentStartDate time not null,
	AppointmentEndDate time not null,
	StaffID int not null
		constraint FK_Schedule_StaffID references Staff(StaffID),
		TotalNumberOfParticipants int not null,
	/* added Staff Id and moved total number of participants from booking to schedule
	*/
	Status BIT not null
		constraint DF_Schedule_Status default 0
		constraint CK_Schedule_Status check (Status IN (1,0))
)

create table Appointment
(
	BookingID int not null IDENTITY(1, 1)
		constraint PK_Appointment_BookingID primary key clustered,
	CustomerID int null
		constraint FK_Appointment_CustomerID references Customers(CustomerID),
	FirstName char(150) not null,
	LastName char(150) not null,
	Email char(350) not null
		constraint CK_Appointment_Email check (Email like '%@%'),	
		WaiverSigned BIT not null,
		witness null,
	CalenderID int not null
		constraint FK_Appointment_CalenderID references Schedule(CalenderID),
	Status char(50) not null
		constraint DF_Appointment_Status default 'Pending'
)

create table Areas_Of_Concern
(
	ID int not null IDENTITY(1, 1)
		constraint PK_Areas_Of_Concern_ID primary key clustered,
	BookingID int not null
		constraint FK_Areas_Of_Concern_BookingID references Appointment(BookingID),
	Arms BIT not null
		constraint DF_Areas_Of_Concern_Arms default 0
		constraint CK_Areas_Of_Concern_Arms check (Arms IN (1,0)),
	Chest BIT not null
		constraint DF_Areas_Of_Concern_Chest default 0
		constraint CK_Areas_Of_Concern_Chest check (Chest IN (1,0)),
	Feet BIT not null
		constraint DF_Areas_Of_Concern_Feet default 0
		constraint CK_Areas_Of_Concern_Feet check (Feet IN (1,0)),
	Head BIT not null
		constraint DF_Areas_Of_Concern_Head default 0
		constraint CK_Areas_Of_Concern_Head check (Head IN (1,0)),
	Hip BIT not null
		constraint DF_Areas_Of_Concern_Hip default 0
		constraint CK_Areas_Of_Concern_Hip check (Hip IN (1,0)),
	Knees BIT not null
		constraint DF_Areas_Of_Concern_Knees default 0
		constraint CK_Areas_Of_Concern_Knees check (Knees IN (1,0)),
	Legs BIT not null
		constraint DF_Areas_Of_Concern_Legs default 0
		constraint CK_Areas_Of_Concern_Legs check (Legs IN (1,0)),
	Neck BIT not null
		constraint DF_Areas_Of_Concern_Neck default 0
		constraint CK_Areas_Of_Concern_Neck check (Neck IN (1,0))
)

create table Goals	
(
	ID int not null IDENTITY(1, 1)
		constraint PK_GoalID primary key clustered,
	GoalDescription VARCHAR(300) NOT NULL,
	CreatedDate Date NOT NULL,
	[LastModifiedDate] [date] NOT NULL)
		ALTER TABLE [dbo].Goals ADD  CONSTRAINT [DF_Goals_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].Goals ADD  CONSTRAINT [DF_Goals_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO

	create table Interests	
(
	[ID] [int] IDENTITY(1,1) NOT NULL
		constraint PK_InterestID primary key clustered,
	[InterestDesc] [varchar](250) NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[LastModifiedDate] [date] NOT NULL
	)
	ALTER TABLE [dbo].[Interests] ADD  CONSTRAINT [DF_Interests_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[Interests] ADD  CONSTRAINT [DF_Interests_LastModifiedDate]  DEFAULT (getdate()) FOR [LastModifiedDate]
GO

create table IntakeForm
(
	IntakeFormID int not null IDENTITY(1, 1)
		constraint PK_IntakeForm_FormID primary key clustered,
	CustomerID int not null
		constraint FK_IntakeForm_CustomerID references Customers(CustomerID),
	BookingID int not null
		constraint FK_IntakeForm_BookingID references Appointment(BookingID),
	Injuries char(350) null,   
	HealthConcerns char(350) not null,
	Goals TEXT not null,
	YogaInterests TEXT null,
	RatePhysicalActivity int not null, 
	RateStress int not null,   
	Comfortable_Self_Assessment int not null, 
	Practice_Self_Assessment int not null,  
	Health_conditions_Recently_Past TEXT null,
	Concerns_Hopes_Goals_Anticipations TEXT null
)

