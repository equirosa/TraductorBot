using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Traduccion : BaseEntity
    {
        private string Spanish { get; set; }
        private Lenguaje Language { get; set; }
        private string Translated { get; set; }

    }
}
