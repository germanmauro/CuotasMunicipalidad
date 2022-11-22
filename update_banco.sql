ALTER TABLE banco
ADD telefono varchar(50),
numero_cuenta varchar(40),
tipo_cuenta varchar(30);

update perfil set nombre='administrador' where id=1;
update perfil set nombre='operador' where id=2;