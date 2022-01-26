# Examen  
Exámen de comprobación de conocimientos sobre pruebas unitarias y TDD

## Enunciado
Se te proporcionan dos proyectos `dotnet` para realizar las *Pruebas Unitarias* asociadas a un `Sistema` que satisface las necesidades funcionales del cliente de la manera siguiente:  
- Quiere que *introducido un número* le devuelva un texto que varía en función del parámetro que recibe, de tal manera que si se trata de un *múltiplo de 3 devolverá “Meta”*, si es *múltiplo de 5 devolverá “Verso”*, y si es *múltiplo de 3 y de 5 devuelve “Metaverso”*. Si no es ninguno de los casos anteriores devolverá el _mismo valor_ en formato de cadena. 
- Lo mismo de manera que si recibe un array de enteros(`int[] valores`) como parámetro, y devolverá la concatenación del resultado del método anterior aplicado a cada uno de los valores del array. 

Dibuja en una hoja, identificada con tu nombre, el `diagrama de flujo`, `calcula la complejidad ciclomática` y presenta una tabla con el diseño de las `pruebas unitarias` que vas a  programar.

## Entrega
  La entrega se realiza subiendo el proyecto a un repositorio `Git` de acceso público que tu profesor evaluará. Introduce tu nombre y la url a tu repositorio en este documento.
  Se pide que en un (documento)[https://docs.google.com/document/d/1tZlh6qbBmim03y50rZATfS_4tGxLx5UoKhyKiEjfnoA/edit?usp=sharing] PDF/md, que muestra explicación y las capturas de pantalla que demuestran que tu programa y los test son correctos.

## Preparación
Utiliza la plantilla que tú hayas creado en clase o:
```
   git clone https://github.com/srlopez/Examen2EVPruebasUnitarias
   cd Examen2EVPruebasUnitarias
   rd /q/s .git
```
Con estos comandos tienes dos proyectos, uno del `Sistema` y otro de `pruebas unitarias` limpio para poder subirlo al repositorio que crees para la entrega. Limpia el código que no sea necesario. 

