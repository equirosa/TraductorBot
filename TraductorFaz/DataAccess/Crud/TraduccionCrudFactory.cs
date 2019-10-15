using System;
using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;

namespace DataAccess.Crud
{
    public class TraduccionCrudFactory : CrudFactory
    {
        TraduccionMapper mapper;
        public TraduccionCrudFactory() : base()
        {
            mapper = new TraduccionMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entity)
        {
            var traduccion = (Traduccion)entity;
            var sqlOperation = mapper.GetCreateStatement(traduccion);
            dao.ExecuteProcedure(sqlOperation);

        }

        public override void Delete(BaseEntity entity)
        {
            var traduccion = (Traduccion)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(traduccion));
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetrieveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstCustomers = new List<T>();
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetrieveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCustomers.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }
            return lstCustomers;
        }

        public override void Update(BaseEntity entity)
        {
            var traduccion = (Traduccion)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(traduccion));
        }
    }
}
