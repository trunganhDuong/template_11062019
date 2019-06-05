using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Database;

namespace Template_RealEstate_20052019.Repositories
{
    public class KeyValueRepository : IKeyValueRepository
    {
        private readonly IDatabase _database;

        public KeyValueRepository(IDatabase database)
        {
            this._database = database;
        }

        public string GetByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                return string.Empty;

            var param = new SqlServerParameter();
            param.Add_Parameter("@_Key", key);
            var data = _database.ExecuteToTable("KeyValue_GetByKey", param, ExecuteTypeEnum.StoredProcedure);
            if (data == null || data.Rows.Count <= 0)
            {
                return string.Empty;
            }
            return (string)data.Rows[0]["Value"];
        }

        public bool Save(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
                return false;

            var param = new SqlServerParameter();
            param.Add_Parameter("@_Key", key);
            param.Add_Parameter("@_Value", value);

            var data = _database.ExecuteScalar<int>("KeyValue_Save", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }
    }
}
