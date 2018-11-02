create procedure SP_Get_All_Autos
as
begin

select  a.IdAuto
	   ,a.Modelo
	   ,a.Linea
	   ,a.Anio
	   ,a.Color
	   ,m.Marca
from AUTOS a
inner join MARCAS m on a.IdMarca = m.IdMarca
end
go

create procedure SP_Delete_Auto
@codeAuto int
as
begin
delete from AUTOS_PIEZAS where IdAuto = @codeAuto
delete from AUTOS where IdAuto = @codeAuto
end
go

create procedure SP_validateUser
	@user varchar(50), @password varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 'true' UserExist
	WHERE EXISTS (select * from USUARIOS u where u.Usuario like @user and u.PalabraClave like @password)
END
go