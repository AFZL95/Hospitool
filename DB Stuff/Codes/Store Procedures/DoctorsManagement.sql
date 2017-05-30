USE [Hospitool]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create PROCEDURE [dbo].[DoctorsManagement]
(

	@DoctorID int,
	@DoctorName nvarchar(50),
	@DoctorSurname nvarchar(50),
	@DoctorTC nvarchar(11),
	@DoctorAddress1 nvarchar(400),
	@DoctorAddress2 nvarchar(400),
	@DoctorMobile1 nvarchar(25),
	@DoctorMobile2 nvarchar(25),
	@DoctorGender nvarchar(3),
	@DoctorAge int,
	@DoctorEmail nvarchar(100),
	@DoctorField nvarchar(100),
	@DoctorPassword nvarchar(50),
	@StatementType char(7)

)

 

AS

BEGIN

IF @StatementType = 'Insert'

BEGIN

insert into dbo.Doctors(DoctorName,DoctorSurname,DoctorTC,DoctorAddress1,DoctorAddress2,DoctorMobile1,DoctorMobile2,DoctorGender,
DoctorAge,DoctorEmail,DoctorField,DoctorPassword)
 values(@DoctorName,@DoctorSurname,@DoctorTC,@DoctorAddress1,@DoctorAddress2,@DoctorMobile1,@DoctorMobile2,@DoctorGender,
@DoctorAge,@DoctorEmail,@DoctorField,@DoctorPassword)   

END

 

IF @StatementType = 'Select'

BEGIN

select * from Doctors

END 

 

IF @StatementType = 'Update'

BEGIN

UPDATE Doctors SET

        DoctorName=@DoctorName,DoctorSurname=@DoctorSurname,DoctorTC=@DoctorTC,DoctorAddress1=@DoctorAddress1,DoctorAddress2=@DoctorAddress2,DoctorMobile1=@DoctorMobile1,DoctorMobile2=@DoctorMobile2,DoctorGender=@DoctorGender,
DoctorAge=@DoctorAge,DoctorEmail=@DoctorEmail,DoctorField=@DoctorField,DoctorPassword=@DoctorPassword

      WHERE DoctorID = @DoctorID

END

 

else IF @StatementType = 'Delete'

BEGIN

DELETE FROM Doctors WHERE DoctorID = @DoctorID

END

end