using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Database
{
    public interface IDatabase
    {
        void ExecuteNonQuery(string query, SqlServerParameter parameter, ExecuteTypeEnum type);

        DataTable ExecuteToTable(string query, SqlServerParameter parameter, ExecuteTypeEnum type);

        DataSet ExecuteToDataset(string query, SqlServerParameter parameter, ExecuteTypeEnum type);

        T ExecuteScalar<T>(string query, SqlServerParameter parameter, ExecuteTypeEnum type);

        T ExecuteScalarFunction<T>(string query, SqlServerParameter parameter, ExecuteTypeEnum type);
    }
}
