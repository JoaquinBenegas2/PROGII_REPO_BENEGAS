DROP DATABASE CARRERAS_2023
GO 

CREATE DATABASE CARRERAS_2023
GO

USE CARRERAS_2023
GO

CREATE TABLE ASIGNATURAS (
	id_asignatura INT IDENTITY(1, 1) NOT NULL,
	nom_asignatura VARCHAR(255) NOT NULL

	CONSTRAINT PK_ASIGNATURAS PRIMARY KEY (id_asignatura)
)
GO

CREATE TABLE CARRERAS (
	id_carrera INT IDENTITY(1, 1) NOT NULL,
	nom_carrera VARCHAR(255) NOT NULL

	CONSTRAINT PK_CARRERAS PRIMARY KEY (id_carrera)
)
GO

CREATE TABLE DETALLES_CARRERAS (
	id_detalle_carrera INT IDENTITY(1, 1) NOT NULL,
	id_carrera INT NOT NULL,
	año_cursado INT NOT NULL,
	cuatrimestre INT NOT NULL,
	id_asignatura INT NOT NULL

	CONSTRAINT PK_DETALLES_CARRERAS PRIMARY KEY (id_detalle_carrera),
	CONSTRAINT FK_DETALLES_CARRERAS__CARRERAS FOREIGN KEY (id_carrera)
	REFERENCES CARRERAS (id_carrera),
	CONSTRAINT FK_DETALLES_CARRERAS__MATERIAS FOREIGN KEY (id_asignatura)
	REFERENCES ASIGNATURAS (id_asignatura)
)
GO

INSERT INTO ASIGNATURAS(nom_asignatura) VALUES 
('PROGRAMACIÓN I'),
('PROGRAMACIÓN II'),
('LAB. COMPUTACIÓN I'),
('LAB. COMPUTACIÓN II')


-- Stored Procedures:
CREATE PROCEDURE SP_CONSULTAR_ASIGNATURAS AS
BEGIN
	SELECT * FROM ASIGNATURAS
END

CREATE PROCEDURE SP_PROXIMO_ID 
@next INT OUTPUT
AS BEGIN
	SET @next = (SELECT MAX(id_carrera)+1 FROM CARRERAS)
END

CREATE PROCEDURE SP_INSERTAR_DETALLE
@id_carrera INT, 
@año_cursado INT, 
@cuatrimestre INT, 
@id_asignatura INT
AS BEGIN
	INSERT INTO DETALLES_CARRERAS (id_carrera, año_cursado, cuatrimestre, id_asignatura)
	VALUES (@id_carrera, @año_cursado, @cuatrimestre, @id_asignatura)
END

CREATE PROCEDURE SP_INSERTAR_MAESTRO 
@nom_carrera VARCHAR(255),
@id_carrera INT OUTPUT
AS BEGIN
	INSERT INTO CARRERAS (nom_carrera) VALUES (@nom_carrera)

	SET @id_carrera = SCOPE_IDENTITY()
END

CREATE PROCEDURE SP_CONSULTAR_CARRERAS_AÑOS_MAX
@cant_años INT
AS BEGIN 
	SELECT 
	C.id_carrera,
	C.nom_carrera 'Carrera',
	MAX(DC.año_cursado) 'Cant. Años'
	FROM CARRERAS C
	JOIN DETALLES_CARRERAS DC ON C.id_carrera = DC.id_carrera
	GROUP BY C.id_carrera, C.nom_carrera
	HAVING MAX(DC.año_cursado) <= @cant_años
END

CREATE PROCEDURE SP_CONSULTAR_DETALLES_CARRERA
@id_carrera INT
AS BEGIN 
	SELECT 
	nom_asignatura,
	año_cursado,
	cuatrimestre
	FROM DETALLES_CARRERAS DC
	JOIN ASIGNATURAS A ON A.id_asignatura = DC.id_asignatura
	WHERE DC.id_carrera = @id_carrera
END

CREATE PROCEDURE SP_ELIMINAR_CARRERA
@id_carrera INT
AS BEGIN 
	DELETE FROM DETALLES_CARRERAS
	WHERE id_carrera = @id_carrera

	DELETE FROM CARRERAS
	WHERE id_carrera = @id_carrera
END


-- Algunas consultas útiles

SELECT 
C.nom_carrera 'Carrera',
A.nom_asignatura 'Asignatura',
DC.año_cursado 'Año',
DC.cuatrimestre 'Cuatrimestre'
FROM CARRERAS C
JOIN DETALLES_CARRERAS DC ON C.id_carrera = DC.id_carrera
JOIN ASIGNATURAS A ON A.id_asignatura = DC.id_asignatura

SELECT 	
C.nom_carrera 'Carrera',
MAX(DC.año_cursado) 'Cant. Años'
FROM CARRERAS C
JOIN DETALLES_CARRERAS DC ON C.id_carrera = DC.id_carrera
GROUP BY C.id_carrera, C.nom_carrera
HAVING MAX(DC.año_cursado) <= 5



