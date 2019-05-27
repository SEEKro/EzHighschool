INSERT INTO Tricouri(nume, firma, pret, img)
VALUES('Tricou4', 'Firma2', 55.00, (SELECT * FROM OPENROWSET(BULK N'C:\Users\Cristian\Desktop\Tricouri\t1.jpg', SINGLE_BLOB)as img))
GO

INSERT INTO Tricouri(nume, firma, pret, img)
VALUES('Tricou4', 'Firma2', 54.99, (SELECT * FROM OPENROWSET(BULK N'C:\Users\Cristian\Desktop\Tricouri\t2.jpg', SINGLE_BLOB)as img))
GO

INSERT INTO Tricouri(nume, firma, pret, img)
VALUES('Tricou4', 'Firma2', 60.99, (SELECT * FROM OPENROWSET(BULK N'C:\Users\Cristian\Desktop\Tricouri\t3.jpg', SINGLE_BLOB)as img))
GO

INSERT INTO Tricouri(nume, firma, pret, img)
VALUES('Tricou4', 'Firma2', 100.99, (SELECT * FROM OPENROWSET(BULK N'C:\Users\Cristian\Desktop\Tricouri\t4.jpg', SINGLE_BLOB)as img))
GO