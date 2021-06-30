using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWincoverage
{
    class UserModel
    {
        public static string name;
        public static string user;
        public static string email;
        public static string phone;
        public static string charge;
        public static string rol;

        public UserModel(string rool) 
        {
            rol = rool;
        }
    }
}
