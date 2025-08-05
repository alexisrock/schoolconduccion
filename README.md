# schoolconduccion
Descripcion
Esta api rest fue realizada como prueba tecnica, el api esta documentada con swagger, la idea principal del api es que se unos estudiantes puedan crear una registrar una clase 

Arquitectura
Esta api fue creada con una arquitectura limpia, la capa de infraestructura esta creada de tal forma que no tenga ninguna dependencia con el orm, tambien se implemento una clase transform para gestionar la tranformacion a los dto, ademas se utilizo la injeccion de dependencias de net 8.

Tecnologias utilizadas

Net 8
Entityframeworkcore 

Prerequisitos

se debe tener instalado sql server o tener acceso auna instancia sql server
crear la base de datos School
crear el usuario de base de datos UsrDeveloper con la misma contraseña
ubicar la carpeta ScriptDB
abrir el archivo QueryShool.sql que esta en la carpeta anteriormente mencionada
ejecutar el script
Instalacion

se debe primero tener instalado el sdk de net 8
ubicar la carpeta Api y dentro de esa carpeta ejecutar el comadno "dotnet restore"
luego ejecutar el comadno "dotnet build --no-restore"
luego ejecutar el comadno "dotnet public -o rutaarchivos"
Version del aplicativo
