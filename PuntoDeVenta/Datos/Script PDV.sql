Create table Departamentos(
	Id int not null primary key,	
	Nombre varchar(100)
)
Create table Articulos(
	Codigo Varchar(20) not null primary key,
	Nombre Varchar(100),
	Departamento int not null references Departamentos(Id),
	Precio numeric(12,2),
	TasaIva int,
	Activo char(1)
)
Create table Vendedores(
	Id int not null primary key,
	Nombre varchar(100)
)
Insert into Vendedores values(1,'Jose Perez Leon')
drop table Ventas

Create table Ventas(
	Folio int not null primary key,
	Vendedor int references Vendedores(Id) on delete no action on update no action,
	Fecha date,
	Fecha2 as convert(char(8),Fecha,112),
	SubTotal numeric(12,2),
	Iva numeric(12,2),
	Total numeric(12,2)
)
Create table VentasDetalle(
	Folio int not null,
	Renglon int not null,
	Vendedor int references Vendedores(Id) on delete no action on update no action,
	Fecha date,
	Fecha2 as convert(char(8),Fecha,112),
	Codigo varchar(20) references Articulos(Codigo) on delete no action on update no action,
	Cantidad numeric(12,2),
	Precio numeric(12,2),
	SubTotal numeric(12,2),
	Iva numeric(12,2),
	Total numeric(12,2),
	primary key(Folio,Renglon)
)
drop table VentasTemp
Create table VentasTemp(
	Folio int not null,
	Renglon int not null,
	Codigo varchar(20),
	Cantidad numeric(12,2),
	Precio numeric(12,2),
	TasaIva int,
	SubTotal numeric(12,2),
	Iva numeric(12,2),
	Total numeric(12,2),
	primary key(Folio,Renglon)
)
delete from ventastemp
select * from ventasTemp

Select v.Renglon,v.Codigo,a.Nombre,v.Cantidad,v.Precio,v.TasaIva,v.SubTotal,v.Iva,V.Total
From VentasTemp as v inner join articulos as a on v.codigo=a.codigo
where v.folio=1
order by Renglon





Insert into articulos values('1001','Tv Smart 55"',2,12500,16,'S')
Insert into articulos values('1002','Tv Smart 32"',2,2500,16,'S')
Insert into articulos values('750123456879','Caguama TKt Ligth 1,200 ml',4,45,0,'S')

select * from articulos

Insert into Departamentos(Id,Nombre) Values(2,'Electronica')
Insert into Departamentos Values(3,'Linea Blanca')
Insert into Departamentos(Nombre,Id) Values('Bebidas',4)

Update Departamentos set Nombre='Bebidas' -- Modifica todas las filas de la tabla en Nombre="Bebidas"
Update Departamentos set Nombre='Frutas y Veduras' where Id=1 -- Modifica el Nombre de la fila que contenga el Id=1
Update Departamentos set Nombre='Vinos y Licores' where Id=10 or Id=4

Delete from Departamentos -- Elimina todas las filas de la tabla
Delete from Departamentos where id>=3 -- Elimina del Id3 hacia arriba

Select * from Departamentos 
Select * from Departamentos where Id=4
Select Nombre from Departamentos
Select Nombre, Id from Departamentos
Select Nombre, Id from Departamentos where Nombre='UA de O'

select max(Id) from Departamentos
select ISNULL(max(Id),0)+1 from Departamentos

Select Id,Nombre from departamentos where nombre like '%ni%'

Select * from vendedores
Select * from ventas where vendedor=2 and fecha2>='20241111' and fecha2<='2024111'
Select * from ventas where vendedor=2 and fecha2 between '20241111' and '20241111'
Select * from ventas where vendedor=1 and fecha2>='20241001' and fecha2<='2024111'
Select folio,fecha,subTotal,Iva,Total from ventas where vendedor=2 and fecha2>='2024111' and fecha2<='2024111' order by fecha2,folio
