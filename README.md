# Gestión de Clientes y Direcciones

Este es un proyecto desarrollado en **ASP.NET Core MVC** para la gestión de clientes y sus direcciones asociadas. Utiliza **Code First** para configurar la base de datos y **Data Annotations** para las validaciones, asegurando una entrada de datos robusta y adecuada.

## Características

- **Gestión de Clientes**: Permite crear, ver, editar y eliminar clientes.
- **Gestión de Direcciones**: Cada cliente puede tener múltiples direcciones asociadas, gestionadas desde una relación de uno a muchos.
- **Validaciones con Data Annotations**: Las propiedades del modelo están decoradas con anotaciones de datos para validar entradas como el nombre, apellido y edad.
- **Confirmación de Eliminación**: Al eliminar un cliente con direcciones asociadas, se muestra una confirmación adicional indicando que todas las direcciones vinculadas también serán eliminadas.

## Tecnologías Utilizadas

- **ASP.NET Core MVC**: Framework para desarrollar aplicaciones web con el patrón MVC.
- **Entity Framework Core (Code First)**: Para crear y gestionar la base de datos a partir del código del modelo.
- **Razor Pages**: Utilizado para crear vistas dinámicas en el proyecto.
- **Bootstrap**: Interfaz de usuario mejorada con estilos y componentes de Bootstrap.
- **SQL Server**: Base de datos configurada para almacenar los datos de clientes y direcciones.

## Estructura del Proyecto

- `Controllers`: Controladores que gestionan las acciones de clientes y direcciones.
- `Models`: Modelos `Client` y `Address`, que incluyen relaciones y validaciones con Data Annotations.
- `Views`: Vistas Razor para la interfaz de usuario, como crear, ver y eliminar clientes y direcciones.
- `Migrations`: Migraciones generadas por Code First para mantener la base de datos actualizada.

## Instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/tu_usuario/nombre_del_repositorio.git
