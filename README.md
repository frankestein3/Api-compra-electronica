# Api-compra-electronica
API Rest en .NET CORE

INDICACIONES PARA EJECUTAR EL PROYECTO:

1. Inicialmente se debe crear la base de datos en SQL Server. En la carpeta del repositorio se encuantra el Script.
2. Luego, se debe descargar el proyecto que esta en la rama "master" llamado "compraElectronica", que es una solución en Visual Studio 2019 que contiene la API Rest desarrollada en .NET CORE.
3. Realizar las modificaciones al archivo "appsettings.json" de acuerdo a la configuración de la base de datos.
4. Publicar el proyecto por medio del Administrador de Internet Information Services (IIS) para publicar la API localmente.
5. Para el consumo de la api se debe de descargar del repositorio "Consumo de Api compra electronica" la solución "Compra" que se encuentra en la rama "master", tambiém desarrollada en Visual Studio.
6. Ejecutar el proyecto.

LIBRERIAS UTILIZADAS:

*Para la API compraElectronica:

using System.ComponentModel.DataAnnotations; ->  para indicar la clave primaria

using Microsoft.EntityFrameworkCore; -> permite acceder a los datos

using compraElectronica.Models; ->acceder a las clases del modelo

*Para la solución Compra que consume la API:

using Newtonsoft.Json; -> Para el uso de las respuestas Json

using System.IO; -> Para leer las respuestas de la API

using System.Net; -> Para el uso el consumo en Http

ACLARACIONES: No se utilizó el consumo de servicios por EndPoint. El llamado a la API se realiza directamente en la solución y se pueden ver los resultados por consola

Link del repositorio "Consumo de Api compra electronica": 


