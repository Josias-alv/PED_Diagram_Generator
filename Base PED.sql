CREATE DATABASE Proyecto_PED2;
USE Proyecto_PED2;

CREATE TABLE Usuarios(
	ID_Usuario INT auto_increment NOT NULL,
    Correo_Usuario VARCHAR(200),
    Contraseña VARBINARY(356),
    Fecha_Ingreso datetime default now(),
    Estado_Usuario boolean,
    Constraint PK_IDusuario primary key(ID_Usuario),
    Constraint U_Correo unique(Correo_Usuario)
);
CREATE TABLE Diagramas_Generados(
	ID_Diagrama int auto_increment not null,
    ID_Usuario int,
    Nombre varchar(200),
    ArchivoJson json,
    ArchivoPNG longblob,
    Ruta varchar(1000),
    Fecha_Creacion datetime,
    Status_Activo boolean,
    constraint PK_IDDIAGRAM PRIMARY KEY(ID_Diagrama),
    CONSTRAINT FK_IDUSER FOREIGN KEY(ID_Usuario) REFERENCES Usuarios(ID_Usuario)
);
DELIMITER $$  
create procedure SP_Login(IN Usuario VARCHAR(200) , IN Passwords VARCHAR(356))
BEGIN 
if not exists(select ID_Usuario from Usuarios where Correo_Usuario = Usuario) then
      SET @s = 'EL USUARIO QUE TRATA DE INGRESAR NO EXISTE, CREE UNO...';
		SIGNAL SQLSTATE '45001' SET MESSAGE_TEXT = @s;
else
	select ID_Usuario,Estado_Usuario from Usuarios where Correo_Usuario = Usuario and Contraseña = Passwords;
end if;
END
$$ 
DELIMITER ;

DELIMITER $$ 
CREATE PROCEDURE SP_CREARUSER(IN Usuario VARCHAR(200) , IN Passwords VARCHAR(356), IN ESTADOUSER BOOLEAN)
BEGIN
INSERT INTO  usuarios(Correo_Usuario,Contraseña,Estado_Usuario) VALUES (Usuario,Passwords, ESTADOUSER);
END
$$ 
DELIMITER ;

DELIMITER $$ 
CREATE PROCEDURE SP_VERDATOS(IN IDUSER INT )
BEGIN
SELECT * FROM usuarios WHERE ID_Usuario = IDUSER;
END
$$ 
DELIMITER ;
DELIMITER $$ 
create procedure SP_CAMBIARPASS(IN IDUSER INT, IN PASS VARCHAR(356))
BEGIN 
UPDATE Usuarios SET Contraseña = PASS  WHERE ID_Usuario = IDUSER;
END
$$ 
DELIMITER ;
DELIMITER $$
CREATE PROCEDURE SP_DESACTIVAR(IN IDUSER INT, IN ESTADO BOOLEAN)
BEGIN 
UPDATE Usuarios SET Estado_Usuario = ESTADO WHERE ID_Usuario = IDUSER;
END
$$ 
DELIMITER ;
DELIMITER $$
CREATE PROCEDURE SP_ACTIVARCUENTA(IN CORREOUSER VARCHAR(200), IN ESTADO BOOLEAN)
BEGIN 
UPDATE Usuarios SET Estado_Usuario = ESTADO WHERE Correo_Usuario = CORREOUSER;
END
$$ 
DELIMITER ;

/*PROCEDURE PARA LA DIAGRAMAS GENERADOS*/
DELIMITER $$
CREATE PROCEDURE SP_CREARDIAGRAM(IN IDUSER INT,IN NOMBRE varchar(200),IN ARCHIVOJSON JSON,IN ARCHIVOPNG LONGBLOB, IN RUTA VARCHAR(1000),IN FECHA DATETIME,IN STATUSACT BOOLEAN)
BEGIN
INSERT INTO Diagramas_Generados(ID_Usuario,Nombre,ArchivoJson,ArchivoPNG,Ruta,Fecha_Creacion,Status_Activo) VALUES (IDUSER,NOMBRE,ARCHIVOJSON,ARCHIVOPNG,RUTA,FECHA,STATUSACT);
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SP_VERDIAGRAM(IN IDUSER INT,IN STATUSDES boolean)
BEGIN
SELECT ID_Diagrama,Nombre,ArchivoJson,ArchivoPNG,Ruta,Fecha_Creacion,Status_Activo FROM Diagramas_Generados WHERE ID_Usuario = IDUSER AND Status_Activo = STATUSDES;
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SP_TODOSDIAGRAMS(IN IDUSER INT)
BEGIN
SELECT ID_Diagrama,Nombre,ArchivoJson,ArchivoPNG,Ruta,Fecha_Creacion,Status_Activo FROM Diagramas_Generados WHERE ID_Usuario = IDUSER;
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SP_DEACTOACTDIAGRAM(IN IDIAGRAM INT, IN STATUSDES boolean)
BEGIN
UPDATE Diagramas_Generados SET Status_Activo=STATUSDES WHERE ID_Diagrama = IDIAGRAM;
END
$$ 
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SP_EDITARDIAGRAMA(IN IDDIGRAM INT,IN NOMBRE varchar(200),IN ARCHIVOJSON JSON,IN ARCHIVOPNG LONGBLOB)
BEGIN
UPDATE Diagramas_Generados SET Nombre=NOMBRE,ArchivoJson=ARCHIVOJSON,ArchivoPNG=ARCHIVOPNG WHERE ID_Diagrama=IDDIGRAM;
END
$$ 
DELIMITER ;
