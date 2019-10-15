using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorFaz
{
    class Program
    {
        private static UsuarioManager usrMgr;
        private static LenguajeManager lengMgr;
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");
            do
            {
                if (checkUsuariosExist())
                {

                    MostrarMenu();
                    ProcesarOpcion(Console.ReadLine().ToLower().ToCharArray()[0]);
                }
                else
                {
                    Console.WriteLine("Por favor registre un usuario.");
                    registrarUsuario();
                }
            } while (Continuar());
            Console.WriteLine("Adios!");
        }

        private static void registrarUsuario()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("*****     REGISTRAR USUARIO    *******");
            Console.WriteLine("**************************************");
            Console.WriteLine("Por favor, ingrese la cedula y el nombre del nuevo usuario, separados por una coma.");
            var info = Console.ReadLine();
            var infoArray = info.Split(',');
            usrMgr.Create(new Usuario(infoArray));

            Console.WriteLine("Usuario registrado.");

        }

        private static bool checkUsuariosExist()
        {
            List<Usuario> lstResults = usrMgr.RetrieveAll();
            return lstResults != null && lstResults.ToArray().Length > 0;
        }

        private static void ProcesarOpcion(char v)
        {
            switch (v)
            {
                case 'a':
                    Traducir();
                    break;
                case 'b':
                    RegistrarIdioma();
                    break;
            }
        }

        private static void RegistrarIdioma()
        {
            Console.WriteLine("Ingrese el nombre del idioma que desea registrar");
            lengMgr.Create(new Lenguaje(Console.ReadLine()));
        }

        private static bool Continuar()
        {
            Console.WriteLine("¿Desea continuar usando el servicio? (Y/N)");
            return (Console.ReadLine().ToLower().ToCharArray()[0].Equals('y'));
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Sleccione una opción.");
            Console.WriteLine("A. Traducir frase/palabra.");
            Console.WriteLine("B. Registrar idioma.");
        }

        private static void ListarLenguajes()
        {
            int i = 1;
            Lenguaje[] array = lengMgr.RetrieveAll().ToArray();
            foreach(Lenguaje data in array)
            {
                Console.WriteLine(i + data.ToString());
            }
        }
    }
}
