USE [Hospitool]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateDelete]    Script Date: 4/23/2017 1:19:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER PROCEDURE [dbo].[Appointments]
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

insert into dbo.Appointments(AppointmentID,DoctorID,PatientID,AppointmentDate,AppointmentStartdate,AppointmentEnddate)
 values(@AppointmentID,@DoctorID,@PatientID,@AppointmentDate,@AppointmentStartdate,@AppointmentEnddate,@StatementType)   

END

 

IF @StatementType = 'Select'

BEGIN

select * from dbo.tblStudent

END 

 

IF @StatementType = 'Update'

BEGIN

UPDATE tblStudent SET

           StudentCode=@StudentCode , Name=@Name , Family=@Family , FatherName= @FatherName , Nationalid=@Nationalid , IDCode=@IDcode , Phone=@Phone , Address=@Address

      WHERE id = @id

END

 

else IF @StatementType = 'Delete'

BEGIN

DELETE FROM tblStudent WHERE id = @id

END

end