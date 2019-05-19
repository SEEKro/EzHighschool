GetAbesnteByUser

CREATE PROCEDURE [dbo].[GetAbesnteByUser]
	@username varchar(255)
AS
	SELECT Catalog_Absente.id, 
	   Elevi.nume AS nume_elev, Materii.nume AS nume_materie, Catalog_Absente.data, Catalog_Absente.motivatie
	FROM Elevi, Catalog_Absente, Materii
	WHERE Elevi.username = @username AND
		  Elevi.username = Catalog_Absente.username AND
		  Catalog_Absente.id_materie = Materii.id

GetAllGrades
CREATE PROCEDURE [dbo].[GetAllGrades]
AS
	SELECT Elevi.nume, Catalog.data, Catalog.nota, Materii.nume
	FROM Elevi, Catalog, Materii
	WHERE Elevi.username LIKE Catalog.user_elev
	  AND Materii.id = Catalog.id_materie

GetAllGradesByUser
CREATE PROCEDURE [dbo].[GetAllGradesByUser]
	@username varchar(255)
AS
	SELECT Elevi.nume, Catalog.data, Catalog.nota, Materii.nume
	FROM Elevi, Catalog, Materii
	WHERE Elevi.username LIKE Catalog.user_elev
	  AND Materii.id = Catalog.id_materie
	  AND Catalog.user_elev LIKE @username

GetPassword
CREATE PROCEDURE [dbo].[GetPassword]
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

GetPersonalInfo
CREATE PROCEDURE [dbo].[GetPersonalInfo]
	@functie text,
	@username varchar(255) 
AS
	IF @functie LIKE 'elev'
		BEGIN
		SELECT *
		FROM Elevi
		WHERE Elevi.username LIKE @username
		END
	ELSE
		BEGIN
		SELECT *
		FROM Profesori
		WHERE Profesori.username LIKE @username
		END

InsertAbesnta
CREATE PROCEDURE [dbo].[InsertAbsenta]
	@user_elev varchar(255),
	@id_materie int,
	@data date
AS
	INSERT INTO Catalog_Absente(username, id_materie, data)
	VALUES (@user_elev, @id_materie, @data)

InsertGrade
CREATE PROCEDURE [dbo].[InsertGrade]
	@id_materie int = 0,
	@user_elev varchar(255),
	@user_profesor varchar(255),
	@nota int,
	@data date
AS
	INSERT INTO Catalog (id_materie, user_elev, user_profesor, nota, data)
	VALUES (@id_materie, @user_elev, @user_profesor, @nota, @data);

MotivateAbsenta
CREATE PROCEDURE [dbo].[MotivateAbsenta]
	@id_absenta int
AS
	UPDATE Catalog_Absente
	SET motivatie = 1
	WHERE @id_absenta = Catalog_Absente.id