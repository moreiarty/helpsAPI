USE elssa_booking;
GO

ALTER PROCEDURE dbo.prcGetProgramWorkshops
	@programId int
AS 
    SET NOCOUNT ON;

	SELECT workshopId
	FROM programWorkshops
	WHERE programId = @programId

	SET NOCOUNT OFF;
GO