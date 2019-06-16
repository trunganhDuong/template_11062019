using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Database;
using Template_RealEstate_20052019.Models;
using Template_RealEstate_20052019.Utils;

namespace Template_RealEstate_20052019.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabase _database;

        public UserRepository(IDatabase database)
        {
            this._database = database;
        }

        public bool CreateUser(User user)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_Username", user.Username);
            param.Add_Parameter("@_Email", user.Email);
            param.Add_Parameter("@_Password", user.Password);
            param.Add_Parameter("@_UserType", (int)user.UserType);

            var data = _database.ExecuteScalar<int>("User_Create", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }

        public bool UpdatePassword(User user, string newPassword)
        {
            var dbUser = GetUser(user);
            if (!Crypto.VerifyPassword(dbUser.Password, user.Password))
            {
                return false;
            }

            var param = new SqlServerParameter();
            param.Add_Parameter("@_UserId", user.UserId);
            param.Add_Parameter("@_NewPassword", Crypto.HashPassword(newPassword));

            var data = _database.ExecuteScalar<int>("User_UpdatePassword", param, ExecuteTypeEnum.StoredProcedure);

            return data == 1;
        }

        public User Validate(User user)
        {
            if (user == null)
            {
                return null;
            }

            var checkUser = GetUser(user);
            if (checkUser == null)
            {
                return null;
            }

            if (Crypto.VerifyPassword(checkUser.Password, user.Password))
            {
                checkUser.Password = string.Empty;

                return checkUser;
            }

            return null;
        }

        private User GetUser(User user)
        {
            var param = new SqlServerParameter();
            param.Add_Parameter("@_UsernameOrEmail", user.Username);

            var data = _database.ExecuteToTable("User_Get", param, ExecuteTypeEnum.StoredProcedure);
            if (data != null && data.Rows.Count > 0)
            {
                return SqlMapper<User>.Map(data)[0];
            }

            return null;
        }
    }
}
