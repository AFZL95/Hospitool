USE [Hospitool]
GO
/****** Object:  StoredProcedure [dbo].[AppointmentManagement]    Script Date: 5/10/2017 3:47:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER PROCEDURE [dbo].[AppointmentManagement]
(

	@AppointmentID int,
    @DoctorID int,
    @PatientID   int,
    @AppointmentDate DATETIME,
    @AppointmentStartdate VARCHAR,
    @AppointmentEnddate VARCHAR,
	@StatementType char(7)

)

 

AS

BEGIN

IF @StatementType = 'Insert'

BEGIN

insert into dbo.Appointments(DoctorID,PatientID,AppointmentDate,AppointmentStartdate,AppointmentEnddate)
 values(@DoctorID,@PatientID,@AppointmentDate,@AppointmentStartdate,@AppointmentEnddate)   

END

 

IF @StatementType = 'Select'

BEGIN

select * from Appointments

END 

 

IF @StatementType = 'Update'

BEGIN

UPDATE Appointments SET

           DoctorID=@DoctorID,PatientID=@PatientID,AppointmentDate=@AppointmentDate,AppointmentStartdate=@AppointmentStartdate,AppointmentEnddate=@AppointmentEnddate

      WHERE AppointmentID = @AppointmentID

END

 

else IF @StatementType = 'Delete'

BEGIN

DELETE FROM Appointments WHERE AppointmentID = @AppointmentID

END

end