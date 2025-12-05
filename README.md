# Rastreador de Gastos (Expense Tracker App)
Esta es una aplicación de Rastreador de Gastos desarrollada en ASP.NET Core MVC utilizando componentes de código abierto.

## Introducción
La aplicación Rastreador de Gastos es una aplicación web desarrollada en ASP.NET Core 6 MVC que utiliza componentes de código abierto y base de datos SQL Server. Esta aplicación ayuda a los usuarios a gestionar eficientemente sus gastos proporcionando funciones para rastrear transacciones, organizar gastos en categorías y visualizar patrones de gasto.

## Tecnologías
- **ASP.NET Core 6 MVC**: El backend y frontend de la aplicación están desarrollados usando el framework ASP.NET Core 6 MVC.
- **Chart.js**: Utilizado para crear gráficos interactivos (dona y líneas) para visualización de datos.
- **DataTables**: Componente para tablas con paginación, ordenación y búsqueda.
- **Flatpickr**: Selector de fechas con soporte para español (México).
- **Bootstrap 5**: Framework CSS para estilos responsivos.
- **Font Awesome**: Iconos para la interfaz de usuario.
- **SQL Server Database**: SQL Server se utiliza como base de datos backend para almacenar datos de categorías y transacciones.
- **C# Programming Language**: C# es el lenguaje de programación principal usado para la lógica del servidor.
- **Entity Framework Core**: Entity Framework Core se utiliza para acceso y gestión de base de datos.

## Dependencias CDN
La aplicación utiliza las siguientes bibliotecas vía CDN:
- **jQuery** - Manipulación del DOM y AJAX
- **Bootstrap 5** - Framework CSS
- **Chart.js** - Gráficos interactivos
- **DataTables** - Tablas con funcionalidades avanzadas
- **Flatpickr** - Selector de fechas (con locale español)
- **Font Awesome 6** - Iconos

## Localización
La aplicación está completamente localizada en español (México - es-MX):
- Todos los textos de la interfaz están en español
- Formato de moneda: Peso Mexicano (MXN) - $1,234
- Formato de fecha: dd/MM/yyyy
- Mensajes de validación en español

## Cambios Recientes

### Eliminación de Syncfusion
Se eliminaron todos los componentes de Syncfusion para utilizar únicamente bibliotecas de código abierto:
- ❌ Syncfusion.EJ2.AspNet.Core (removido del .csproj)
- ❌ Licencia Syncfusion (removida de Program.cs)
- ❌ Tag helpers Syncfusion (removidos de _ViewImports.cshtml)
- ❌ CSS/JS Syncfusion (removidos del layout)

### Componentes de Reemplazo
| Componente Syncfusion | Reemplazo Open Source |
|----------------------|----------------------|
| ejs-grid | DataTables |
| ejs-chart (spline) | Chart.js (line) |
| ejs-accumulationchart (doughnut) | Chart.js (doughnut) |
| ejs-datepicker | Flatpickr |
| ejs-dropdownlist | Bootstrap select |
| ejs-textbox | Bootstrap form-control |
| ejs-numerictextbox | HTML input type="number" |
| ejs-button | Bootstrap button |
| ejs-sidebar | CSS sidebar personalizado |
| ejs-breadcrumb | Bootstrap breadcrumb |
| ejs-menu | Bootstrap nav |

## Características
1. **Operaciones CRUD**: Implementadas operaciones CRUD (Crear, Leer, Actualizar, Eliminar) tanto para categorías como para transacciones.
2. **Tablas con Paginación y Ordenación**: Utilizando DataTables para mejorar la presentación y accesibilidad de datos.
3. **Panel con Gráficos**: Panel que muestra gráficos interactivos para visualizar patrones de gasto.
4. **Menú Lateral Colapsable**: Integrado un menú lateral con navegación fácil entre secciones.
5. **Autenticación de Usuario**: Implementadas características de autenticación para acceso seguro.

## Arquitectura
La aplicación Rastreador de Gastos sigue una arquitectura Modelo-Vista-Controlador (MVC):
- **Modelo**: Representa los datos y la lógica de negocio de la aplicación.
- **Vista**: Muestra la interfaz de usuario de la aplicación.
- **Controlador**: Maneja las solicitudes del usuario y la interacción entre modelo y vista.

## Módulos
1. **Módulo de Autenticación**: Manejo de autenticación y autorización de usuarios.
2. **Módulo de Seguimiento de Gastos**: Módulo principal para gestionar transacciones y categorías.
3. **Módulo de Panel**: Panel personalizable con métricas y resúmenes de gastos.
4. **Módulo de Gestión de Categorías**: Gestión de categorías de gastos.
5. **Módulo de Perfil de Usuario**: Gestión de perfiles y configuraciones de cuenta.

## Flujo de la Aplicación
1. **Autenticación**: Los usuarios deben iniciar sesión para acceder a la aplicación.
2. **Panel**: Tras iniciar sesión, los usuarios ven el panel con visualizaciones de patrones de gasto.
3. **Gestión de Categorías**: Los usuarios pueden crear, actualizar o eliminar categorías de gastos.
4. **Seguimiento de Transacciones**: Los usuarios pueden registrar transacciones con fecha, monto, descripción y categoría.
5. **Navegación**: Los usuarios pueden navegar entre secciones usando el menú lateral.
6. **Cerrar Sesión**: Los usuarios pueden cerrar sesión de forma segura.

## Configuración de Desarrollo
1. Clonar el repositorio
2. Configurar la cadena de conexión en `appsettings.json`
3. Ejecutar migraciones: `dotnet ef database update`
4. Ejecutar la aplicación: `dotnet run`

## Video
https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/89735de4-f801-4d0a-9203-dd4d1f315a56

## Imágenes
![Screenshot (1069)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/5d20d458-9808-419f-bf8c-ccccf9b05dfd)
![Screenshot (1070)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/3988c7a0-01c7-482f-b7ec-906e7188edbc)
![Screenshot (1071)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/837aa6a5-eec0-409f-9cc9-3e49150b0847)
![Screenshot (1072)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/a11d86bb-2891-4372-8d96-ad8d00923b5f)
![Screenshot (1073)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/a8f34619-fe8a-4ee5-8189-8219ca86c71f)
![Screenshot (1074)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/8ba82e4a-629e-411d-8630-5a8d44d5e674)
![Screenshot (1075)](https://github.com/sandesh300/Expense-Tracker-App/assets/92014891/073c9bbc-1066-4baa-a017-61c633a11d25)
