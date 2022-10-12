CREATE DATABASE Automotriz;
USE Automotriz;
DROP DATABASE Automotriz;

CREATE TABLE Producto(
codigobarras VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(50),
descrpcion VARCHAR(100),
marca VARCHAR(50));

DROP TABLE Producto;
DESCRIBE producto;
SELECT * FROM producto;

CREATE TABLE Herramientas(
codigoherramienta VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(50),
medida VARCHAR(20),
marca VARCHAR(50),
descipcion VARCHAR(100)); 

DESCRIBE herramientas;
SELECT * FROM herramientas;

CREATE TABLE Usuarios(
idusuario INT PRIMARY KEY,
nombre VARCHAR(50),
apellidop VARCHAR(25),
apellidom VARCHAR(25),
fdfn VARCHAR(15),
rfc VARCHAR(20),
passw VARCHAR(10)NOT NULL);

DESCRIBE usuarios;
DROP TABLE usuarios;

CREATE TABLE Permisos(
id INT PRIMARY KEY,
fkidusuario INT,
lectura BOOL,
escritura BOOL,
actualizar BOOL,
eliminar BOOL,
FOREIGN KEY(fkidusuario)REFERENCES usuarios(idusuario));

DESCRIBE Permisos;

SELECT * FROM Usuarios;
INSERT INTO Usuarios VALUES(1,'Jorge','jimenez','frfr','2002-12-01','1111rrr');

SHOW TABLES;
Delimiter $$
DROP PROCEDURE if EXISTS insertHerramienta;
CREATE PROCEDURE insertHerramienta(
IN _codigoherramienta VARCHAR(10), IN _nombre VARCHAR(50), IN _medida VARCHAR(20), IN _marca VARCHAR(50), IN _descripcion VARCHAR(100)) 
   BEGIN   
      INSERT INTO herramientas VALUES(_codigoherramienta,_nombre,_medida,_marca,_descripcion); 
END;
CALL insertHerramienta('12ABCD7','Gato mecanico','N/A','DURAFLEX','Ayuda al cambiar las llantas');

SELECT * FROM herramientas;

Delimiter $$
DROP PROCEDURE if EXISTS updateHerramienta;
CREATE PROCEDURE updateHerramienta(
IN _codigoherramienta VARCHAR(10), IN _nombre VARCHAR(50), IN _medida VARCHAR(20), IN _marca VARCHAR(50), IN _descripcion VARCHAR(100)) 
   BEGIN   
      UPDATE herramientas set nombre=_nombre,medida=_medida,marca=_marca,descipcion=_descripcion WHERE codigoherramienta =_codigoherramienta;
END;

CALL updateHerramienta('12ABCD7','Gato mecanico','tienenmedida','DURAFLEX','Ayuda al cambiar las llantas');

Delimiter $$
DROP PROCEDURE if EXISTS insertProducto;
CREATE PROCEDURE insertProducto(
IN _codigobarras VARCHAR(10), IN _nombre VARCHAR(50), IN _descripcion VARCHAR(100), IN _marca VARCHAR(50)) 
   BEGIN   
      INSERT INTO Producto VALUES(_codigobarras,_nombre,_descripcion,_marca); 
END;
CALL insertProducto('8541P','Escape','ZOTTER','Pues un escape amigo');

DELETE FROM producto WHERE codigobarras = '8541P';
SELECT * FROM producto;


Delimiter $$
DROP PROCEDURE if EXISTS updateProducto;
CREATE PROCEDURE updateProducto(
IN _codigobarras VARCHAR(10), IN _nombre VARCHAR(50), IN _descripcion VARCHAR(100), IN _marca VARCHAR(50)) 
   BEGIN   
      UPDATE producto SET nombre=_nombre,descrpcion=_descripcion,marca=_marca WHERE codigobarras=_codigobarras; 
END;
CALL updateProducto('8541P','Escape','EltodopoderosoZOTE','Pues un escape amigo');


Delimiter $$
DROP PROCEDURE if EXISTS insertUsuario;
CREATE PROCEDURE insertUsuario(
IN _idusuario INT, IN _nombre VARCHAR(50),IN _apellidop VARCHAR(25),IN _apellidom VARCHAR(25), IN _fdfn VARCHAR(15), IN _rfc VARCHAR(20),IN _passw VARCHAR(10)) 
   BEGIN   
      INSERT INTO usuarios VALUES(_idusuario,_nombre,_apellidop,_apellidom,_fdfn,_rfc,_passw); 
END;
CALL insertusuario(1,'Cort','Buur','Sdd','2002-12-01','147lkmhl12','1234');

SELECT * FROM usuarios;

Delimiter $$
DROP PROCEDURE if EXISTS updateusuario;
CREATE PROCEDURE updateusuario(
IN _idusuario INT, IN _nombre VARCHAR(50),IN _apellidop VARCHAR(25),IN _apellidom VARCHAR(25), IN _fdfn VARCHAR(15), IN _rfc VARCHAR(20),IN _passw VARCHAR(10)) 
   BEGIN   
      UPDATE usuarios set nombre=_nombre,apellidop=_apellidop,apellidom=_apellidom,fdfn=_fdfn,rfc=_rfc,passw=_passw WHERE idusuario=_idusuario;
END;
CALL updateusuario(1,'Cort','Buur','Sdd','2002-12-01','147lkmhl13','1234');


Delimiter $$
DROP PROCEDURE if EXISTS insertpermisos;
CREATE PROCEDURE insertpermisos(
IN _id INT, IN _fkusuario INT,IN _lectura BOOL,IN _escritura BOOL,IN _actualizar BOOL,IN _eliminar BOOL) 
   BEGIN   
      INSERT INTO permisos VALUES(_id,_fkusuario,_lectura,_escritura,_actualizar,_eliminar); 
END;
CALL insertpermisos(1,1,TRUE,TRUE,TRUE,TRUE);

SELECT * FROM permisos;

Delimiter $$
DROP PROCEDURE if EXISTS updatepermisos;
CREATE PROCEDURE updatepermisos(
IN _id INT, IN _fkusuario INT,IN _lectura BOOL,IN _escritura BOOL,IN _actualizar BOOL,IN _eliminar BOOL) 
   BEGIN   
      UPDATE permisos set fkidusuario=_fkusuario,lectura=_lectura,escritura=_escritura,actualizar=_actualizar,eliminar=_eliminar WHERE id=_id;
END;
CALL updatepermisos(1,1,TRUE,TRUE,TRUE,TRUE);