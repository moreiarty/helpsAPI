USE elssa_booking;
GO

CREATE PROCEDURE dbo.prcGetWorkshopWaitingList
	@workshopId int
AS 
    SET NOCOUNT ON;

	SELECT id, workshopID, studentID, priority, archived
	FROM workShops_waiting
	WHERE workshopID = @workshopId

	SET NOCOUNT OFF;
GO