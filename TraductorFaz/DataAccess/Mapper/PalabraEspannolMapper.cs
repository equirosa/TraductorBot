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
    public class PalabraEspannolMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_PALABRA = "PALABRA";
        private const string DB_COL_POPULARIDAD = "POPULARIDAD";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            string[] infoArray = new string[2];
            infoArray[0] = GetStringValue(row, DB_COL_PALABRA);
            infoArray[1] = GetStringValue(row, DB_COL_POPULARIDAD);
            return new PalabraEspannol(infoArray);
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();
            foreach(var row in lstRows)
            {
                lstResults.Add(BuildObject(row));
            }
            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_PALABRA_ESPANNOL_PR" };
            var u = (PalabraEspannol)entity;
            operation.AddVarcharParam(DB_COL_PALABRA, u.Palabra);
            operation.AddIntParam(DB_COL_POPULARIDAD, u.Popularidad);
            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_PALABRA_ESPANNOL_PR" };
            var u = (PalabraEspannol)entity;
            operation.AddVarcharParam(DB_COL_PALABRA, u.Palabra);
            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_PALABRA_ESPANNOL_PR" };
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PALABRA_ESPANNOL_PR" };
            var u = (PalabraEspannol)entity;
            operation.AddVarcharParam(DB_COL_PALABRA, u.Palabra);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_PALABRA_ESPANNOL_PR" };
            var u = (PalabraEspannol)entity;
            operation.AddVarcharParam(DB_COL_PALABRA, u.Palabra);
            return operation;
        }
    }
}
