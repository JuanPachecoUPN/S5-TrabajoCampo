using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Campo_S5
{
    class LibreriaMensajes
    {
        static public void menuInventario()
        {
            Console.Clear();
            Console.WriteLine("======== MENÚ INVENTARIO =======");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Consultar productos disponibles");
            Console.WriteLine("3. Actualizar stock");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.WriteLine("================================");
        }
        static public void mensajeInvalido()
        {
            Console.WriteLine("Opción Invalida. Intente de nuevo");
        }

        static public void mensajeparaContinuar()
        {
            Console.WriteLine("\nPresione una tecla para continuar ....");
            Console.ReadKey();
        }
    }
}
