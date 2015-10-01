USE elssa_booking;
GO

ALTER PROCEDURE dbo.prcGetWorkshopDetail
@workshopId int
AS 
    SET NOCOUNT ON;

			SELECT WorkshopId, topic, description, targetingGroup, campus, StartDate, EndDate,
				maximum, WorkShopSetID, cutoff, type, reminder_num, reminder_sent, DaysOfWeek, NumOfWeeks, ProgramStartDate, ProgramEndDate, BookingCount, archived
			FROM 		
				(
				SELECT w.id as WorkshopId,
					w.topic,
					w.description,
					w.targetingGroup,
					c.campus,
					w.starting as StartDate,
					w.ending as EndDate,
					w.maximum,
					w.WorkShopSetID,
					w.cutoff,
					w.type,
					w.reminder_num,
					w.reminder_sent,
					p.days as DaysOfWeek,
					p.numOfWeeks as NumOfWeeks,
					p.startDate as ProgramStartDate,
					p.endDate as ProgramEndDate,
					dbo.ufnGetBookingCount(w.id) as BookingCount,
					w.archived
				FROM workshops w
					LEFT JOIN programWorkshops pw
						ON w.id = pw.workshopId
					LEFT JOIN programs p
						ON pw.programId = p.id
					INNER JOIN campus c
						ON w.campusID = c.id
				) As result 
				WHERE result.WorkshopId = @workshopId

	SET NOCOUNT OFF;
GO
