using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Database;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public class UtilityRepository : IUtilityRepository
    {
        private readonly IDatabase _database;

        public UtilityRepository(IDatabase database)
        {
            this._database = database;
        }

        public bool Delete(int id)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_ItemId", id);

            var data = _database.ExecuteScalar<int>("Utilities_Delete", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }

        public Utility GetById(int id)
        {
            var param = new SqlServerParameter();
            var result = new Utility();
            param.Add_Parameter("@_ItemId", id);

            var data = _database.ExecuteToTable("Utilities_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Rows.Count > 0)
            {
                result = SqlMapper<Utility>.Map(data).FirstOrDefault();
            }

            return result;
        }

        public GridModel<Utility> GetList(SearchRequest searchRequest)
        {
            var param = new SqlServerParameter();
            var result = new GridModel<Utility>();
            param.Add_Parameter("@_PageIndex", searchRequest.PageIndex);
            param.Add_Parameter("@_PageSize", searchRequest.PageSize);

            var data = _database.ExecuteToDataset("Utilities_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Tables.Count > 0)
            {
                result.Data = SqlMapper<Utility>.Map(data.Tables[0]);
                result.TotalRecord = (int)data.Tables[1].Rows[0]["TotalRecord"];
                result.PageSize = searchRequest.PageSize;
                result.CurrentPage = searchRequest.PageIndex;
            }

            return result;
        }

        public bool Save(Utility utility)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_Type", (int)utility.Type);
            param.Add_Parameter("@_Description", utility.Description);
            param.Add_Parameter("@_ItemId", utility.UtilityId);

            var data = _database.ExecuteScalar<int>("Utilities_Save", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }
    }
}
