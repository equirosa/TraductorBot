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
    public class UsuarioManager
    {
        private UsuarioCrudFactory crudUsuario;

        public UsuarioManager()
        {
            crudUsuario = new UsuarioCrudFactory();
        }

        public void Create(Usuario usuario)
        {
            try
            {
            var c = crudUsuario.Retrieve<Usuario>(usuario);

            if (c != null)
            {
                //Usuario already exists.
                throw new BussinessException(3);
            }
            crudUsuario.Create(usuario);
        }
        catch (Exception ex)
        {
            ExceptionManager.GetInstance().Process(ex);
            }
    }

        public List<Usuario> RetrieveAll()
    {
        return crudUsuario.RetrieveAll<Usuario>();
    }

    public Usuario RetrieveById(Usuario usuario)
    {
        return crudUsuario.Retrieve<Usuario>(usuario);
    }

    internal void Update(Usuario usuario)
    {
        crudUsuario.Update(usuario);
    }

    internal void Delete(Usuario usuario)
    {
            crudUsuario.Delete(usuario);
    }
    }
}
