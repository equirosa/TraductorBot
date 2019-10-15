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
    public class TraduccionManager
    {
        private TraduccionCrudFactory crudTraduccion;

        public TraduccionManager()
        {
            crudTraduccion = new TraduccionCrudFactory();
        }

        public void Create(Traduccion traduccion)
        {
            try
            {
            var c = crudTraduccion.Retrieve<Traduccion>(traduccion);

            if (c != null)
            {
                //Traduccion already exists.
                throw new BussinessException(3);
            }
            crudTraduccion.Create(traduccion);
        }
        catch (Exception ex)
        {
            ExceptionManager.GetInstance().Process(ex);
            }
    }

        public List<Traduccion> RetrieveAll()
    {
        return crudTraduccion.RetrieveAll<Traduccion>();
    }

    public Traduccion RetrieveById(Traduccion traduccion)
    {
        return crudTraduccion.Retrieve<Traduccion>(traduccion);
    }

    internal void Update(Traduccion traduccion)
    {
        crudTraduccion.Update(traduccion);
    }

    internal void Delete(Traduccion traduccion)
    {
            crudTraduccion.Delete(traduccion);
    }
    }
}
