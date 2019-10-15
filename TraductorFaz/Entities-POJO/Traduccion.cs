using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Traduccion : BaseEntity
    {
        private string Original { get; set; }
        private Lenguaje Objetivo { get; set; }
        private string Resultado { get; set; }

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
