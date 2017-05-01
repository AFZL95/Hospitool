
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/18/2017 11:22:04
-- Generated from EDMX file: C:\Users\FZL\Desktop\Hospitool\Hospitool\HospitoolDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Hospitool];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Appointment_Doctor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_Appointment_Doctor];
GO
IF OBJECT_ID(N'[dbo].[FK_Appointment_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointment] DROP CONSTRAINT [FK_Appointment_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_Labtest_Labworker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Labtest] DROP CONSTRAINT [FK_Labtest_Labworker];
GO
IF OBJECT_ID(N'[dbo].[FK_Labtest_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Labtest] DROP CONSTRAINT [FK_Labtest_Patient];
GO
IF OBJECT_ID(N'[dbo].[FK_Payment_Patient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Patient];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admin];
GO
IF OBJECT_ID(N'[dbo].[Appointment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointment];
GO
IF OBJECT_ID(N'[dbo].[Bed]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bed];
GO
IF OBJECT_ID(N'[dbo].[Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctor];
GO
IF OBJECT_ID(N'[dbo].[Labtest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Labtest];
GO
IF OBJECT_ID(N'[dbo].[Labworker]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Labworker];
GO
IF OBJECT_ID(N'[dbo].[Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patient];
GO
IF OBJECT_ID(N'[dbo].[Payment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payment];
GO
IF OBJECT_ID(N'[dbo].[Receptionist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receptionist];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Admins'
CREATE TABLE [dbo].[Admins] (
    [AdminID] int IDENTITY(1,1) NOT NULL,
    [AdminTC] nvarchar(11)  NOT NULL,
    [AdminPassword] nvarchar(50)  NOT NULL,
    [AdminName] nvarchar(50)  NOT NULL,
    [AdminSurname] nvarchar(50)  NOT NULL,
    [AdminEmail] nvarchar(100)  NOT NULL,
    [AdminMobile1] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Beds'
CREATE TABLE [dbo].[Beds] (
    [BedID] int IDENTITY(1,1) NOT NULL,
    [PatientID] int  NOT NULL,
    [ReceptionistID] int  NOT NULL,
    [BedRentSDate] varchar(15)  NOT NULL,
    [BedRentEDate] varchar(15)  NOT NULL,
    [BedRegDate] datetime  NOT NULL
);
GO

-- Creating table 'Doctors'
CREATE TABLE [dbo].[Doctors] (
    [DoctorID] int IDENTITY(1,1) NOT NULL,
    [DoctorName] nvarchar(50)  NOT NULL,
    [DoctorSurname] nvarchar(50)  NOT NULL,
    [DoctorTC] nvarchar(11)  NOT NULL,
    [DoctorAddress1] nvarchar(400)  NOT NULL,
    [DoctorAddress2] nvarchar(400)  NULL,
    [DoctorMobile1] nvarchar(25)  NOT NULL,
    [DoctorMobile2] nvarchar(25)  NULL,
    [DoctorGender] nvarchar(2)  NOT NULL,
    [DoctorAge] int  NOT NULL,
    [DoctorEmail] nvarchar(100)  NOT NULL,
    [DoctorField] nvarchar(100)  NOT NULL,
    [DoctorPassword] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Labworkers'
CREATE TABLE [dbo].[Labworkers] (
    [LabworkerID] int IDENTITY(1,1) NOT NULL,
    [LabworkerName] nvarchar(50)  NOT NULL,
    [LabworkerSurname] nvarchar(50)  NOT NULL,
    [LabworkerTC] nvarchar(11)  NOT NULL,
    [LabworkerAddress1] nvarchar(400)  NOT NULL,
    [LabworkerAddress2] nvarchar(400)  NULL,
    [LabworkerMobile1] nvarchar(25)  NOT NULL,
    [LabworkerMobile2] nvarchar(25)  NULL,
    [LabworkerGender] nvarchar(2)  NOT NULL,
    [LabworkerAge] int  NOT NULL,
    [LabworkerEmail] nvarchar(100)  NOT NULL,
    [LabworkerPassword] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [PatientID] int IDENTITY(1,1) NOT NULL,
    [PatientName] nvarchar(50)  NOT NULL,
    [PatientSurname] nvarchar(50)  NOT NULL,
    [PatientTC] nvarchar(11)  NOT NULL,
    [PatientAddress1] nvarchar(400)  NOT NULL,
    [PatientAddress2] nvarchar(400)  NULL,
    [PatientMobile1] nvarchar(25)  NOT NULL,
    [PatientMobile2] nvarchar(25)  NULL,
    [PatientGender] nvarchar(2)  NOT NULL,
    [PatientDateAdmitted] datetime  NULL,
    [PatientDateDischarged] datetime  NULL,
    [PatientAge] int  NOT NULL,
    [PatientEmail] nvarchar(100)  NOT NULL,
    [PatientIsDischarged] bit  NULL,
    [PatientPassword] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Receptionists'
CREATE TABLE [dbo].[Receptionists] (
    [ReceptionistID] int IDENTITY(1,1) NOT NULL,
    [ReceptionistName] nvarchar(50)  NOT NULL,
    [ReceptionistSurname] nvarchar(50)  NOT NULL,
    [ReceptionistTC] nvarchar(11)  NOT NULL,
    [ReceptionistAddress1] nvarchar(400)  NOT NULL,
    [ReceptionistAddress2] nvarchar(400)  NULL,
    [ReceptionistMobile1] nvarchar(25)  NOT NULL,
    [ReceptionistMobile2] nvarchar(25)  NULL,
    [ReceptionistGender] nvarchar(2)  NOT NULL,
    [ReceptionistAge] int  NOT NULL,
    [ReceptionistEmail] nvarchar(100)  NOT NULL,
    [ReceptionistPassword] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Labtests'
CREATE TABLE [dbo].[Labtests] (
    [LabtestID] int IDENTITY(1,1) NOT NULL,
    [LabtestDate] datetime  NOT NULL,
    [PatientID] int  NOT NULL,
    [LabworkerID] int  NOT NULL,
    [LabtestStoredFile] varbinary(max)  NOT NULL,
    [LabtestFiletype] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Appointments'
CREATE TABLE [dbo].[Appointments] (
    [AppointmentID] int IDENTITY(1,1) NOT NULL,
    [DoctorID] int  NOT NULL,
    [PatientID] int  NOT NULL,
    [AppointmentDate] datetime  NOT NULL,
    [AppointmentStartdate] varchar(15)  NOT NULL,
    [AppointmentEnddate] varchar(15)  NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [PaymentID] int IDENTITY(1,1) NOT NULL,
    [PaymentName] nvarchar(50)  NOT NULL,
    [PaymentSurname] nvarchar(50)  NOT NULL,
    [PaymentCredircard] nvarchar(50)  NOT NULL,
    [PaymentCVV] nvarchar(5)  NOT NULL,
    [PaymentExpiration] nvarchar(50)  NOT NULL,
    [PaymentCost] decimal(19,4)  NOT NULL,
    [PatientID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AdminID] in table 'Admins'
ALTER TABLE [dbo].[Admins]
ADD CONSTRAINT [PK_Admins]
    PRIMARY KEY CLUSTERED ([AdminID] ASC);
GO

-- Creating primary key on [BedID] in table 'Beds'
ALTER TABLE [dbo].[Beds]
ADD CONSTRAINT [PK_Beds]
    PRIMARY KEY CLUSTERED ([BedID] ASC);
GO

-- Creating primary key on [DoctorID] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [PK_Doctors]
    PRIMARY KEY CLUSTERED ([DoctorID] ASC);
GO

-- Creating primary key on [LabworkerID] in table 'Labworkers'
ALTER TABLE [dbo].[Labworkers]
ADD CONSTRAINT [PK_Labworkers]
    PRIMARY KEY CLUSTERED ([LabworkerID] ASC);
GO

-- Creating primary key on [PatientID] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([PatientID] ASC);
GO

-- Creating primary key on [ReceptionistID] in table 'Receptionists'
ALTER TABLE [dbo].[Receptionists]
ADD CONSTRAINT [PK_Receptionists]
    PRIMARY KEY CLUSTERED ([ReceptionistID] ASC);
GO

-- Creating primary key on [LabtestID] in table 'Labtests'
ALTER TABLE [dbo].[Labtests]
ADD CONSTRAINT [PK_Labtests]
    PRIMARY KEY CLUSTERED ([LabtestID] ASC);
GO

-- Creating primary key on [AppointmentID] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [PK_Appointments]
    PRIMARY KEY CLUSTERED ([AppointmentID] ASC);
GO

-- Creating primary key on [PaymentID] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([PaymentID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LabworkerID] in table 'Labtests'
ALTER TABLE [dbo].[Labtests]
ADD CONSTRAINT [FK_Labtest_Labworker]
    FOREIGN KEY ([LabworkerID])
    REFERENCES [dbo].[Labworkers]
        ([LabworkerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Labtest_Labworker'
CREATE INDEX [IX_FK_Labtest_Labworker]
ON [dbo].[Labtests]
    ([LabworkerID]);
GO

-- Creating foreign key on [PatientID] in table 'Labtests'
ALTER TABLE [dbo].[Labtests]
ADD CONSTRAINT [FK_Labtest_Patient]
    FOREIGN KEY ([PatientID])
    REFERENCES [dbo].[Patients]
        ([PatientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Labtest_Patient'
CREATE INDEX [IX_FK_Labtest_Patient]
ON [dbo].[Labtests]
    ([PatientID]);
GO

-- Creating foreign key on [DoctorID] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_Appointment_Doctor]
    FOREIGN KEY ([DoctorID])
    REFERENCES [dbo].[Doctors]
        ([DoctorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Appointment_Doctor'
CREATE INDEX [IX_FK_Appointment_Doctor]
ON [dbo].[Appointments]
    ([DoctorID]);
GO

-- Creating foreign key on [PatientID] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_Appointment_Patient]
    FOREIGN KEY ([PatientID])
    REFERENCES [dbo].[Patients]
        ([PatientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Appointment_Patient'
CREATE INDEX [IX_FK_Appointment_Patient]
ON [dbo].[Appointments]
    ([PatientID]);
GO

-- Creating foreign key on [PatientID] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [FK_Payment_Patient]
    FOREIGN KEY ([PatientID])
    REFERENCES [dbo].[Patients]
        ([PatientID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Payment_Patient'
CREATE INDEX [IX_FK_Payment_Patient]
ON [dbo].[Payments]
    ([PatientID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------