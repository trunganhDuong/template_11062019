using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Database;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDatabase _database;

        public ContactRepository(IDatabase database)
        {
            this._database = database;
        }

        public GridModel<Contact> GetList(SearchRequest searchRequest)
        {
            var param = new SqlServerParameter();
            var result = new GridModel<Contact>();
            param.Add_Parameter("@_PageIndex", searchRequest.PageIndex);
            param.Add_Parameter("@_PageSize", searchRequest.PageSize);

            var data = _database.ExecuteToDataset("Contact_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Tables.Count > 0)
            {
                result.Data = SqlMapper<Contact>.Map(data.Tables[0]);
                result.TotalRecord = (int)data.Tables[1].Rows[0]["TotalRecord"];
                result.PageSize = searchRequest.PageSize;
                result.CurrentPage = searchRequest.PageIndex;
            }

            return result;
        }

        public bool Save(Contact contact)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_Name", contact.Name);
            param.Add_Parameter("@_Phone", contact.Phone);
            param.Add_Parameter("@_Email", contact.Email);
            param.Add_Parameter("@_Message", contact.Message);

            var data = _database.ExecuteScalar<int>("Contact_Save", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }
    }
}
