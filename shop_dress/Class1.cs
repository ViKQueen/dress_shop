using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_dress
{
    public class checkUser
    {
        public string login { get; set; }

        public bool IsAdmin { get; }

        public string Stat => IsAdmin ? "Admin" : "User";

        public checkUser(string login, bool isAdmin)
        {
            login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
