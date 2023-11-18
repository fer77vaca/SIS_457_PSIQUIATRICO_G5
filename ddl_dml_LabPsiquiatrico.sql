-- DDL (DATA DEFINITION LANGUAGE)

CREATE DATABASE LabPsiquiatrico; 

USE master
GO
CREATE LOGIN usrpsiquiatrico WITH PASSWORD=N'123456',
	DEFAULT_DATABASE=LabPsiquiatrico,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE LabPsiquiatrico
GO        
CREATE USER usrpsiquiatrico FOR LOGIN usrpsiquiatrico
GO
ALTER ROLE db_owner ADD MEMBER usrpsiquiatrico
GO

DROP TABLE Medicamento;
DROP TABLE Receta;
DROP TABLE Cita;
DROP TABLE Paciente;
DROP TABLE Usuario;
DROP TABLE Personal;

CREATE TABLE Personal (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(50) NOT NULL,
  cedulaIdentidad VARCHAR(20) NOT NULL,	        -- añadido
  especialidad VARCHAR(100) NULL,       -- modificado (100)
  telefono VARCHAR(20) NULL,
  horarioTrabajo VARCHAR(100) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  usuario VARCHAR(20) NOT NULL,
  clave VARCHAR(100) NOT NULL,
  CONSTRAINT fk_Usuario_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
);
CREATE TABLE Paciente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  cedulaIdentidad VARCHAR(20) NOT NULL,		-- añadido
  edad INT NOT NULL,				-- añadido
  telefono VARCHAR(20) NULL,
  historialMedico VARCHAR(250) NOT NULL,
  fechaAdmision VARCHAR(50) NOT NULL,  		-- añadido CAMBIANDO A DATE
  tratamiento VARCHAR(250) NULL  
  CONSTRAINT fk_Paciente_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
);
CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  idPaciente INT NOT NULL,
  motivoCita VARCHAR(250) NOT NULL,		-- añadido
  fecha VARCHAR(50) NOT NULL,			-- cambiar a DATE
  hora VARCHAR(20) NOT NULL,			-- cambiar a HORA
  pago VARCHAR(20) NOT NULL			-- cambiar a DECIMAL
  CONSTRAINT fk_Cita_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id),
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);
CREATE TABLE Receta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  fechaReceta DATE NOT NULL,
  cantidadPrescrita DECIMAL NOT NULL,
  instruccionesUso VARCHAR(250) NOT NULL
  CONSTRAINT fk_Receta_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);
CREATE TABLE Medicamento (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idReceta INT NOT NULL,
  nombreMedicamento VARCHAR(250) NOT NULL,
  dosificacion VARCHAR(250) NOT NULL,
  precio DECIMAL NOT NULL DEFAULT 0,			-- PRECIO NO PONER
  CONSTRAINT fk_Medicamento_Receta FOREIGN KEY(idReceta) REFERENCES Receta(id)
);

ALTER TABLE Personal ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Personal ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Personal ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Paciente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Paciente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Paciente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Cita ADD pago DECIMAL NOT NULL;

ALTER TABLE Cita ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cita ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cita ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Receta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Receta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Receta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Medicamento ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Medicamento ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Medicamento ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

-- Personal
CREATE PROC paPersonalListar @parametro VARCHAR(50)
AS
  SELECT id,nombre,cedulaIdentidad,especialidad,telefono,horarioTrabajo,
	 usuarioRegistro,fechaRegistro,estado

  FROM Personal
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPersonalListar 'Juan';

-- Paciente
CREATE PROC paPacienteListar @parametro VARCHAR(50)
AS
  SELECT id,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento,
	 usuarioRegistro,fechaRegistro,estado

  FROM Paciente
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPacienteListar 'German';

-- Cita
CREATE PROC paCitaListar @parametro VARCHAR(50)
AS
  SELECT id,motivoCita,fecha,hora,pago

  FROM Cita
  WHERE estado<>-1 AND motivoCita LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paCitaListar 'Depresion';

-- Receta
CREATE PROC paRecetaListar @parametro VARCHAR(50)
AS
  SELECT id,fechaReceta,cantidadPrescrita,instruccionesUso

  FROM Receta
  WHERE estado<>-1 AND instruccionesUso LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paRecetaListar 'Beber';

-- Medicamento
CREATE PROC paMedicamentoListar @parametro VARCHAR(50)
AS
  SELECT id,nombreMedicamento,dosificacion,precio

  FROM Medicamento
  WHERE estado<>-1 AND nombreMedicamento LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paMedicamentoListar 'NeuroVimin';

-- DML (DATA MANIPULATION LANGUAGE)

INSERT INTO Personal (nombre,cedulaIdentidad,especialidad,telefono,horarioTrabajo)
VALUES ('Juan Perez', '721458 Or', 'Terapeuta', '68415721', 'Lunes a Viernes de 8:00 a 18:00');
INSERT INTO Personal (nombre,cedulaIdentidad,especialidad,telefono,horarioTrabajo)
VALUES ('Fernando Moragon','72145858 Lp','Psicologo','68665721','Lunes a Sabado de 14:00 a 18:30');

UPDATE Personal SET estado = -1 WHERE id = 2;   -- (Actualizar el estado de id = 2) Personal
UPDATE Personal SET estado = 0 WHERE id = 2;	-- (Restaurar el estado de id = 2) Personal

SELECT * FROM Personal WHERE estado = 1;
SELECT * FROM Personal;

INSERT INTO Usuario (idPersonal, usuario, clave)
VALUES ('1', 'USER_FER', 'Fernando77');
INSERT INTO Usuario (idPersonal, usuario, clave)
VALUES ('2', 'USER_JUA', 'Juan77');

UPDATE Usuario SET estado = -1 WHERE id = 2;   -- (Actualizar el estado de id = 2) Usuario
UPDATE Usuario SET estado = 0 WHERE id = 2;    -- (Restaurar el estado de id = 2) Usuario

SELECT * FROM Usuario WHERE estado = 1;
SELECT * FROM Usuario;

INSERT INTO Paciente (idPersonal,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento)
VALUES ('1','Susana Chambi','47758412 Pt','26','74857757','Estres aguda','12-07-2022','Masaje a frecuencia');
INSERT INTO Paciente (idPersonal,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento)
VALUES ('2','German Ruiz','47754412 Or','30','66857757','Estres cronica','12-07-2023','Resonancia Magnetica');

UPDATE Paciente SET estado = -1 WHERE id = 1;   -- (Actualizar el estado de id = 2) Paciente
UPDATE Paciente SET estado = 0 WHERE id = 2;    -- (Restaurar el estado de id = 2)  Paciente

SELECT * FROM Paciente WHERE estado = 1;
SELECT * FROM Paciente;

INSERT INTO Cita (idPersonal,idPaciente,motivoCita,fecha,hora,pago)
VALUES ('1','2','Depresion','25-10-2023','15:30 pm','150 Bs');
INSERT INTO Cita (idPersonal,idPaciente,motivoCita,fecha,hora,pago)
VALUES ('1','1','Estres','25-09-2023','16:30 pm','200 Bs');

UPDATE Cita SET estado = -1 WHERE id = 1;   -- (Actualizar el estado de id = 2) Cita
UPDATE Cita SET estado = 0 WHERE id = 2;    -- (Restaurar el estado de id = 2)  Cita

SELECT * FROM Cita WHERE estado = 1;
SELECT * FROM Cita;

INSERT INTO Receta (idPaciente,fechaReceta,cantidadPrescrita,instruccionesUso)
VALUES ('2','2023/08/22','8','Beber 1 pastilla cada 8 horas');
INSERT INTO Receta (idPaciente,fechaReceta,cantidadPrescrita,instruccionesUso)
VALUES ('1','2023/07/2','5','Beber 1 pastilla cada 5 horas');

UPDATE Receta SET estado = -1 WHERE id = 1;   -- (Actualizar el estado de id = 2) Receta
UPDATE Receta SET estado = 0 WHERE id = 2;    -- (Restaurar el estado de id = 2)  Receta

SELECT * FROM Receta WHERE estado = 1;
SELECT * FROM Receta;

INSERT INTO Medicamento (idReceta,nombreMedicamento,dosificacion,precio)
VALUES ('5','Carbonato de litio','Beber en ayunas con 1 L d eagua','30');
INSERT INTO Medicamento (idReceta,nombreMedicamento,dosificacion,precio)
VALUES ('6','NeuroVimin','Consumir en despues del almuerzo','50');

UPDATE Medicamento SET estado = -1 WHERE id = 1;   -- (Actualizar) Medicamento
UPDATE Medicamento SET estado = 0 WHERE id = 2;    -- (Restaurar) Medicamento

SELECT * FROM Medicamento WHERE estado = 1;
SELECT * FROM Medicamento;

-- Nuevas Modificaciones, Porcedimientos y tipos de datos

CREATE TABLE Paciente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  nombre VARCHAR(50) NOT NULL,
  cedulaIdentidad VARCHAR(20) NOT NULL,		-- añadido
  edad INT NOT NULL,				-- añadido
  telefono VARCHAR(20) NULL,
  historialMedico VARCHAR(250) NOT NULL,
  fechaAdmision DATE NOT NULL,  		-- CAMBIAR
  tratamiento VARCHAR(250) NULL  
  CONSTRAINT fk_Paciente_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
);

CREATE PROC paPacienteListar @parametro VARCHAR(50)
AS
  SELECT id,idPersonal,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento,
	 usuarioRegistro,fechaRegistro,estado

  FROM Paciente
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPacienteListar 'German';

INSERT INTO Paciente (idPersonal,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento)
VALUES ('1','Susana Chambi','47758412 Pt','26','74857757','Estres aguda','12-07-2022','Masaje a frecuencia');
INSERT INTO Paciente (idPersonal,nombre,cedulaIdentidad,edad,telefono,historialMedico,fechaAdmision,tratamiento)
VALUES ('2','German Ruiz','47754412 Or','30','66857757','Estres cronica','12-07-2023','Resonancia Magnetica');

UPDATE Paciente SET estado = -1 WHERE id = 1;   -- (Actualizar el estado de id = 2) Paciente
UPDATE Paciente SET estado = 0 WHERE id = 2;    -- (Restaurar el estado de id = 2)  Paciente

SELECT * FROM Paciente WHERE estado = 1;
SELECT * FROM Paciente;

ALTER PROC paPacienteListar @parametro VARCHAR(50)
AS
  SELECT pas.id,idPersonal,per.nombre as nombre_personal,pas.nombre as nombre_paciente,pas.cedulaIdentidad,
	 edad,pas.telefono,historialMedico,fechaAdmision,tratamiento,
	 pas.usuarioRegistro,pas.fechaRegistro,pas.estado

  FROM Paciente pas INNER JOIN Personal per ON pas.idPersonal = per.id
  WHERE pas.estado<>-1 AND pas.nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPacienteListar 'German';

DROP TABLE Cita;

CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  motivo VARCHAR(250) NOT NULL,				-- añadido
  fechaReservacion DATETIME NOT NULL DEFAULT GETDATE(),	-- cambiar a DATE
  pago DECIMAL NOT NULL DEFAULT 0,			-- cambiar a DECIMAL
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);

ALTER TABLE Cita ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cita ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cita ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

INSERT INTO Cita (idPaciente,motivo,fechaReservacion,pago)
VALUES ('2','Depresion','2023-12-31 23:59:59','150');

SELECT * FROM Cita;

ALTER PROC paCitaListar @parametro VARCHAR(50)
AS
  SELECT ci.id,idPaciente,pas.nombre as nombre_paciente,ci.motivo as motivo_cita,fechaReservacion,
	 pago,
	 ci.usuarioRegistro,ci.fechaRegistro,ci.estado

  FROM Cita ci INNER JOIN Paciente pas ON ci.idPaciente = pas.id
  WHERE ci.estado<>-1 AND ci.motivo LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paCitaListar 'Depresion';

CREATE PROC paUsuarioListar @parametro VARCHAR(50)
AS
  SELECT us.id,idPersonal,pe.cedulaIdentidad,us.usuario,us.clave,
	 us.usuarioRegistro,us.fechaRegistro,us.estado

  FROM Usuario us INNER JOIN Personal pe ON us.id = pe.id
  WHERE us.estado<>-1 AND pe.cedulaIdentidad LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paCitaListar 'Depresion';





















