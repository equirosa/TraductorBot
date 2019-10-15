using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Translation : BaseEntity
    {
        private string Spanish { get; set; }
        private Language Language { get; set; }
        private string Translated { get; set; }

    }
}
