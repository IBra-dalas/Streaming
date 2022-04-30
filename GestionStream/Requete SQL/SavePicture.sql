CREATE PROCEDURE PROC_SavePicture 
(
	@numcontact int,
	@nomcontact nchar(25),
	@photo image,
	@ok int OUTPUT
)
AS
DECLARE @ERR INT
SET @ERR = 0
BEGIN TRANSACTION
IF EXISTS (SELECT numcontact FROM Contact WHERE numcontact = @numcontact)
BEGIN
SET @ok=1 
END
ELSE
BEGIN
INSERT INTO Contact(numcontact, nomcontact, photo) VALUES (@numcontact, @nomcontact, @photo)
SET @ERR=@ERR + @@ERROR
IF (@ERR=0)
BEGIN
 COMMIT TRANSACTION
END
ELSE
BEGIN	
	ROLLBACK TRANSACTION
END
END
IF (@ERR=0)
BEGIN
SET @ok=1
END
ELSE
BEGIN
SET @ok=0
END