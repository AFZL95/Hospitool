USE [Hospitool]
GO
/****** Object:  StoredProcedure [dbo].[ViewFullPtientsNames]    Script Date: 5/12/2017 10:42:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ViewFullPtientsNames]
AS
SELECT PatientName + PatientSurname as Fullname FROM Patients
