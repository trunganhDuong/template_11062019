using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Database;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly IDatabase _database;

        public ArticleRepository(IDatabase database)
        {
            this._database = database;
        }

        public bool Delete(int id)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_ItemId", id);

            var data = _database.ExecuteScalar<int>("Article_Delete", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }

        public Article GetById(int id)
        {
            var param = new SqlServerParameter();
            var result = new Article();
            param.Add_Parameter("@_ItemId", id);

            var data = _database.ExecuteToTable("Article_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Rows.Count > 0)
            {
                result = SqlMapper<Article>.Map(data).FirstOrDefault();
            }

            return result;
        }

        public GridModel<Article> GetList(SearchRequest searchRequest)
        {
            var param = new SqlServerParameter();
            var result = new GridModel<Article>();
            param.Add_Parameter("@_PageIndex", searchRequest.PageIndex);
            param.Add_Parameter("@_PageSize", searchRequest.PageSize);

            var data = _database.ExecuteToDataset("Article_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Tables.Count > 0)
            {
                result.Data = SqlMapper<Article>.Map(data.Tables[0]);
                result.TotalRecord = (int)data.Tables[1].Rows[0]["TotalRecord"];
                result.PageSize = searchRequest.PageSize;
                result.CurrentPage = searchRequest.PageIndex;
            }

            return result;
        }

        public bool Save(Article article)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_ArticleId", article.ArticleId);
            param.Add_Parameter("@_ArticleTitle", article.ArticleTitle);
            param.Add_Parameter("@_Sapo", article.Sapo);
            param.Add_Parameter("@_Avatar", article.Avatar);
            param.Add_Parameter("@_Content", article.Content);

            var data = _database.ExecuteScalar<int>("Article_Save", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }
    }
}
