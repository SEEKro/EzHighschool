CREATE PROCEDURE [dbo].[GetPassoword]
	@functie text,
	@username varchar(255) 
AS
	IF @functie LIKE 'elev'
		BEGIN
		SELECT Elevi.password
		FROM Elevi
		WHERE Elevi.username LIKE @username
		END
	ELSE
		BEGIN
		SELECT Profesori.password
		FROM Profesori
		WHERE Profesori.username LIKE @username
		END