SET QUOTED_IDENTIFIER ON

GO

/* Create BeLife database.                                                                  */
USE master  
GO

CREATE DATABASE "NUMEROUNO"  
GO

use "NUMEROUNO"  
GO
-- Sección de Creación de tablas --


CREATE TABLE TIPO_EMPLEADO (
	CODIGO INT IDENTITY,
	NOMBRE VARCHAR(80) NOT NULL,
	PRIMARY KEY (CODIGO)
);

CREATE TABLE EMPLEADO (
    RUN_DV VARCHAR(18),
    NOMBRES VARCHAR(60) NOT NULL,
    APELLIDO_PAT VARCHAR(60) NOT NULL,
    APELLIDO_MAT VARCHAR(60) NOT NULL,
    TIPO_EMPLEADO_ID INT NOT NULL,
    TELEFONO NUMERIC(9,0),
	REMUNERACION_BRUTA NUMERIC(9,0),
	FECHA_NACIMIENTO DATE,
    PRIMARY KEY (RUN_DV),
	FOREIGN KEY (TIPO_EMPLEADO_ID) REFERENCES TIPO_EMPLEADO(CODIGO)
);

INSERT INTO TIPO_EMPLEADO (NOMBRE) VALUES ('Jefe TI');
INSERT INTO TIPO_EMPLEADO (NOMBRE) VALUES ('Programador');
INSERT INTO TIPO_EMPLEADO (NOMBRE) VALUES ('Cajera');
INSERT INTO TIPO_EMPLEADO (NOMBRE) VALUES ('Supervisor');