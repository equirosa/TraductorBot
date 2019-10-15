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
    public class LenguajeMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_NOMBRE = "NOMBRE";
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            return new Lenguaje(GetStringValue(row, DB_COL_NOMBRE));
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
            var operation = new SqlOperation { ProcedureName = "CRE_LENGUAJE_PR" };
            var l = (Lenguaje)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            return operation;

        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_LENGUAJE_PR" };
            var l = (Lenguaje)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            return operation;
        }

        public SqlOperation GetRetrieveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_LENGUAJE_PR" };
            return operation;
        }

        public SqlOperation GetRetrieveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_LENGUAJE_PR" };
            var l = (Lenguaje)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_LENGUAJE_PR" };
            var l = (Lenguaje)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, l.Nombre);
            return operation;
        }
    }
}
