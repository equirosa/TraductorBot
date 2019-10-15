using DataAccess.Dao;
using DataAcess.Mapper;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class TraduccionMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_ORIGINAL = "SPANISH";
        private const string DB_COL_OBJETIVO = "LENGUAJE";
        private const string DB_COL_RESULTADO = "RESULTADO";
        private const string DB_COL_CREADOR = "CREADOR";
        private const string DB_COL_FECHA_CREACION = "FECHA";
        private LenguajeMapper lenguajeMapper;
        private PalabraEspannolMapper palabraMapper;
        private UsuarioMapper usuarioMapper;

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            return new Traduccion(GetIntValue(row, DB_COL_ID),palabraMapper.
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
