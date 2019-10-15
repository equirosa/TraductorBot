using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorFaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludar();
            MostrarMenu();
        }

        private static void Saludar()
        {
            Console.WriteLine("Hola!");
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Sleccione un lenguaje.");
            ListarLenguajes();
        }

        private static void ListarLenguajes()
        {

        }
    }
}
