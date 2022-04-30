CREATE PROCEDURE PROC_INSERT_CATEGORIE 
(
	@numcat int,
	@nomcat nchar(25),
	@ok int OUTPUT
)
AS
DECLARE @ERR INT
SET @ERR = 0
BEGIN TRANSACTION
IF EXISTS (SELECT numcat FROM Categorie WHERE numcat = @numcat)
BEGIN
SET @ok=1 
END
ELSE
BEGIN
INSERT INTO Categorie (numcat, nomcat) VALUES (@numcat, @nomcat)
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