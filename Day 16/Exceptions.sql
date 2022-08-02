 BEGIN TRY
DECLARE @num INT, @msg varchar(200)
----------------Divide by Zero to generate Error
SET @num = 5/0
PRINT 'This will not execute'
END TRY
BEGIN CATCH
PRINT 'Error occured that is'
set @msg=(SELECT ERROR_MESSAGE())
PRINT @msg;
END CATCH
GO



----Again
 BEGIN TRY
DECLARE @num INT
----------------Divide by Zero to generate Error
SET @num = 5/0
PRINT 'This will not execute'
END TRY
BEGIN CATCH
SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_SEVERITY() AS ErrorSeverity,
		ERROR_STATE() AS ErrorState, ERROR_PROCEDURE() AS ErrorProcedure,
		ERROR_LINE() AS ErrorLine, ERROR_MESSAGE() AS ErrorMessage;
END CATCH
GO

select * from master.dbo.sysmessages

select * from master.dbo.sysmessages
where severity=16 and error=8134