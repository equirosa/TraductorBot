using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraductorFaz
{
    public class PalabraEspannolManager
    {
        private PalabraEspannolCrudFactory crudPalabraEspannol;

        public PalabraEspannolManager()
        {
            crudPalabraEspannol = new PalabraEspannolCrudFactory();
        }

        public void Create(PalabraEspannol palabraEspannol)
        {
            try
            {
            var c = crudPalabraEspannol.Retrieve<PalabraEspannol>(palabraEspannol);

            if (c != null)
            {
                //PalabraEspannol already exists.
                throw new BussinessException(3);
            }
            crudPalabraEspannol.Create(palabraEspannol);
        }
        catch (Exception ex)
        {
            ExceptionManager.GetInstance().Process(ex);
            }
    }

        public List<PalabraEspannol> RetrieveAll()
    {
        return crudPalabraEspannol.RetrieveAll<PalabraEspannol>();
    }

    public PalabraEspannol RetrieveById(PalabraEspannol palabraEspannol)
    {
        return crudPalabraEspannol.Retrieve<PalabraEspannol>(palabraEspannol);
    }

    internal void Update(PalabraEspannol palabraEspannol)
    {
        crudPalabraEspannol.Update(palabraEspannol);
    }

    internal void Delete(PalabraEspannol palabraEspannol)
    {
            crudPalabraEspannol.Delete(palabraEspannol);
    }
    }
}
