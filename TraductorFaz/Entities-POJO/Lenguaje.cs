using System;

namespace Entities_POJO
{
    public class Lenguaje : BaseEntity
    {
        public string Nombre { get; set; }

        public Lenguaje() { }
        public Lenguaje(string nombre)
        {
            if (nombre != null)
            {
                Nombre = nombre;
            }
            else
            {
                throw new Exception("El nombre del lenguaje no puede ser nulo");
            }
        }
    }
}
