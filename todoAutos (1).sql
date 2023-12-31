CREATE DATABASE TodoAuto;
go
USE TodoAuto;
go
CREATE TABLE EMPLEADOS (
  Cod_Empleado VARCHAR(17) PRIMARY KEY NOT NULL,
  Nombres VARCHAR(75) NOT NULL,
  Apellidos VARCHAR(75) NOT NULL,
  Sueldos DECIMAL(7, 2) NOT NULL,
  Telefono VARCHAR(11) NOT NULL,
  Email VARCHAR(100) NOT NULL
);
CREATE TABLE CLIENTES_FRECUENTES (
  DUI VARCHAR(17) PRIMARY KEY NOT NULL,
  Nombres VARCHAR(75) NOT NULL,
  Apellidos VARCHAR(75) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Telefono VARCHAR(11) NOT NULL
);
CREATE TABLE AUTOS (
  VIN VARCHAR(17) PRIMARY KEY NOT NULL,
  Marca VARCHAR(20) NOT NULL,
  Modelo VARCHAR(40) NOT NULL,
  Año INT NOT NULL,
  Kilometros INT NOT NULL,
  Tipo VARCHAR(25) NOT NULL,
  Condición CHAR(5) NOT NULL,
  Precio DECIMAL(7, 2) NOT NULL,
  Existencias INT NOT NULL,
  DUI VARCHAR(17) NOT NULL,
  Cod_Empleado VARCHAR(17),
  FOREIGN KEY (DUI) REFERENCES CLIENTES_FRECUENTES(DUI),
  FOREIGN KEY (Cod_Empleado) REFERENCES EMPLEADOS(Cod_Empleado));
  
  -------------AutoSp
CREATE PROCEDURE AutoSp
@accion varchar(10),
@VIN VARCHAR(17),
@Marca VARCHAR(20),
@Modelo VARCHAR(40),
@Año INT,
@Kilometros INT,
@Tipo VARCHAR(25),
@Condición CHAR(5),
@Precio DECIMAL(7, 2),
@Existencias INT,
@DUI VARCHAR(17),
@Cod_Empleado VARCHAR(17)
  AS
BEGIN
 IF  @accion= 'Insertar'
  BEGIN
  INSERT INTO Autos(VIN,Marca,Modelo,Año,Kilometros,Tipo,Condición,Precio,Existencias,DUI,Cod_Empleado)
VALUES (@VIN,@Marca,@Modelo,@Año,@Kilometros,@Tipo,@Condición,@Precio,@Existencias,@DUI,@Cod_Empleado)
  END
  ELSE IF @accion= 'Actualizar'
  BEGIN
  UPDATE AUTOS
SET VIN=@VIN,Marca=@Marca,Modelo=@Modelo,Año=@Año,Kilometros=@Kilometros,
Tipo=@Tipo,Condición=@Condición,Precio=@Precio,Existencias=@Existencias,DUI=@DUI,Cod_Empleado=@Cod_Empleado
WHERE Cod_Empleado=@Cod_Empleado
  END
END;
go
-- Cliente sp
Create PROCEDURE ClienteSp

  @accion Varchar(10),
  @DUI VARCHAR(17),
  @Nombres VARCHAR(75) ,
  @Apellidos VARCHAR(75),
  @Email VARCHAR(100),
  @Telefono VARCHAR(11)

  AS
BEGIN
 IF  @accion= 'Insertar'
  BEGIN
INSERT INTO CLIENTES_FRECUENTES(DUI,Nombres,Apellidos,Email,Telefono)
VALUES (@DUI,@Nombres,@Apellidos,@Email,@Telefono)
  END
  ELSE IF @accion= 'Actualizar'
  BEGIN
  UPDATE CLIENTES_FRECUENTES
SET DUI=@DUI,Nombres=@Nombres,Apellidos=@Apellidos,
Email=@Email,Telefono=@Telefono
WHERE DUI=@DUI
  END
END;
---------- Empleado Sp
go
CREATE PROCEDURE EmpleadoSP

  @accion Varchar(10),
  @Cod_Empleado VARCHAR(17),
 @Nombres VARCHAR(75),
 @Apellidos VARCHAR(75),
 @Sueldos DECIMAL(7, 2),
 @Telefono VARCHAR(11),
 @Email VARCHAR(100)
  AS
BEGIN
 IF  @accion= 'Insertar'
  BEGIN
INSERT INTO EMPLEADOS(Cod_Empleado,Nombres,Apellidos,Sueldos,Telefono,Email)
VALUES (@Cod_Empleado,@Nombres,@Apellidos,@Sueldos,@Telefono,@Email)
print 'Se agregado un nuevo cliente'
  END
  ELSE IF @accion= 'Actualizar'
  BEGIN
UPDATE EMPLEADOS
SET Cod_Empleado=@Cod_Empleado,Nombres=@Nombres,Apellidos=@Apellidos,
Sueldos=@Sueldos,Telefono=@Telefono,Email=@EMAIL
WHERE Cod_Empleado=@Cod_Empleado
  END
  print 'Se ha actualizado correctamente'
END;

----Borrar
 CREATE PROCEDURE BORRAR
  @paramBorrar VARCHAR(17)
AS
BEGIN
  IF EXISTS(SELECT * FROM CLIENTES_FRECUENTES WHERE DUI = @paramBorrar)
  BEGIN
    DELETE FROM CLIENTES_FRECUENTES WHERE DUI = @paramBorrar
  END
  ELSE IF EXISTS(SELECT * FROM EMPLEADOS WHERE Cod_Empleado = @paramBorrar)
  BEGIN
    DELETE FROM EMPLEADOS WHERE Cod_Empleado = @paramBorrar
  END
  ELSE IF EXISTS(SELECT * FROM AUTOS WHERE VIN = @paramBorrar)
  BEGIN
    DELETE FROM AUTOS WHERE VIN = @paramBorrar
	DELETE FROM AUTOS WHERE Cod_Empleado = @paramBorrar
	DELETE FROM AUTOS WHERE DUI = @paramBorrar
  END
END 
---Buscar
go
 PROCEDURE buscar
  @busqueda VARCHAR(17)
AS
BEGIN
  IF EXISTS(SELECT * FROM CLIENTES_FRECUENTES WHERE DUI = @busqueda OR Nombres = @busqueda OR Apellidos = @busqueda)
  BEGIN
    SELECT * FROM CLIENTES_FRECUENTES 
	WHERE DUI LIKE'%'+@busqueda+'%'
	OR Nombres LIKE'%'+@busqueda+'%'
	OR Apellidos LIKE'%'+@busqueda+'%'
  END
  ELSE IF EXISTS(SELECT*FROM EMPLEADOS WHERE Cod_Empleado = @busqueda OR Nombres=@busqueda OR Apellidos=@busqueda)
  BEGIN
    SELECT * FROM EMPLEADOS 
	WHERE Cod_Empleado LIKE '%'+ @busqueda+'%'
	OR Nombres LIKE'%'+@busqueda+'%'
	OR Apellidos LIKE'%'+@busqueda +'%'
  END
  ELSE IF EXISTS(SELECT*FROM EMPLEADOS WHERE Cod_Empleado =@busqueda OR Nombres=@busqueda OR Apellidos=@busqueda)
  BEGIN
    SELECT * FROM AUTOS 
	WHERE Marca LIKE '%'+@busqueda+'%'
	OR  Modelo LIKE'%'+@busqueda+'%'
	OR VIN LIKE'%'+@busqueda +'%'
  END
END;