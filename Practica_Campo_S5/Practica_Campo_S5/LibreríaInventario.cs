using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Campo_S5
{
    internal class LibreríaInventario
    {
        public class Producto
        {
            public string Codigo;
            public string Nombre;
            public int Stock;
        }

        // Lista de productos (inventario)
        public static List<Producto> inventario = new List<Producto>();


        // FUNCIONES VOID

        public static void MostrarProductos()
        {
            Console.Clear();
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
            else
            {
                Console.WriteLine("Productos disponibles:");
                foreach (var p in inventario)
                {
                    Console.WriteLine($"Código: {p.Codigo}, Nombre: {p.Nombre}, Stock: {p.Stock}");
                }
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }


        // FUNCIONES CON RETURN

        public static Producto BuscarProducto(string codigo)
        {
            foreach (var p in inventario)
            {
                if (p.Codigo == codigo)
                    return p;
            }
            return null;
        }

        public static int ContarProductos()
        {
            return inventario.Count;
        }

        public static bool ValidarStock(Producto p, int cantidad)
        {
            return p.Stock >= cantidad;
        }


        // FUNCIONES CON PARAMETRO POR REFERENCIA

        public static void ActualizarStock(ref Producto p, int nuevoStock)
        {
            p.Stock = nuevoStock;
            Console.WriteLine($"Stock actualizado. Nuevo stock: {p.Stock}");
        }


        // AGREGAR Y ELIMINAR PRODUCTOS

        public static void AgregarProducto(string codigo, string nombre, int stock)
        {
            if (inventario.Count >= 10)
            {
                Console.WriteLine("No se pueden agregar más productos. Inventario lleno.");
                return;
            }

            Producto nuevo = new Producto
            {
                Codigo = codigo,
                Nombre = nombre,
                Stock = stock
            };

            inventario.Add(nuevo);
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public static void EliminarProducto(string codigo)
        {
            Producto p = BuscarProducto(codigo);
            if (p != null)
            {
                inventario.Remove(p);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}
