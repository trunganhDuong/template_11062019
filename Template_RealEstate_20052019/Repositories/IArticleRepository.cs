using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public interface IArticleRepository
    {
        GridModel<Article> GetList(SearchRequest searchRequest);

        Article GetById(int id);

        bool Save(Article article);

        bool Delete(int id);
    }
}
