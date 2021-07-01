# **Documentación Oficial**

## *Aspectos Técnicos*

Software utilizado para el desarrollo de la aplicación:
- Visual Studio 2019

- Entity Framework en su versión 5.0.6

- Microsoft SQL Server Management Studio 18 junto con SQL Server Developer

- .Net Core 5.0

- Windows 10

## *Patrones de diseño*

- MVC (Modelo Vista Controlador)

MVC fuera utilizado para tener un mejor control de las interfaces gráficas y no sobrecargar las clases con proceso que no son exclusivas de ellas. Tambien para poder reutilizar el diseño de interfaces.

- Proxy

Proxy fue utilizado debido a que dentro del programa se cuenta con un login, entonces se vio la necesidad de agregar una capa de seguridad la cual protegerá información de la clase empleado tales como Usuario y Contraseña.  

## *Paquetes Externos*

- Nugets

    - Microsoft.EntityFrameworkCore v5.0.7
    - Microsoft.EntityFrameworkCore.Design v5.0.7
    - Microsoft.EntityFrameworkCore.SqlServer v5.0.7
    - itext7 v7.1.15

## *Instalación*

Para poder instalar el software es recomendado contar con .Net Core en su versión 5.0, un motor de base de datos de Sql Server (Developer o Express) y Microsoft SQL Server Management Studio 18, dicho software es necesario ya que el ejecutable será el encargado de crear la base de datos dentro de la computadora donde se este instalando, por medio del script llamado "Banco de Datos". Luego de haber instalado el software solamente es necesario ejecutar un acceso directo que será creado en el escritorio para hacer uso de dicho programa

Para más información sobre el proceso de instalación, hacer click [aquí](https://drive.google.com/file/d/1BSjHdyFx2DHxQ6rMALJGs4XyQ4N6QeR5/view?usp=sharing)