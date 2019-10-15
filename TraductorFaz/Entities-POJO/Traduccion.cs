using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Traduccion : BaseEntity
    {
        public int Id { get; set; }
        public PalabraEspannol Original { get; set; }
        public Lenguaje Objetivo { get; set; }
        public string Resultado { get; set; }
        public Usuario Creador { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Traduccion() { }
        public Traduccion(int id, PalabraEspannol spanish, Lenguaje lenguaje, string resultado, Usuario creador, DateTime fechacreacion)
        {
            if(spanish != null && lenguaje != null && resultado!= null)
            {
                Id = id;
                Original = spanish;
                Objetivo = lenguaje;
                Resultado = resultado;
                Creador = creador;
                FechaCreacion = fechacreacion;
            }
            else
            {
                throw new Exception("Toda la información es requerida.");
            }
        }

    }
}
