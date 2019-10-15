using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Usuario : BaseEntity
    {
        private string cedula;

        public string Id { get; set;}
        public string Nombre { get; set; }

        public Usuario() { }
        public Usuario(string[] infoArray)
        {
            if(infoArray!=null && infoArray.Length >= 2)
            {
                Id = infoArray[0];
                Nombre = infoArray[1];
            }
            else
            {
                throw new Exception("Todos los valores son requeridos. [Id,Nombre]");
            }
        }

        public Usuario(string cedula)
        {
            this.Id = cedula;
        }
    }
}
