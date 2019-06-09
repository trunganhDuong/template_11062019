using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public interface IUtilityRepository
    {
        GridModel<Utility> GetList(SearchRequest searchRequest);

        Utility GetById(int id);

        bool Save(Utility utility);

        bool Delete(int id);
    }
}
