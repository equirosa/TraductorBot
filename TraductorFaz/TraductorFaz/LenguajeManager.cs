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
    public class LenguajeManager
    {
        private LenguajeCrudFactory crudLenguaje;

        public LenguajeManager()
        {
            crudLenguaje = new LenguajeCrudFactory();
        }

        public void Create(Lenguaje lenguaje)
        {
            try
            {
            var c = crudLenguaje.Retrieve<Lenguaje>(lenguaje);

            if (c != null)
            {
                //Lenguaje already exists.
                throw new BussinessException(3);
            }
            crudLenguaje.Create(lenguaje);
        }
        catch (Exception ex)
        {
            ExceptionManager.GetInstance().Process(ex);
            }
    }

        public List<Lenguaje> RetrieveAll()
    {
        return crudLenguaje.RetrieveAll<Lenguaje>();
    }

    public Lenguaje RetrieveById(Lenguaje lenguaje)
    {
        return crudLenguaje.Retrieve<Lenguaje>(lenguaje);
    }

    internal void Update(Lenguaje lenguaje)
    {
        crudLenguaje.Update(lenguaje);
    }

    internal void Delete(Lenguaje lenguaje)
    {
            crudLenguaje.Delete(lenguaje);
    }
    }
}
