using System;
namespace Puentes_de_Madison
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nIngrese la descripción del puente :");
                string descripcion = Console.ReadLine() ?? string.Empty;
                if (Puente_de_Madison.ValidarDescripcion(descripcion))
                {
                    Console.WriteLine("VALIDO");
                }
                else
                {
                    Console.WriteLine("iNVALIDO");
                }
                Console.WriteLine("¿Desea ingresar otra descripción? (S para sí, cualquier otra tecla para salir):");
                string opcion = Console.ReadLine() ?? string.Empty;
                if (!opcion.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }
            }
        }
    }
}