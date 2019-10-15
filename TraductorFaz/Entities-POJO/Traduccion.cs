using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Traduccion : BaseEntity
    {
        public string Original { get; set; }
        public Lenguaje Objetivo { get; set; }
        public string Resultado { get; set; }

        public Traduccion() { }
        public Traduccion(string spanish, Lenguaje lenguaje, string resultado)
        {
            if(spanish != null && lenguaje != null && resultado!= null)
            {
                Original = spanish;
                Objetivo = lenguaje;
                Resultado = resultado;
            }
            else
            {
                throw new Exception("Toda la información es requerida.");
            }
        }

    }
}
