# Northwind Application with Wisej.NET, EntitySpaces, and PostgreSQL

This project is a .NET 8 application built with Visual Studio 2022, using Wisej.NET for the frontend, EntitySpaces as the ORM, and PostgreSQL as the database.

## Requirements

- Visual Studio 2022
- .NET 8 SDK
- PostgreSQL
- EntitySpaces libraries
- Wisej.NET libraries

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/northwind-app.git
cd northwind-app
```

### 2. Set up PostgreSQL database

- Ensure PostgreSQL is installed and running on your local machine.
- Create a new database in PostgreSQL:
  
  ```sql
  CREATE DATABASE northwind;
  ```
  
- Run the Northwind database script to create tables and insert data:
  
  ```bash
  psql -U yourusername -d northwind -f path/to/northwind.sql
  ```

### 3. Configure the application

- Open the solution in Visual Studio 2022.
- Go to `appsettings.json` and update the PostgreSQL connection string with your database credentials:
  
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Database=northwind;Username=yourusername;Password=yourpassword"
    }
  }
  ```

### 4. Restore NuGet packages

- In Visual Studio, restore the NuGet packages by right-clicking the solution and selecting "Restore NuGet Packages."

### 5. Run the application

- Set the startup project to the Wisej.NET frontend project.
- Build and run the application by pressing `F5` or clicking the "Start" button in Visual Studio.

## Troubleshooting

- Ensure that PostgreSQL is running and that the connection string is correctly configured.
- If there are any issues with EntitySpaces, ensure that the correct libraries are referenced and that the configuration is correct.

## License

This project is licensed under the MIT License.

---

# Aplicación Northwind con Wisej.NET, EntitySpaces y PostgreSQL

Este proyecto es una aplicación .NET 8 construida con Visual Studio 2022, utilizando Wisej.NET para el frontend, EntitySpaces como ORM y PostgreSQL como base de datos.

## Requisitos

- Visual Studio 2022
- .NET 8 SDK
- PostgreSQL
- Librerías de EntitySpaces
- Librerías de Wisej.NET

## Comenzando

### 1. Clona el repositorio

```bash
git clone https://github.com/yourusername/northwind-app.git
cd northwind-app
```

### 2. Configurar la base de datos PostgreSQL

- Asegúrate de que PostgreSQL esté instalado y en ejecución en tu máquina local.
- Crea una nueva base de datos en PostgreSQL:
  
  ```sql
  CREATE DATABASE northwind;
  ```
  
- Ejecuta el script de la base de datos Northwind para crear las tablas e insertar datos:
  
  ```bash
  psql -U tuusuario -d northwind -f path/to/northwind.sql
  ```

### 3. Configura la aplicación

- Abre la solución en Visual Studio 2022.
- Ve a `appsettings.json` y actualiza la cadena de conexión de PostgreSQL con tus credenciales de base de datos:
  
  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Database=northwind;Username=tuusuario;Password=tupassword"
    }
  }
  ```

### 4. Restaurar paquetes NuGet

- En Visual Studio, restaura los paquetes NuGet haciendo clic derecho en la solución y seleccionando "Restaurar paquetes NuGet."

### 5. Ejecuta la aplicación

- Establece el proyecto de inicio en el proyecto frontend de Wisej.NET.
- Compila y ejecuta la aplicación presionando `F5` o haciendo clic en el botón "Iniciar" en Visual Studio.

## Solución de problemas

- Asegúrate de que PostgreSQL esté en ejecución y que la cadena de conexión esté correctamente configurada.
- Si hay algún problema con EntitySpaces, asegúrate de que las bibliotecas correctas estén referenciadas y que la configuración sea correcta.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.

---

Este README te proporcionará una guía clara tanto en inglés como en español para ejecutar tu aplicación localmente.