using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_RealEstate_20052019.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Email { get; set; }

        public UserEnum.UserType UserType { get; set; }

        public int UserId { get; set; }
    }
}
