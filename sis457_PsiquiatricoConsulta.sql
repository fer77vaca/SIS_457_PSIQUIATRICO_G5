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
DROP TABLE Terapeuta;

CREATE TABLE Terapeuta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(20) NOT NULL,
  apellido VARCHAR(20) NULL,
  especialidad VARCHAR(20) NULL,
  telefono VARCHAR(20) NULL,
  direccionClinica VARCHAR(250) NOT NULL, -- Direccion Consultorio
  horarioTrabajo VARCHAR(100) NOT NULL
);
CREATE TABLE Paciente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(20) NOT NULL,
  apellido VARCHAR(20) NULL,
  fechaNacimiento DATE NOT NULL,
  genero VARCHAR(20) NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  telefono VARCHAR(20) NULL,
  histroialMedico VARCHAR(250) NOT NULL,
  tratamiento VARCHAR(250) NULL  -- FALTA: Tratamiento actual, fecha de admision, fecha de alta
);
CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idTerapeuta INT NOT NULL,
  idPaciente INT NOT NULL,
  fecha DATE NOT NULL,
  hora TIME NOT NULL,
  tratamiento VARCHAR(250) NOT NULL,
  pago DECIMAL NOT NULL					-- FALTA: Motivo cita
  CONSTRAINT fk_Cita_Terapeuta FOREIGN KEY(idTerapeuta) REFERENCES Terapeuta(id),
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);
CREATE TABLE Receta (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  fechaReceta DATE NOT NULL,
  cantidadPrescrita DECIMAL NOT NULL,
  InstruccionesUso VARCHAR(250) NOT NULL
  CONSTRAINT fk_Receta_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);
CREATE TABLE Medicamento (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idReceta INT NOT NULL,
  nombreMedicamento VARCHAR(250) NOT NULL,
  dosificacion VARCHAR(250) NOT NULL,
  precio DECIMAL NOT NULL	-- PRECIO NO PONER
  CONSTRAINT fk_Medicamento_Receta FOREIGN KEY(idReceta) REFERENCES Receta(id)
);
ALTER TABLE Terapeuta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Terapeuta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Terapeuta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Paciente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Paciente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Paciente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Cita ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cita ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cita ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Receta ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Receta ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Receta ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Medicamento ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Medicamento ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Medicamento ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

-- Terapeuta
CREATE PROC paTerapeutaListar @parametro VARCHAR(50)
AS
  SELECT id, nombre, apellido, especialidad, telefono, direccionClinica, horarioTrabajo, usuarioRegistro, fechaRegistro, estado
  FROM Terapeuta
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paTerapeutaListar 'Juan';

-- Cita
CREATE PROC paCitaListar @parametro VARCHAR(50)
AS
  SELECT id, fecha, hora, tratamiento, pago, usuarioRegistro, fechaRegistro, estado
  FROM Cita
  WHERE estado<>-1 AND tratamiento LIKE '%'+REPLACE(@parametro,' ','%')+'%';
EXEC paCitaListar 'Limpieza dental';

-- Paciente
CREATE PROC paPacienteListar @parametro VARCHAR(50)
AS
  SELECT id, nombre, apellido, fechaNacimiento, genero, direccion, telefono, histroialMedico, tratamiento, usuarioRegistro, fechaRegistro, estado
  FROM Paciente
  WHERE estado<>-1 AND nombre LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPacienteListar 'María';

-- Receta
CREATE PROC paRecetaListar @parametro VARCHAR(50)
AS
  SELECT id, fechaReceta, cantidadPrescrita, InstruccionesUso, usuarioRegistro, fechaRegistro, estado
  FROM Receta
  WHERE estado<>-1 AND InstruccionesUso LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paRecetaListar 'Paracetamol';

-- Medicamento
CREATE PROC paMedicamentoListar @parametro VARCHAR(50)
AS
  SELECT id, nombreMedicamento, dosificacion, precio, usuarioRegistro, fechaRegistro, estado
  FROM Medicamento
  WHERE estado<>-1 AND nombreMedicamento LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paMedicamentoListar 'Paracetamol';

INSERT INTO Terapeuta (nombre, apellido, especialidad, telefono, direccionClinica, horarioTrabajo)
VALUES ('Juan', 'Pérez', 'Medicina General', '9876543210', 'Calle 123', 'Lunes a Viernes de 8:00 a 18:00'),
('María', 'González', 'Psicología', '1234567890', 'Calle 456', 'Lunes a Viernes de 10:00 a 17:00');

INSERT INTO Terapeuta (nombre, apellido, especialidad, telefono, direccionClinica, horarioTrabajo)
VALUES ('Andrez', 'Ruiz', 'Psicologo', '74125886', 'Calle 415', 'Lunes a Viernes de 8:00 a 18:00');

INSERT INTO Terapeuta (nombre, apellido, especialidad, telefono, direccionClinica, horarioTrabajo)
VALUES ('Pedro', 'Pérez', 'Pediatría', '9876543210', 'Calle 123', 'Lunes a Viernes de 8:00 a 18:00');

-- Actualizar el estado de María González
UPDATE Terapeuta
SET estado = -1
WHERE id = 2;

-- Restaurar el estado de María González
UPDATE Terapeuta
SET estado = 0
WHERE id = 2;

-- Seleccionar los datos actualizados
SELECT * FROM Terapeuta WHERE estado=1;
SELECT * FROM Terapeuta;









