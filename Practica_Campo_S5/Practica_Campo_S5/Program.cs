using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Campo_S5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int opcionesmenu, stock;
            string codigo, nombre;

            do
            {
                LibreriaMensajes.menuInventario();
                Console.Write("Seleccione una opción: ");
                opcionesmenu = int.Parse(Console.ReadLine());

                if (opcionesmenu >= 1 && opcionesmenu <= 4)
                {
                    switch (opcionesmenu)
                    {
                        case 1:
                            Console.WriteLine("Agregar Producto");
                            Console.Write("Ingrese el código: ");
                            codigo = Console.ReadLine();
                            Console.Write("Ingrese la descripcion: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese el stock: ");
                            stock = int.Parse(Console.ReadLine());
                            LibreríaInventario.AgregarProducto(codigo, nombre, stock);
                            break;
                        case 2:
                            LibreríaInventario.MostrarProductos();
                            break;
                        case 3:
                            Console.WriteLine("Actualizar Stock");
                            Console.Write("Ingrese el código: ");
                            codigo = Console.ReadLine();
                            LibreríaInventario.Producto p = LibreríaInventario.BuscarProducto(codigo);
                            Console.Write("Ingrese el nuevo stock: ");
                            stock = int.Parse(Console.ReadLine());
                            LibreríaInventario.ActualizarStock(ref p, stock);
                            break;  
                        case 4:
                            Console.WriteLine("ELIMINAR PRODUCTO");
                            Console.Write("Ingrese el código: ");
                            codigo = Console.ReadLine();
                            LibreríaInventario.EliminarProducto(codigo);
                            break;
                    }
                }
                else
                {
                    if (opcionesmenu != 5)
                    {
                        LibreriaMensajes.mensajeInvalido();
                    }

                    LibreriaMensajes.mensajeparaContinuar();
                }
            }
            while (opcionesmenu != 5);
        }
    }
}
