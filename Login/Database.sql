Create database UserLoginTest
GO
Use UserLoginTest
GO
Create Table Usuarios(
    IdUsuario int not null primary key identity (1, 1),
    Nombre varchar(50) null,
    Usuario varchar(50) null,
    Contraseña varchar(50) null,
    TipoUsuario varchar(50) null
)

Select * From Usuarios

Insert into Usuarios values ('Admin 1', 'Adm1', '1234', 'Admin'),
                            ('User 1', 'User1', '4321', 'User');



Create table Usuario(
    Id int not null primary key identity (1, 1),
    Usuario varchar (50) not null unique,
    Contrasena varchar (50),
)

/*Create Procedure SP_AgregarUsuario
@Usuario varchar(50),
@Contrasena varchar(50),
@Patron varchar(50)
AS
BEGIN
Insert into Usuario(Usuario, Contrasena) values (@Usuario, ENCRYPTBYPASSPHRASE(@Patron, @Contrasena))
END

Create Procedure SP_ValidarUsuario
@Usuario varchar(50),
@Contrasena varchar(50),
@Patron varchar(50)
AS
BEGIN
Select * From Usuario where Usuario = @Usuario and convert (varchar(50), DECRYPTBYPASSPHRASE(@Patron, contrasena)) = @Contrasena
END*/

Select * from Usuario
SP_AgregarUsuario 'Teo', '123', 'Prueba1'
