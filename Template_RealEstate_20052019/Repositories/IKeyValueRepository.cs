using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Repositories
{
    public interface IKeyValueRepository
    {
        bool Save(string key, string value);

        string GetByKey(string key);
    }
}
