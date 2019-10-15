using DataAccess.Dao;
using DataAcess.Mapper;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAccess.Mapper
{
    public class UsuarioMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            string[] infoArray = new string[2];
            infoArray[0] = GetStringValue(row, DB_COL_ID);
            infoArray[1] = GetStringValue(row, DB_COL_NOMBRE);
            Usuario usuario = new Usuario(infoArray);
            return usuario;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach(var row in lstRows)
            {
                var usuario = BuildObject(row);
                lstResults.Add(usuario);
            }
            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_USUARIO_PR" };
            var u = (Usuario)entity;
            operation.AddVarcharParam(DB_COL_ID, u.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE, u.Nombre);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_USUARIO_PR" };
            var u = (Usuario)entity;
            operation.AddVarcharParam(DB_COL_ID, u.Id);
            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_USUARIO_PR"};
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USUARIO_PR" };
            var u = (Usuario)entity;
            operation.AddVarcharParam(DB_COL_ID, u.Id);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_USUARIO_PR" };
            var u = (Usuario)entity;
            operation.AddVarcharParam(DB_COL_ID, u.Id);
            return operation;
        }
    }
}
