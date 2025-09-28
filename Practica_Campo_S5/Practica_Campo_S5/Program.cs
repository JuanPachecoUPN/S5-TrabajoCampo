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
            int opcionesmenu;

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

                            break;
                        case 2:

                            break;
                        case 3:

                            break;  
                        case 4: 

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
