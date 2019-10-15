using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Usuario : BaseEntity
    {
        public string Id { get; set;}
        public string Name { get; set; }

        public Usuario() { }
        public Usuario(string[] infoArray)
        {
            if(infoArray!=null && infoArray.Length >= 2)
            {
                Id = infoArray[0];
                Name = infoArray[1];
            }
            else
            {
                throw new Exception("Todos los valores son requeridos. [Id,Name]");
            }
        }
    }
}
