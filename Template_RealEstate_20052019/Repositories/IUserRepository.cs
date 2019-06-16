using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public interface IUserRepository
    {
        bool CreateUser(User user);

        User Validate(User user);

        bool UpdatePassword(User user, string newPassword);
    }
}
