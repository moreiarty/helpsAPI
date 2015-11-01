USE elssa_booking;
GO

ALTER PROCEDURE dbo.prcCreateStudent
	@studentID char(10),
	@dob datetime = null,
	@gender char(5) = null,
	@degree char(5),
	@status char(20),
	@first_language nvarchar(50),
	@country_origin nvarchar(50),
	@background ntext = null,
	@HSC bit = null,
	@HSC_mark char(20) = null,
	@IELTS bit = null,
	@IELTS_mark char(20) = null,
	@TOEFL bit = null,
	@TOEFL_mark char(20) = null,
	@TAFE bit = null,
	@TAFE_mark char(20) = null,
	@CULT bit = null,
	@CULT_mark char(20) = null,
	@InsearchDEEP bit = null,
	@InsearchDEEP_mark char(20) = null,
	@InsearchDiploma bit = null,
	@InsearchDiploma_mark char(20) = null,
	@foundationcourse bit = null,
	@foundationcourse_mark char(20) = null,
	@creatorID int,
	@degree_details char(50) = null,
	@alternative_contact text = null,
	@preferred_name nvarchar(50) = null
AS BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT * FROM dbo.students WHERE studentID = @studentID)
	   INSERT INTO dbo.students
			(studentID, dob, gender, degree, status, first_language, country_origin, background, 
			HSC, HSC_mark, IELTS, IELTS_mark, TOEFL, TOEFL_mark, TAFE, TAFE_mark, CULT, CULT_mark, 
			InsearchDEEP, InsearchDEEP_mark, InsearchDiploma, InsearchDiploma_mark, 
			foundationcourse, foundationcourse_mark, created, creatorID, degree_details, alternative_contact, preferred_name)
		VALUES
			(@studentID, @dob, @gender, @degree, @status, @first_language, @country_origin, @background, 
			@HSC, @HSC_mark, @IELTS, @IELTS_mark, @TOEFL, @TOEFL_mark, @TAFE, @TAFE_mark, @CULT, @CULT_mark, 
			@InsearchDEEP, @InsearchDEEP_mark, @InsearchDiploma, @InsearchDiploma_mark, 
			@foundationcourse, @foundationcourse_mark, getdate(), @creatorID, @degree_details, @alternative_contact, @preferred_name)
	ELSE
		UPDATE dbo.students
		SET studentID = @studentID, 
			dob = @dob, 
			gender = @gender, 
			degree = @degree, 
			status = @status, 
			first_language = @first_language, 
			country_origin = @country_origin, 
			background = @background, 
			HSC = @HSC, 
			HSC_mark = @HSC_mark, 
			IELTS = @IELTS, 
			IELTS_mark = @IELTS_mark, 
			TOEFL = @TOEFL, 
			TOEFL_mark = @TOEFL_mark, 
			TAFE = @TAFE, 
			TAFE_mark = @TAFE_mark, 
			CULT = @CULT, 
			CULT_mark = @CULT_mark, 
			InsearchDEEP = @InsearchDEEP,
			InsearchDEEP_mark = @InsearchDEEP_mark, 
			InsearchDiploma = @InsearchDiploma, 
			InsearchDiploma_mark = @InsearchDiploma_mark, 
			foundationcourse = @foundationcourse, 
			foundationcourse_mark = @foundationcourse_mark, 
			created = getdate(), 
			creatorID = @creatorID, 
			degree_details = @degree_details, 
			alternative_contact = @alternative_contact, 
			preferred_name = @preferred_name
		WHERE studentID = @studentID
	
	SET NOCOUNT OFF;
END