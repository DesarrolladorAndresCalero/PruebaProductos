# PruebaProductos API 🛒

Este es un proyecto de prueba realizado con **.NET 8** para gestionar productos mediante una API RESTful.

## 📌 Características

- CRUD completo de productos (`GET`, `POST`, `PUT`, `DELETE`).
- Arquitectura basada en controladores (`Controllers`).
- Modelo simple `Product` con propiedades básicas.
- Documentación interactiva con Swagger.
- Buenas prácticas REST y manejo de errores básico.

---

## 📁 Estructura del proyecto

```
PruebaProductos/
├── Controllers/
│   └── ProductsController.cs
├── Models/
│   └── Product.cs
├── Program.cs
├── appsettings.json
├── Properties/
│   └── launchSettings.json
└── PruebaProductos.csproj
```

---

## 🚀 Cómo ejecutar el proyecto

### 1. Clona el repositorio

```bash
git clone https://github.com/DesarrolladorAndresCalero/PruebaProductos.git
cd PruebaProductos
```

### 2. Ejecuta el proyecto

```bash
dotnet run
```

### 3. Accede a Swagger

Abre tu navegador y visita:

```
http://localhost:5190/swagger
```

Allí encontrarás la documentación y podrás probar los endpoints.

---
