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
        private static Usuario currentUser = null;
        private static UsuarioManager usrMgr;
        private static LenguajeManager lengMgr;
        private static TraduccionManager tradMgr;
        private static PalabraEspannolManager espMgr;
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");
            do
            {
                if (checkUsuariosExist())
                {
                    if (userLoggedIn())
                    {
                        MostrarMenu();
                        ProcesarOpcion(Console.ReadLine().ToLower().ToCharArray()[0]);
                    }
                    else
                        login();
                }
                else
                {
                    Console.WriteLine("Por favor registre un usuario.");
                    registrarUsuario();
                }
            } while (Continuar());
            Console.WriteLine("Adios!");
        }

        private static void login()
        {
            Console.WriteLine("Inicie Sesion\n" +
                "Ingrese su cedula.");
            string cedula = Console.ReadLine();
            Usuario temp = usrMgr.RetrieveById(new Usuario(cedula));
            if (temp.Nombre != null)
            {
                currentUser = temp;
                Console.WriteLine("Session iniciada.");
            }
            else
            {
                Console.WriteLine("Ese usuario no se encuentra registrado.");
            }
        }

        private static bool userLoggedIn()
        {
            return currentUser != null;
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

        private static void Traducir()
        {
            Lenguaje lenguaje;
            do {
                 lenguaje = SeleccionarLenguaje();
            } while (lenguaje == null);
            Console.WriteLine("Por favor, introduzca la frase que desea traducir.");
            string frase = Console.ReadLine();
            string[] array = frase.Split(' ');
            string[] resultado = new string[array.Length];
            foreach(string palabra in array){
                if(checkTranslationAvailable(palabra, lenguaje))
                {
                    Console.WriteLine(tradMgr.RetrieveById)
                }

            }
        }

        private static bool checkTranslationAvailable(string palabra, Lenguaje lenguaje)
        {
            
        }

        private static Lenguaje SeleccionarLenguaje()
        {
            string seleccion = null;
                ListarLenguajes();
                Console.WriteLine("Escriba el nombre de uno de los lenguajes listados, o ingrese 0 si desea registrar uno.");
                seleccion = Console.ReadLine();
                if (seleccion.Equals("0"))
                {
                    RegistrarIdioma();
                    return null;
                }
                else
                {
                    if (checkLenguajeExists(seleccion))
                    {
                        return new Lenguaje(seleccion);
                    }
                    else
                    {
                        Console.WriteLine("Ese lenguaje no se encuentra registrado.");
                        return null;
                }
            }
        }

        private static bool checkLenguajeExists(string seleccion)
        {
            Lenguaje[] lenguajes = ObtenerLenguajes();
            foreach(Lenguaje data in lenguajes)
            {
                if (data.Equals(seleccion))
                    return true;
            }
            return false;
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
            Lenguaje[] array = ObtenerLenguajes(); 
            foreach(Lenguaje data in array)
            {
                Console.WriteLine(i + data.ToString());
            }
        }

        private static Lenguaje[] ObtenerLenguajes()
        {
            return lengMgr.RetrieveAll().ToArray();
        }
    }
}
