1. Juan, Andrea, Carlos, Catalina y Jorge llegan en horario diferente al trabajo. Ni Catalina ni Juan
llegan tan Tarde como Carlos. Juan y Andrea llegan más tarde que Jorge. Catalina llega más tarde
que Jorge, pero más temprano que Juan.
1.1 ¿El que más tarde llega en el día es?: CARLOS

1.2 ¿El que más temprano llega es?: JORGE

1.3 Realice un algoritmo o programa que simule la solución del ejercicio anterior

Rpta: Se realiza un Backend en .NET con el algoritmo solicitado y un FrontEnd en Angular

2. Escriba un algoritmo o programa que reciba un número entero positivo e imprima el mismo
número en orden inverso.

Rpta: Se realiza un Backend en .NET con el algoritmo solicitado y un FrontEnd en Angular, se crean 3 componentes uno llamado Principal, Horario-llegada,numero-inverso
la aplicacion inicia en el componente principal y allí se redireciona hacia los otros componentes segun elección, tambien en los componetes de 
Horario-llegada y numero-inverso se tiene un boton de regresar al componente principal.  


3. EJERCICIOS SQL: Dada la siguiente relación resolver las siguientes consultas

a. Obtener el nombre y precio de los productos cuyo precio sea mayor o igual a $180.000 y ordenarlos descendentemente por precio

select
	nomproducto,precioproducto
from
	producto
where
	precioproducto >= 180000
order by
	precioproducto desc
  
b. Obtener el nombre de los productos del proveedor con Nit # “123456”

select 
	p.nomproducto
from
	producto p
inner join
	proveedor pv
on
	p.nitproveedor = pv.nitproveedor
where
	pv.nitproveedor='123456'

c. Obtener el nombre del proveedor relacionado con el producto cuyo código es “PRD1”

select 
	pv.nomproveedor
from
	proveedor pv
inner join
	producto p
on
	pv.nitproveedor = p.nitproveedor 
where
	p.codproducto='PRD1'

d. Obtener el nombre y precio de los productos que estén entre $ 20.000 y $ 180.000

select
	nomproducto,
	precioproducto
from
	producto
where
	precioproducto between 20000 and 180000
