
# Caso: Sistema de Gestión de Inventario en una Tienda

**Actividad:**

Desarrollar un programa en C# que permita administrar el inventario básico de
una tienda utilizando funciones con retorno y void, parámetros por valor y
por referencia, y variables globales y locales. El sistema debe organizarse en
bibliotecas propias (.cs) para reforzar la programación modular.

**Descripcion del problema:**

La tienda necesita un sistema sencillo con el siguiente menú:
- 1 Agregar producto al inventario.
- 2 Consultar productos disponibles.
- 3 Actualizar stock de un producto.
- 4 Eliminar producto.
- 5 Salir

**Condiciones:**

- El inventario tendrá un máximo de 10 productos.
- Al agregar un producto, se deben registrar: código, nombre y stock inicial.
- La opción consultar mostrará todos los productos registrados.
- En actualizar stock, se deberá pasar el parámetro por referencia para modificar el valor del stock directamente.
- En eliminar producto, el programa debe validar si existe en la lista antes de borrarlo.
- El programa debe funcionar en bucle hasta que el usuario elija "Salir".


## Reglas adicionales

- Se deben usar al menos 3 funciones void (ej. mostrar menú, mostrar mensajes, listar productos).
- Se deben usar al menos 3 funciones con return (ej. buscar producto, validar stock, contar productos).
- El programa debe contener ejemplos de parámetros por valor y por referencia.
- Se deben implementar al menos dos bibliotecas propias:

```bash
- LibreriaMensajes.cs → con funciones de saludo e impresión de mensajes.

- LibreriaInventario.cs → con funciones de gestión de productos.
```

## 🚀 Info del Grupo

**Integrantes:**

```bash
Machuca Ramírez, Luis Miguel     n00420048@upn.pe

Pacheco Ibarra, Juan Carlos      n00119355@upn.pe

Palomino Delgado, Cesar Jairo    n00479037@upn.pe

Quispe Guzman, Victor Antonio    n00419399@upn.pe
```